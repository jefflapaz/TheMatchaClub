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
    public partial class CustomerHistoryForm : Form
    {
        public CustomerHistoryForm()
        {
            InitializeComponent();
            this.Load += CustomerHistoryForm_Load;
        }

        private async void CustomerHistoryForm_Load(object? sender, EventArgs e)
        {
            dgvHistory.AutoGenerateColumns = true;
            using var context = DbContextHelper.Create();

            var data = await context.Orders
                .OrderByDescending(x => x.CreatedAt)
                .Select(x => new
                {
                    x.CustomerName,
                    x.OrderNumber,
                    x.TotalAmount,
                    x.CreatedAt
                })
                .ToListAsync();

            dgvHistory.DataSource = data;
        }
    }

}
