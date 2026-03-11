namespace TheMatchaClub.Winforms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            sidebar = new CuoreUI.Controls.cuiPanel();
            btnLogout1 = new CuoreUI.Controls.cuiButton();
            btnItems = new CuoreUI.Controls.cuiButton();
            btnReport = new CuoreUI.Controls.cuiButton();
            btnPOS = new CuoreUI.Controls.cuiButton();
            btnItemSales = new CuoreUI.Controls.cuiButton();
            btnCustomer = new CuoreUI.Controls.cuiButton();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            mainPanel = new CuoreUI.Controls.cuiPanel();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            sidebar.SuspendLayout();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.Transparent;
            sidebar.Controls.Add(btnLogout1);
            sidebar.Controls.Add(btnItems);
            sidebar.Controls.Add(btnReport);
            sidebar.Controls.Add(btnPOS);
            sidebar.Controls.Add(btnItemSales);
            sidebar.Controls.Add(btnCustomer);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 59);
            sidebar.Margin = new Padding(0);
            sidebar.Name = "sidebar";
            sidebar.OutlineThickness = 0F;
            sidebar.PanelColor = Color.FromArgb(45, 83, 26);
            sidebar.PanelOutlineColor = Color.FromArgb(45, 83, 26);
            sidebar.Rounding = new Padding(0);
            sidebar.Size = new Size(233, 861);
            sidebar.TabIndex = 6;
            // 
            // btnLogout1
            // 
            btnLogout1.BackColor = Color.Transparent;
            btnLogout1.CheckButton = false;
            btnLogout1.Checked = false;
            btnLogout1.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnLogout1.CheckedForeColor = Color.White;
            btnLogout1.CheckedImageTint = Color.White;
            btnLogout1.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnLogout1.Content = "Logout";
            btnLogout1.DialogResult = DialogResult.None;
            btnLogout1.Dock = DockStyle.Bottom;
            btnLogout1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            btnLogout1.ForeColor = Color.Black;
            btnLogout1.HoverBackground = Color.White;
            btnLogout1.HoverForeColor = Color.DimGray;
            btnLogout1.HoverImageTint = Color.DimGray;
            btnLogout1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnLogout1.Image = null;
            btnLogout1.ImageExpand = new Point(0, 0);
            btnLogout1.Location = new Point(0, 816);
            btnLogout1.Name = "btnLogout1";
            btnLogout1.NormalBackground = Color.White;
            btnLogout1.NormalForeColor = Color.Black;
            btnLogout1.NormalImageTint = Color.Black;
            btnLogout1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnLogout1.OutlineThickness = 1F;
            btnLogout1.PressedBackground = Color.WhiteSmoke;
            btnLogout1.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnLogout1.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnLogout1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnLogout1.Rounding = new Padding(15);
            btnLogout1.Size = new Size(233, 45);
            btnLogout1.TabIndex = 11;
            btnLogout1.TextAlignment = StringAlignment.Center;
            btnLogout1.TextPadding = -1;
            btnLogout1.TextSpacing = 2;
            btnLogout1.Click += btnLogout1_Click;
            // 
            // btnItems
            // 
            btnItems.BackColor = Color.Transparent;
            btnItems.BackgroundImage = (Image)resources.GetObject("btnItems.BackgroundImage");
            btnItems.BackgroundImageLayout = ImageLayout.None;
            btnItems.CheckButton = false;
            btnItems.Checked = false;
            btnItems.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnItems.CheckedForeColor = Color.White;
            btnItems.CheckedImageTint = Color.White;
            btnItems.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnItems.Content = "   Items";
            btnItems.DialogResult = DialogResult.None;
            btnItems.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Bold);
            btnItems.ForeColor = Color.White;
            btnItems.HoverBackground = Color.White;
            btnItems.HoverForeColor = Color.DimGray;
            btnItems.HoverImageTint = Color.DimGray;
            btnItems.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnItems.Image = null;
            btnItems.ImageExpand = new Point(0, 0);
            btnItems.Location = new Point(11, 227);
            btnItems.Name = "btnItems";
            btnItems.NormalBackground = Color.Transparent;
            btnItems.NormalForeColor = Color.White;
            btnItems.NormalImageTint = Color.Black;
            btnItems.NormalOutline = Color.FromArgb(45, 83, 26);
            btnItems.OutlineThickness = 1F;
            btnItems.PressedBackground = Color.WhiteSmoke;
            btnItems.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnItems.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnItems.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnItems.Rounding = new Padding(15);
            btnItems.Size = new Size(210, 45);
            btnItems.TabIndex = 2;
            btnItems.TextAlignment = StringAlignment.Center;
            btnItems.TextPadding = -1;
            btnItems.TextSpacing = 2;
            btnItems.Click += btnItems_Click;
            // 
            // btnReport
            // 
            btnReport.BackColor = Color.Transparent;
            btnReport.BackgroundImage = Properties.Resources.edit;
            btnReport.BackgroundImageLayout = ImageLayout.None;
            btnReport.CheckButton = false;
            btnReport.Checked = false;
            btnReport.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnReport.CheckedForeColor = Color.White;
            btnReport.CheckedImageTint = Color.White;
            btnReport.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnReport.Content = "    Sales Report";
            btnReport.DialogResult = DialogResult.None;
            btnReport.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnReport.ForeColor = Color.White;
            btnReport.HoverBackground = Color.White;
            btnReport.HoverForeColor = Color.DimGray;
            btnReport.HoverImageTint = Color.DimGray;
            btnReport.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnReport.Image = null;
            btnReport.ImageExpand = new Point(0, 0);
            btnReport.Location = new Point(11, 413);
            btnReport.Name = "btnReport";
            btnReport.NormalBackground = Color.Transparent;
            btnReport.NormalForeColor = Color.White;
            btnReport.NormalImageTint = Color.Black;
            btnReport.NormalOutline = Color.Transparent;
            btnReport.OutlineThickness = 1F;
            btnReport.PressedBackground = Color.WhiteSmoke;
            btnReport.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnReport.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnReport.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnReport.Rounding = new Padding(15);
            btnReport.Size = new Size(210, 45);
            btnReport.TabIndex = 9;
            btnReport.TextAlignment = StringAlignment.Center;
            btnReport.TextPadding = -1;
            btnReport.TextSpacing = 2;
            btnReport.Click += btnReport_Click;
            // 
            // btnPOS
            // 
            btnPOS.BackColor = Color.Transparent;
            btnPOS.BackgroundImageLayout = ImageLayout.None;
            btnPOS.CheckButton = false;
            btnPOS.Checked = false;
            btnPOS.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnPOS.CheckedForeColor = Color.White;
            btnPOS.CheckedImageTint = Color.White;
            btnPOS.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnPOS.Content = "        POS";
            btnPOS.DialogResult = DialogResult.None;
            btnPOS.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnPOS.ForeColor = Color.White;
            btnPOS.HoverBackground = Color.White;
            btnPOS.HoverForeColor = Color.DimGray;
            btnPOS.HoverImageTint = Color.DimGray;
            btnPOS.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnPOS.Image = Properties.Resources.Pokecut_1772532916810;
            btnPOS.ImageExpand = new Point(11, 11);
            btnPOS.Location = new Point(11, 164);
            btnPOS.Name = "btnPOS";
            btnPOS.NormalBackground = Color.Transparent;
            btnPOS.NormalForeColor = Color.White;
            btnPOS.NormalImageTint = Color.White;
            btnPOS.NormalOutline = Color.Transparent;
            btnPOS.OutlineThickness = 1F;
            btnPOS.PressedBackground = Color.WhiteSmoke;
            btnPOS.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnPOS.PressedImageTint = Color.Black;
            btnPOS.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnPOS.Rounding = new Padding(15);
            btnPOS.Size = new Size(210, 45);
            btnPOS.TabIndex = 7;
            btnPOS.TextAlignment = StringAlignment.Near;
            btnPOS.TextPadding = -1;
            btnPOS.TextSpacing = 2;
            btnPOS.Click += btnPOS_Click;
            // 
            // btnItemSales
            // 
            btnItemSales.BackColor = Color.Transparent;
            btnItemSales.BackgroundImage = Properties.Resources.growth;
            btnItemSales.BackgroundImageLayout = ImageLayout.None;
            btnItemSales.CheckButton = false;
            btnItemSales.Checked = false;
            btnItemSales.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnItemSales.CheckedForeColor = Color.White;
            btnItemSales.CheckedImageTint = Color.White;
            btnItemSales.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnItemSales.Content = "    Item Sales";
            btnItemSales.DialogResult = DialogResult.None;
            btnItemSales.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnItemSales.ForeColor = Color.White;
            btnItemSales.HoverBackground = Color.White;
            btnItemSales.HoverForeColor = Color.DimGray;
            btnItemSales.HoverImageTint = Color.DimGray;
            btnItemSales.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnItemSales.Image = null;
            btnItemSales.ImageExpand = new Point(0, 0);
            btnItemSales.Location = new Point(12, 349);
            btnItemSales.Name = "btnItemSales";
            btnItemSales.NormalBackground = Color.Transparent;
            btnItemSales.NormalForeColor = Color.White;
            btnItemSales.NormalImageTint = Color.Black;
            btnItemSales.NormalOutline = Color.Transparent;
            btnItemSales.OutlineThickness = 1F;
            btnItemSales.PressedBackground = Color.WhiteSmoke;
            btnItemSales.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnItemSales.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnItemSales.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnItemSales.Rounding = new Padding(15);
            btnItemSales.Size = new Size(210, 45);
            btnItemSales.TabIndex = 9;
            btnItemSales.TextAlignment = StringAlignment.Center;
            btnItemSales.TextPadding = -1;
            btnItemSales.TextSpacing = 2;
            btnItemSales.Click += btnItemSales_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.BackColor = Color.Transparent;
            btnCustomer.BackgroundImage = Properties.Resources.user;
            btnCustomer.BackgroundImageLayout = ImageLayout.None;
            btnCustomer.CheckButton = false;
            btnCustomer.Checked = false;
            btnCustomer.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnCustomer.CheckedForeColor = Color.White;
            btnCustomer.CheckedImageTint = Color.White;
            btnCustomer.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnCustomer.Content = "       Customer Sale";
            btnCustomer.DialogResult = DialogResult.None;
            btnCustomer.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Bold);
            btnCustomer.ForeColor = Color.White;
            btnCustomer.HoverBackground = Color.White;
            btnCustomer.HoverForeColor = Color.DimGray;
            btnCustomer.HoverImageTint = Color.DimGray;
            btnCustomer.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnCustomer.Image = null;
            btnCustomer.ImageExpand = new Point(0, 0);
            btnCustomer.Location = new Point(14, 291);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.NormalBackground = Color.Transparent;
            btnCustomer.NormalForeColor = Color.White;
            btnCustomer.NormalImageTint = Color.Black;
            btnCustomer.NormalOutline = Color.Transparent;
            btnCustomer.OutlineThickness = 1F;
            btnCustomer.PressedBackground = Color.WhiteSmoke;
            btnCustomer.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnCustomer.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnCustomer.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnCustomer.Rounding = new Padding(15);
            btnCustomer.Size = new Size(207, 43);
            btnCustomer.TabIndex = 10;
            btnCustomer.TextAlignment = StringAlignment.Center;
            btnCustomer.TextPadding = -1;
            btnCustomer.TextSpacing = 2;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // cuiButton1
            // 
            cuiButton1.BackColor = Color.Transparent;
            cuiButton1.BackgroundImage = Properties.Resources.menu_bar__1_;
            cuiButton1.BackgroundImageLayout = ImageLayout.Center;
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = Color.Transparent;
            cuiButton1.CheckedImageTint = Color.Transparent;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButton1.ForeColor = Color.Black;
            cuiButton1.HoverBackground = Color.Transparent;
            cuiButton1.HoverForeColor = Color.DimGray;
            cuiButton1.HoverImageTint = Color.DimGray;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = null;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.Location = new Point(11, 7);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.Transparent;
            cuiButton1.NormalForeColor = Color.Black;
            cuiButton1.NormalImageTint = Color.Black;
            cuiButton1.NormalOutline = Color.Transparent;
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.PressedBackground = Color.WhiteSmoke;
            cuiButton1.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedImageTint = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(43, 45);
            cuiButton1.TabIndex = 12;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextPadding = -1;
            cuiButton1.TextSpacing = 2;
            cuiButton1.Click += cuiButton1_Click;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "The\\ Matcha\\ Club";
            cuiLabel1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold);
            cuiLabel1.ForeColor = Color.LemonChiffon;
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(53, 12);
            cuiLabel1.Margin = new Padding(5);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(265, 37);
            cuiLabel1.TabIndex = 6;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // mainPanel
            // 
            mainPanel.AutoSize = true;
            mainPanel.BackColor = Color.Transparent;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(233, 59);
            mainPanel.Margin = new Padding(0);
            mainPanel.Name = "mainPanel";
            mainPanel.OutlineThickness = 0F;
            mainPanel.PanelColor = Color.FromArgb(45, 83, 26);
            mainPanel.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            mainPanel.Rounding = new Padding(0);
            mainPanel.Size = new Size(1388, 861);
            mainPanel.TabIndex = 7;
            // 
            // cuiPanel1
            // 
            cuiPanel1.BackgroundImageLayout = ImageLayout.None;
            cuiPanel1.Controls.Add(cuiButton1);
            cuiPanel1.Controls.Add(cuiLabel1);
            cuiPanel1.Dock = DockStyle.Top;
            cuiPanel1.Location = new Point(0, 0);
            cuiPanel1.Margin = new Padding(0);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.FromArgb(45, 83, 26);
            cuiPanel1.PanelOutlineColor = Color.FromArgb(45, 83, 26);
            cuiPanel1.Rounding = new Padding(0);
            cuiPanel1.Size = new Size(1621, 59);
            cuiPanel1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1621, 920);
            Controls.Add(mainPanel);
            Controls.Add(sidebar);
            Controls.Add(cuiPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            sidebar.ResumeLayout(false);
            cuiPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLogout;
        private System.Windows.Forms.Timer sidebarTransition;
        private CuoreUI.Controls.cuiPanel sidebar;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiButton btnLogout1;
        private CuoreUI.Controls.cuiButton btnItems;
        private CuoreUI.Controls.cuiButton btnReport;
        private CuoreUI.Controls.cuiButton btnPOS;
        private CuoreUI.Controls.cuiButton btnItemSales;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiButton btnCustomer;
        private CuoreUI.Controls.cuiPanel mainPanel;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
    }
}