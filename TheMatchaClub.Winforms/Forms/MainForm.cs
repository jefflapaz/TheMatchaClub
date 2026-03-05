using CuoreUI.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheMatchaClub.Application.Services;
using TheMatchaClub.WinForms.Helpers;
using Guna.UI2.WinForms;

namespace TheMatchaClub.Winforms
{
    public partial class MainForm : Form
    {
        private bool _sidebarExpanded = true;
        private POSControl _pos;
        private ItemsControl _items;
        private CustomerHistoryControl _customerHistory;
        private ItemSalesControl _itemSales;
        private SalesReportControl _salesReport;
        private cuiButton _activeButton;
    
        public MainForm()
        {
            InitializeComponent();
            EnableDoubleBuffering(mainPanel);
            InitializePages();
            ActivateButton(btnPOS);
            LoadPage(_pos);
        }

        private void InitializePages()
        {
            _pos = new POSControl();
            _items = new ItemsControl();
            _customerHistory = new CustomerHistoryControl();
            _itemSales = new ItemSalesControl();
            _salesReport = new SalesReportControl();

            foreach (var page in new UserControl[]
            {
                  _pos, _items, _customerHistory, _itemSales, _salesReport
            })
            {
                page.Dock = DockStyle.Fill;
            }
        }

        private void EnableDoubleBuffering(Control control)
        {
            var property = typeof(Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            property?.SetValue(control, true, null);
        }

        private void btnLogout1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(
                "Choose an option:\n\nYes = Logout only\nNo = Logout & Exit\nCancel = Stay",
                "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                new LoginForm().Show();
                this.Close();
            }
            else if (result == DialogResult.No)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void LoadPage(UserControl newPage)
        {
            mainPanel.SuspendLayout(); 
            foreach (Control ctrl in mainPanel.Controls) { ctrl.Visible = false; }
            if (!mainPanel.Controls.Contains(newPage)) 
            {
                newPage.Dock = DockStyle.Fill; mainPanel.Controls.Add(newPage);
            }
            newPage.Visible = true; 
            newPage.BringToFront();
            mainPanel.ResumeLayout(true);
        }

        private void ActivateButton(cuiButton btn)
        {
            if (_activeButton != null)
            {
                _activeButton.BackColor = Color.Transparent;
                _activeButton.ForeColor = Color.White;
                _activeButton.Region = null;
                _activeButton.Resize -= ActiveButton_Resize;
                
            }

            _activeButton = btn;
            _activeButton.BackColor = Color.White;
            _activeButton.ForeColor = Color.Black;
          

            ApplyRounding(_activeButton);
            _activeButton.Resize += ActiveButton_Resize;
        }

        private void ActiveButton_Resize(object? sender, EventArgs e)
        {
            if (sender is cuiButton btn)
                ApplyRounding(btn);
        }

        private void ApplyRounding(cuiButton btn)
        {
            int radius = 20;

            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                btn.Region = new Region(path);
            }
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            ActivateButton(btnPOS);
            LoadPage(_pos);
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            ActivateButton(btnItems);
            LoadPage(_items);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ActivateButton(btnCustomer);
            LoadPage(_customerHistory);
        }

        private void btnItemSales_Click(object sender, EventArgs e)
        {
            ActivateButton(btnItemSales);
            LoadPage(_itemSales);
        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            ActivateButton(btnReport);
            LoadPage(_salesReport);
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            int step = 10;
            sidebar.SuspendLayout();
            mainPanel.SuspendLayout();

            if (_sidebarExpanded)
            {
                sidebar.Width -= step;
                if (sidebar.Width <= 67)
                {
                    sidebar.Width = 67;
                    _sidebarExpanded = false;
                    sidebarTransition.Stop();
                }
                btnPOS.Width = sidebar.Width - 20;
            }
            else
            {
                sidebar.Width += step;
                if (sidebar.Width >= 233)
                {
                    sidebar.Width = 233;
                    _sidebarExpanded = true;
                    sidebarTransition.Stop();
                }

                btnPOS.Width = sidebar.Width- 20;
            }
            sidebar.ResumeLayout();
            mainPanel.ResumeLayout();

        }
    }
}
