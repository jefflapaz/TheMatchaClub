using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using TheMatchaClub.Domain;
using TheMatchaClub.Domain.Entities;


namespace TheMatchaClub.Winforms
{
    public partial class ReceiptPreviewForm : Form
    {
        public ReceiptPreviewForm(
            Order order,
            List<CartItem> cart,
            decimal cash)
        {
            InitializeComponent();
            btnDone.Click += btnDone_Click;

            BuildReceipt(order, cart, cash);
        }

        private void BuildReceipt(Order order, List<CartItem> cart, decimal cash)
        {
            var sb = new StringBuilder();

            sb.AppendLine("        The Matcha Club");
            sb.AppendLine(DateTime.Now.ToString("MM/dd/yy hh:mm tt"));
            sb.AppendLine("----------------------------------");
            sb.AppendLine($"Order #: {order.OrderNumber}");
            sb.AppendLine($"Customer: {order.CustomerName}");
            sb.AppendLine($"Payment: {order.PaymentMethod}");
            sb.AppendLine($"Order Type: {order.OrderType}");
            sb.AppendLine("----------------------------------");

            foreach (var item in cart)
            {
                sb.AppendLine($"{item.Name}  {item.Quantity} x ₱{item.Price}  ₱{item.Price * item.Quantity}");
            }

            sb.AppendLine("----------------------------------");
            sb.AppendLine($"Total: ₱{order.TotalAmount}");
            sb.AppendLine($"Cash: ₱{cash}");
            sb.AppendLine($"Change: ₱{order.Change}");
            sb.AppendLine("==================================");

            rtbReceipt.Text = sb.ToString();
        }

        private void btnDone_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }

}
