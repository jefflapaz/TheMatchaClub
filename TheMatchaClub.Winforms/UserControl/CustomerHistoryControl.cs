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
    public partial class CustomerHistoryControl : UserControl
    {
        public CustomerHistoryControl()
        {
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
            this.UpdateStyles();

            InitializeComponent();
            this.DoubleBuffered = true;
            // Subscribe to the Load event
            this.Load += CustomerHistoryControl_Load;
        }

        private async void CustomerHistoryControl_Load(object? sender, EventArgs e)
        {
            dgvHistory.AutoGenerateColumns = true;
            await LoadData();
        }

        /// <summary>
        /// Fetches and filters order history from the database.
        /// </summary>
        /// <param name="searchTerm">The string to filter by (CustomerName or OrderNumber).</param>
        private async Task LoadData(string? searchTerm = null)
        {
            try
            {
                using var context = DbContextHelper.Create();

                // 1. Create the base query (IQueryable doesn't execute yet)
                var query = context.Orders.AsNoTracking();

                // 2. Add filtering logic if a search term is provided
                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    searchTerm = searchTerm.ToLower();
                    query = query.Where(x =>
                        x.CustomerName.ToLower().Contains(searchTerm) ||
                        x.OrderNumber.ToLower().Contains(searchTerm));
                }

                // 3. Project to an anonymous type and execute the query
                var data = await query
                    .OrderByDescending(x => x.CreatedAt)
                    .Select(x => new
                    {
                        x.CustomerName,
                        x.OrderNumber,
                        Total = x.TotalAmount,
                        Date = x.CreatedAt
                    })
                    .ToListAsync();

                // 4. Update the UI
                dgvHistory.DataSource = data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading history: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            // Triggered when the user clicks the search button
            await LoadData(txtSearch.Text);
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Live Search: Refresh results as the user types
            // We only search if it's empty (to reset) or long enough to be meaningful
            if (txtSearch.Text.Length >= 3 || txtSearch.Text.Length == 0)
            {
                await LoadData(txtSearch.Text);
            }
        }
    }
}