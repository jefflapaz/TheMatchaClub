using Microsoft.EntityFrameworkCore;
using System.Linq;
using TheMatchaClub.Domain;
using TheMatchaClub.Domain.Enums;
using TheMatchaClub.Infrastructure.Services;
using TheMatchaClub.WinForms.Helpers;


namespace TheMatchaClub.Winforms
{
    public partial class CheckoutDialog : Form
    {
        private readonly List<CartItem> _cart;
        private readonly string _customer;
        private readonly PaymentMethod _payment;
        private readonly OrderType _orderType;


        private decimal _total;

        public CheckoutDialog(List<CartItem> cart, string customer, PaymentMethod payment, OrderType orderType)
        {
            InitializeComponent();
            _cart = cart;
            _customer = customer;
            _payment = payment;
            _orderType = orderType;
            this.Load += CheckoutDialog_Load;
        }


        private async void CheckoutDialog_Load(object? sender, EventArgs e)
        {
            await LoadSummary();
        }

        private async Task LoadSummary()
        {
            lstSummary.Items.Clear();
            _total = 0;

            foreach (var item in _cart)
            {
                var sub = item.Price * item.Quantity;
                _total += sub;

                lstSummary.Items.Add($"{item.Name} x {item.Quantity} = ₱{sub}");
            }

            lblTotal.Text = $"Total: ₱{_total}";
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtCash.Text, out decimal cash))
            {
                MessageBox.Show("Invalid cash amount.");
                return;
            }

            if (cash < _total)
            {
                MessageBox.Show("Insufficient cash.");
                return;
            }

            try
            {
                using var context = DbContextHelper.Create();
                var orderService = new OrderService(context);

                var order = await orderService.CreateOrderAsync(
                    _customer,
                    _payment,
                    _orderType,
                    _cart.Select(x => (x.ItemId, x.Quantity)).ToList(),
    cash);

                using var receipt = new ReceiptPreviewForm(order, _cart, cash);
                receipt.ShowDialog();

                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }

}
