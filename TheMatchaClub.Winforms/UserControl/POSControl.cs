using Guna.UI2.WinForms;
using System;
using System.Linq;
using TheArtOfDevHtmlRenderer.Adapters;
using TheMatchaClub.Application.Services;
using TheMatchaClub.Domain;
using TheMatchaClub.Domain.Enums;
using TheMatchaClub.WinForms.Helpers;


namespace TheMatchaClub.Winforms
{
    public partial class POSControl : UserControl

    {
        private List<CartItem> _cart = new();
        public event Action? OnSessionEnded;


        public POSControl()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            // Apply to internal panels if they are heavy
            pnlPOS.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
                  ?.SetValue(pnlPOS, true, null);

            Load += POSControl_Load;

        }


        private PaymentMethod _selectedPayment;
        private OrderType _selectedOrderType;



        private async void POSControl_Load(object? sender, EventArgs e)
        {
            // Link Enums to Radio Buttons via the Tag property
            rbtnGcash.Tag = PaymentMethod.GCash;
            rbtnCash.Tag = PaymentMethod.Cash;
            rbtnBank.Tag = PaymentMethod.Bank;

            rbtnDineIn.Tag = OrderType.DineIn;
            rbtnTakeOut.Tag = OrderType.TakeOut;
            rbtnDelivery.Tag = OrderType.Delivery;

            // Attach the single event to all Payment buttons
            rbtnGcash.CheckedChanged += RadioButton_CheckedChanged;
            rbtnCash.CheckedChanged += RadioButton_CheckedChanged;
            rbtnBank.CheckedChanged += RadioButton_CheckedChanged;

            // Attach the single event to all Order Type buttons
            rbtnDineIn.CheckedChanged += RadioButton_CheckedChanged;
            rbtnTakeOut.CheckedChanged += RadioButton_CheckedChanged;
            rbtnDelivery.CheckedChanged += RadioButton_CheckedChanged;

            // Set Defaults visually and logically
            rbtnCash.Checked = true;
            _selectedPayment = PaymentMethod.Cash;

            rbtnDineIn.Checked = true;
            _selectedOrderType = OrderType.DineIn;
            // Existing session logic...
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

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is not RadioButton rb || !rb.Checked)
                return;



            switch (rb.Tag)
            {
                case PaymentMethod payment:
                    _selectedPayment = payment;
                    break;

                case OrderType orderType:
                    _selectedOrderType = orderType;
                    break;
            }
        }
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0) { MessageBox.Show("Cart is empty."); return; }
            if (string.IsNullOrWhiteSpace(txtCustomer.Text)) { MessageBox.Show("Enter customer name."); return; }

            

            using var checkout = new CheckoutDialog(_cart, txtCustomer.Text, _selectedPayment, _selectedOrderType);

            if (checkout.ShowDialog() == DialogResult.OK)
            {
                ClearPOS();
            }
        }
        // Helper method to keep your code clean
        private void ClearPOS()
        {
            _cart.Clear();
            lstOrders.Items.Clear();
            txtCustomer.Clear();
            lblRunningTotal.Text = "Total: ₱0.00";

            // Reset visually AND logically to defaults
            rbtnCash.Checked = true;
            _selectedPayment = PaymentMethod.Cash;

            rbtnDineIn.Checked = true;
            _selectedOrderType = OrderType.DineIn;
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
            txtSessionName.Text = "";
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

        private void pnlStartSession_Enter(object sender, EventArgs e)
        {

        }

        private void panelCustomerInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlPaymentGroup_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
