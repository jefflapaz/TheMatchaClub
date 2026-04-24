using CuoreUI.Controls;
using Guna.UI2.WinForms;
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
using TheMatchaClub.Winforms.Forms;
using TheMatchaClub.WinForms.Helpers;

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
        private const int SIDEBAR_EXPANDED_WIDTH = 233;
        private const int SIDEBAR_COLLAPSED_WIDTH = 67;
        private const int SIDEBAR_BUTTON_MARGIN = 20;
        private const int ANIMATION_STEP = 15;

        public MainForm()
        {
            // Enable double buffering at the form level to prevent flicker
            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
            this.UpdateStyles();

            InitializeComponent();
            EnableDoubleBuffering(mainPanel);
            EnableDoubleBuffering(sidebar);

            // Apply themes and prevent GDI+ corruption
            ThemeManager.ApplyTheme(this);
            ThemeManager.EnableAntiCorruption(this);

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
                EnableDoubleBuffering(page);
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
            // Create a temporary form to host your LogoutBox UserControl
            Form popup = new Form();
            LogoutBox logoutControl = new LogoutBox();

            // Setup the popup appearance to match The Matcha Club aesthetic
            popup.FormBorderStyle = FormBorderStyle.None;
            popup.StartPosition = FormStartPosition.CenterParent;
            popup.BackColor = Color.FromArgb(245, 245, 221); // Matching your LogoutBox backcolor
            popup.Size = logoutControl.Size;

            // Add the control to the popup
            logoutControl.Dock = DockStyle.Fill;
            popup.Controls.Add(logoutControl);

            // Show it as a dialog (blocks interaction with MainForm until closed)
            popup.ShowDialog();
        }




        private void LoadPage(UserControl newPage)
        {
            // Suspend layout on the form and mainPanel to prevent flicker
            this.SuspendLayout();
            mainPanel.SuspendLayout();

            // Hide all existing controls without removing them
            foreach (Control ctrl in mainPanel.Controls)
            {
                ctrl.Visible = false;
            }

            // Add the page if not already added
            if (!mainPanel.Controls.Contains(newPage))
            {
                newPage.Dock = DockStyle.Fill;
                mainPanel.Controls.Add(newPage);
            }

            newPage.Visible = true;
            newPage.BringToFront();

            mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

            // Force a single, clean repaint
            mainPanel.Invalidate();
            mainPanel.Update();
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
            // Suspend layout on the entire form to prevent child controls from
            // relaying out individually on each tick (which causes flicker)
            this.SuspendLayout();

            if (_sidebarExpanded)
            {
                sidebar.Width -= ANIMATION_STEP;
                if (sidebar.Width <= SIDEBAR_COLLAPSED_WIDTH)
                {
                    sidebar.Width = SIDEBAR_COLLAPSED_WIDTH;
                    _sidebarExpanded = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += ANIMATION_STEP;
                if (sidebar.Width >= SIDEBAR_EXPANDED_WIDTH)
                {
                    sidebar.Width = SIDEBAR_EXPANDED_WIDTH;
                    _sidebarExpanded = true;
                    sidebarTransition.Stop();
                }
            }

            // Resize ALL navigation buttons to match sidebar width
            int newButtonWidth = sidebar.Width - SIDEBAR_BUTTON_MARGIN;
            btnPOS.Width = newButtonWidth;
            btnItems.Width = newButtonWidth;
            btnCustomer.Width = newButtonWidth;
            btnItemSales.Width = newButtonWidth;
            btnReport.Width = newButtonWidth;

            this.ResumeLayout(false);

            // Force a single, clean repaint of the affected areas
            sidebar.Invalidate();
            mainPanel.Invalidate();
            this.Update();
        }

        /// <summary>
        /// Override to enable WS_EX_COMPOSITED which double-buffers the entire
        /// form's window, eliminating child-control flicker during sidebar animation.
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                // WS_EX_COMPOSITED - enables double-buffered painting for all child controls
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}
