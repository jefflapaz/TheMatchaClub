using System;
using TheMatchaClub.Domain;
using System.Linq;
using TheMatchaClub.Domain.Enums;
using TheMatchaClub.Infrastructure.Services;
using TheMatchaClub.WinForms.Helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace TheMatchaClub.Winforms
{
    public partial class POSControl : UserControl

    {
        private List<CartItem> _cart = new();
        public event Action? OnSessionEnded;


        public POSControl()
        {
            InitializeComponent();
            Load += POSControl_Load;
        }

        private async void POSControl_Load(object? sender, EventArgs e)
        {
            cmbPayment.Items.Clear();
            cmbPayment.Items.AddRange(Enum.GetNames(typeof(PaymentMethod)));

            cmbOrderType.Items.Clear();
            cmbOrderType.Items.AddRange(Enum.GetNames(typeof(OrderType)));

            using var context = DbContextHelper.Create();
            var sessionService = new SessionService(context);

            var session = await sessionService.GetActiveSessionAsync();

            if (session == null)
            {
                pnlStartSession.Visible = true;
                pnlPOS.Visible = false;
            }
            else
            {
                pnlStartSession.Visible = false;
                pnlPOS.Visible = true;
                lblSession.Text = $"Session: {session.SessionName}";
            }
        }



        private void btnChoose_Click(object sender, EventArgs e)
        {

            using var dialog = new ChooseItemDialog();

            if (dialog.ShowDialog() == DialogResult.OK && dialog.SelectedItem != null)
            {
                var existing = _cart.FirstOrDefault(x => x.ItemId == dialog.SelectedItem.ItemId);

                if (existing != null)
                    existing.Quantity += dialog.SelectedItem.Quantity;
                else
                    _cart.Add(dialog.SelectedItem);

                RefreshOrderList();
            }


        }
        private void RefreshOrderList()
        {
            lstOrders.Items.Clear();

            decimal total = 0;

            foreach (var item in _cart)
            {
                var sub = item.Price * item.Quantity;
                total += sub;

                lstOrders.Items.Add($"{item.Name} x {item.Quantity} = ₱{sub}");
            }

            lblRunningTotal.Text = $"Total: ₱{total}";
        }


        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0)
            {
                MessageBox.Show("Cart is empty.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCustomer.Text))
            {
                MessageBox.Show("Enter customer name.");
                return;
            }

            if (cmbPayment.SelectedItem == null || cmbOrderType.SelectedItem == null)
            {
                MessageBox.Show("Select payment and order type.");
                return;
            }

            var payment = Enum.Parse<PaymentMethod>(cmbPayment.SelectedItem.ToString()!);
            var orderType = Enum.Parse<OrderType>(cmbOrderType.SelectedItem.ToString()!);

            using var checkout = new CheckoutDialog(_cart, txtCustomer.Text, payment, orderType);

            if (checkout.ShowDialog() == DialogResult.OK)
            {
                _cart.Clear();
                lstOrders.Items.Clear();
                txtCustomer.Clear();
                cmbPayment.SelectedIndex = -1;
                cmbOrderType.SelectedIndex = -1;
                lblRunningTotal.Text = "Total: ₱0.00";
            }



        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstOrders.SelectedIndex < 0)
                return;

            _cart.RemoveAt(lstOrders.SelectedIndex);

            RefreshOrderList();
        }

        private async void btnEndSession_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Are you sure you want to end this session?",
                "End Session",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes)
                return;

            using var context = DbContextHelper.Create();
            var sessionService = new SessionService(context);

            await sessionService.EndSessionAsync();

            MessageBox.Show("Session ended.");

            // Reset UI instead of exiting app
            lblSession.Text = "";
            txtSessionName.Clear();
            pnlPOS.Visible = false;
            pnlStartSession.Visible = true;
        }


        private async void btnStartSession_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSessionName.Text))
            {
                MessageBox.Show("Enter session name.");
                return;
            }

            using var context = DbContextHelper.Create();
            var sessionService = new SessionService(context);

            await sessionService.StartSessionAsync(txtSessionName.Text);

            lblSession.Text = $"Session: {txtSessionName.Text}";

            pnlStartSession.Visible = false;
            pnlPOS.Visible = true;
        }

    }
}
