using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheMatchaClub.Infrastructure.Services;
using TheMatchaClub.WinForms.Helpers;


namespace TheMatchaClub.Winforms
{
    public partial class MainForm : Form
    {
        private POSControl _pos;
        private ItemsControl _items;
        private CustomerHistoryControl _customerHistory;
        private ItemSalesControl _itemSales;
        private SalesReportControl _salesReport;

        public MainForm()
        {
            InitializeComponent();
            _pos = new POSControl();
            _pos.Dock = DockStyle.Fill;
            _items = new ItemsControl();
            _items.Dock = DockStyle.Fill;
            _customerHistory = new CustomerHistoryControl();
            _customerHistory.Dock = DockStyle.Fill;
            _itemSales = new ItemSalesControl();
            _itemSales.Dock = DockStyle.Fill;
            _salesReport = new SalesReportControl();
            _salesReport.Dock = DockStyle.Fill;

            pnlContent.Controls.Add(_pos);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Choose an option:\n\nYes = Logout only\nNo = Logout & Exit\nCancel = Stay",
                "Exit",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            // YES → Logout only
            if (result == DialogResult.Yes)
            {
                var login = new LoginForm();
                login.Show();
                this.Close();
                return;
            }

            // NO → Logout & Exit
            if (result == DialogResult.No)
            {
                System.Windows.Forms.Application.Exit();
                return;
            }

            // CANCEL → do nothing
        }


        private void btnPOS_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(_pos);
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(_items);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(_customerHistory);
        }

        private void btnItemSales_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(_itemSales);
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(_salesReport);
        }

    }
}
