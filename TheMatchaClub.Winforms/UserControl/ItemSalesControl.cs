using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
            this.UpdateStyles();

            InitializeComponent();
            this.DoubleBuffered = true;
            this.Load += ItemSalesControl_Load;
        }

        private async void ItemSalesControl_Load(object? sender, EventArgs e)
        {
            // Initial load with no search term
            await LoadDataAsync();
        }

        /// <summary>
        /// Centralized logic to fetch, filter, and display sales data.
        /// </summary>
        private async Task LoadDataAsync(string searchTerm = "")
        {
            try
            {
                using var context = DbContextHelper.Create();

                // 1. Setup Date Range (Ensures better SQL translation than .Date)
                var today = DateTime.Today;
                var tomorrow = today.AddDays(1);

                // 2. Build the Base Query
                var query = context.OrderItems
                    .Include(x => x.Item)
                        .ThenInclude(i => i.Category)
                    .Include(x => x.Order)
                    .Where(x => x.Order.CreatedAt >= today && x.Order.CreatedAt < tomorrow);

                // 3. Apply Search Filter if provided
                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    string term = searchTerm.ToLower();
                    query = query.Where(x =>
                        x.Item.Name.ToLower().Contains(term) ||
                        x.Item.Category.Name.ToLower().Contains(term));
                }

                // 4. Group and Project the Data
                var data = await query
                    .GroupBy(x => new
                    {
                        x.Item.Name,
                        CategoryName = x.Item.Category.Name,
                        x.UnitPrice
                    })
                    .Select(g => new
                    {
                        ItemName = g.Key.Name,
                        Category = g.Key.CategoryName,
                        Quantity = g.Sum(x => x.Quantity),
                        UnitPrice = g.Key.UnitPrice,
                        Total = g.Sum(x => x.SubTotal)
                    })
                    .ToListAsync();

                // 5. Update UI
                dgvItems.DataSource = null; // Reset to avoid binding glitches
                dgvItems.DataSource = data;
                dgvItems.AutoGenerateColumns = true;

                decimal grandTotal = data.Sum(x => x.Total);
                lblGrandTotal.Text = $"Grand Total: ₱{grandTotal:N2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading sales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            await LoadDataAsync(txtSearch.Text);
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Optional: Live search triggers if user clears the box or types 3+ chars
            if (string.IsNullOrWhiteSpace(txtSearch.Text) || txtSearch.Text.Length >= 3)
            {
                await LoadDataAsync(txtSearch.Text);
            }
        }
    }
}