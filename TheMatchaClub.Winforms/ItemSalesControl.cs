using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
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
                    Category = x.Item.Category.Name,
                    x.UnitPrice
                })
                .Select(g => new
                {
                    ItemName = g.Key.Name,
                    Category = g.Key.Category,
                    Quantity = g.Sum(x => x.Quantity),
                    UnitPrice = g.Key.UnitPrice,
                    Total = g.Sum(x => x.SubTotal)
                })
                .ToListAsync();

            dgvItems.AutoGenerateColumns = true;
            dgvItems.DataSource = data;

            decimal grandTotal = data.Sum(x => x.Total);
            lblGrandTotal.Text = $"Grand Total: ₱{grandTotal}";
        }
    }

}
