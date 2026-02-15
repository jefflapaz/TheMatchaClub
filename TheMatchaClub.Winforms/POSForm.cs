using System;
using TheMatchaClub.Domain;
using System.Linq;
using TheMatchaClub.Domain.Enums;
using TheMatchaClub.Infrastructure.Services;
using TheMatchaClub.WinForms.Helpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace TheMatchaClub.Winforms
{
    public partial class POSForm : Form
    {
        private List<CartItem> _cart = new();


        public POSForm()
        {
            InitializeComponent();
            this.Load += POSForm_Load;
        }
        private void POSForm_Load(object? sender, EventArgs e)
        {
            cmbPayment.Items.Clear();
            cmbPayment.Items.AddRange(Enum.GetNames(typeof(PaymentMethod)));

            cmbOrderType.Items.Clear();
            cmbOrderType.Items.AddRange(Enum.GetNames(typeof(OrderType)));
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

            foreach (var item in _cart)
            {
                lstOrders.Items.Add($"{item.Name} x {item.Quantity} = ₱{item.Price * item.Quantity}");
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
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
                lstOrders.Items.Clear();
                _cart.Clear();
                txtCustomer.Clear();
            }


        }
    }
}
