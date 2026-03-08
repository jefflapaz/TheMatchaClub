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
    public partial class CustomerHistoryControl : UserControl
    {
        public CustomerHistoryControl()
        {
            InitializeComponent();
            this.Load += CustomerHistoryControl_Load;
        }

        private async void CustomerHistoryControl_Load(object? sender, EventArgs e)
        {
            await RefreshHistory();
        }

        public async Task RefreshHistory()
        {
            try
            {
                dgvHistory.AutoGenerateColumns = true;

                using var context = DbContextHelper.Create();

                var data = await context.Orders
                    .OrderByDescending(x => x.CreatedAt)
                    .Select(x => new
                    {
                        Customer = x.CustomerName,
                        OrderNo = x.OrderNumber,
                        Amount = "₱" + x.TotalAmount, // Formatting the currency
                        Date = x.CreatedAt.ToString("MM/dd/yyyy hh:mm tt") // Clean date format
                    })
                    .ToListAsync();

                dgvHistory.DataSource = data;
            }
            catch (Exception ex)
            {
                // Replaced silent failure with your custom typewriter alert
                MyUniversalBox.Show($"Could not load customer history: {ex.Message}", "Database Error", isError: true);
            }
        }
    }
}