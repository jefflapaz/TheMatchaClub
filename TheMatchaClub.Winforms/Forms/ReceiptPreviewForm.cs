using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TheMatchaClub.Domain;
using TheMatchaClub.Domain.Entities;
using TheMatchaClub.Winforms.Forms;
using TheMatchaClub.WinForms.Helpers; // Ensure this is here for MyUniversalBox

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
            try
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
                    // Cleaned up the spacing for a better receipt look
                    sb.AppendLine($"{item.Name.PadRight(15)} {item.Quantity}x ₱{item.Price}   ₱{item.Price * item.Quantity}");
                }

                sb.AppendLine("----------------------------------");
                sb.AppendLine($"Total:  ₱{order.TotalAmount}");
                sb.AppendLine($"Cash:   ₱{cash}");
                sb.AppendLine($"Change: ₱{order.Change}");
                sb.AppendLine("==================================");
                sb.AppendLine("   Thank you for visiting!   ");

                rtbReceipt.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MyUniversalBox.Show("Failed to generate receipt preview: " + ex.Message, "System Error", isError: true);
            }
        }

        private void btnDone_Click(object? sender, EventArgs e)
        {
            // Optional: A final success message to wrap up the sale
            MyUniversalBox.Show("Transaction completed successfully. Have a great day!", "The Matcha Club", isError: false);

            this.Close();
        }
    }
}