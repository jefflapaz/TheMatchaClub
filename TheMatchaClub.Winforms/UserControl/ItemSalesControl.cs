using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheMatchaClub.Winforms.Forms;
using TheMatchaClub.WinForms.Helpers;

namespace TheMatchaClub.Winforms
{
    public partial class ItemSalesControl : UserControl
    {
        public ItemSalesControl()
        {
            InitializeComponent();
            Load += ItemSalesControl_Load;
        }

        private async void ItemSalesControl_Load(object? sender, EventArgs e)
        {
            await LoadDailySales();
        }

        public async Task LoadDailySales()
        {
            try
            {
                using var context = DbContextHelper.Create();

                var today = DateTime.Today;

                var data = await context.OrderItems
                    .Include(x => x.Item)
                        .ThenInclude(i => i.Category)
                    .Include(x => x.Order)
                    .Where(x => x.Order.CreatedAt.Date == today)
                    .GroupBy(x => new
                    {
                        x.Item.Name,
                        CategoryName = x.Item.Category.Name,
                        x.UnitPrice
                    })
                    .Select(g => new
                    {
                        Item = g.Key.Name,
                        Category = g.Key.CategoryName,
                        Qty = g.Sum(x => x.Quantity),
                        Price = "₱" + g.Key.UnitPrice,
                        Total = g.Sum(x => x.SubTotal)
                    })
                    .ToListAsync();

                dgvItems.AutoGenerateColumns = true;
                dgvItems.DataSource = data;

                decimal grandTotal = data.Sum(x => x.Total);
                lblGrandTotal.Text = $"Today's Total: ₱{grandTotal}";

                if (!data.Any())
                {
                    // Subtle notification that there are no sales yet today
                    MyUniversalBox.Show("No sales have been recorded for today yet.", "Daily Summary", isError: false);
                }
            }
            catch (Exception ex)
            {
                // Replaced standard error handling with your custom typewriter box
                MyUniversalBox.Show($"Error calculating daily sales: {ex.Message}", "Data Error", isError: true);
            }
        }
    }
}