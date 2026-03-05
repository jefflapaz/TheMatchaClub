namespace TheMatchaClub.Winforms
{
    partial class POSControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblSession = new Label();
            lblRunningTotal = new Label();
            lstOrders = new ListBox();
            cmbOrderType = new ComboBox();
            cmbPayment = new ComboBox();
            txtCustomer = new TextBox();
            lblOrderType = new Label();
            lblPayment = new Label();
            lblCustomer = new Label();
            pnlPOS = new Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            pnlStartSession = new CuoreUI.Controls.cuiPanel();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            lblStartHint = new CuoreUI.Controls.cuiLabel();
            btnStartSession = new CuoreUI.Controls.cuiButton();
            txtSessionName = new CuoreUI.Controls.cuiTextBox();
            btnRemove = new Guna.UI2.WinForms.Guna2Button();
            btnChoose = new Guna.UI2.WinForms.Guna2Button();
            btnCheckout = new Guna.UI2.WinForms.Guna2Button();
            btnSession = new Guna.UI2.WinForms.Guna2Button();
            pnlPOS.SuspendLayout();
            guna2Panel2.SuspendLayout();
            guna2Panel1.SuspendLayout();
            pnlStartSession.SuspendLayout();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSession
            // 
            lblSession.AutoSize = true;
            lblSession.Location = new Point(352, 56);
            lblSession.Name = "lblSession";
            lblSession.Size = new Size(49, 15);
            lblSession.TabIndex = 6;
            lblSession.Text = "Session:";
            // 
            // lblRunningTotal
            // 
            lblRunningTotal.AutoSize = true;
            lblRunningTotal.Location = new Point(38, 236);
            lblRunningTotal.Name = "lblRunningTotal";
            lblRunningTotal.Size = new Size(66, 15);
            lblRunningTotal.TabIndex = 4;
            lblRunningTotal.Text = "Total: ₱0.00";
            // 
            // lstOrders
            // 
            lstOrders.FormattingEnabled = true;
            lstOrders.ItemHeight = 15;
            lstOrders.Location = new Point(26, 95);
            lstOrders.Name = "lstOrders";
            lstOrders.Size = new Size(294, 124);
            lstOrders.TabIndex = 0;
            // 
            // cmbOrderType
            // 
            cmbOrderType.FormattingEnabled = true;
            cmbOrderType.Location = new Point(122, 145);
            cmbOrderType.Name = "cmbOrderType";
            cmbOrderType.Size = new Size(152, 23);
            cmbOrderType.TabIndex = 5;
            // 
            // cmbPayment
            // 
            cmbPayment.FormattingEnabled = true;
            cmbPayment.Location = new Point(122, 98);
            cmbPayment.Name = "cmbPayment";
            cmbPayment.Size = new Size(152, 23);
            cmbPayment.TabIndex = 4;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(122, 61);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(152, 23);
            txtCustomer.TabIndex = 3;
            // 
            // lblOrderType
            // 
            lblOrderType.AutoSize = true;
            lblOrderType.Location = new Point(19, 145);
            lblOrderType.Name = "lblOrderType";
            lblOrderType.Size = new Size(67, 15);
            lblOrderType.TabIndex = 2;
            lblOrderType.Text = "Order Type:";
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Location = new Point(19, 106);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(57, 15);
            lblPayment.TabIndex = 1;
            lblPayment.Text = "Payment:";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(19, 64);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(97, 15);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "Customer Name:";
            // 
            // pnlPOS
            // 
            pnlPOS.AutoSize = true;
            pnlPOS.BackColor = Color.FromArgb(225, 244, 206);
            pnlPOS.Controls.Add(btnSession);
            pnlPOS.Controls.Add(guna2Panel2);
            pnlPOS.Controls.Add(guna2Panel1);
            pnlPOS.Controls.Add(lblSession);
            pnlPOS.Dock = DockStyle.Fill;
            pnlPOS.Location = new Point(0, 0);
            pnlPOS.Name = "pnlPOS";
            pnlPOS.Size = new Size(1460, 730);
            pnlPOS.TabIndex = 8;
            // 
            // guna2Panel2
            // 
            guna2Panel2.BackColor = Color.Transparent;
            guna2Panel2.Controls.Add(cmbOrderType);
            guna2Panel2.Controls.Add(txtCustomer);
            guna2Panel2.Controls.Add(cmbPayment);
            guna2Panel2.Controls.Add(lblCustomer);
            guna2Panel2.Controls.Add(lblPayment);
            guna2Panel2.Controls.Add(lblOrderType);
            guna2Panel2.CustomizableEdges = customizableEdges3;
            guna2Panel2.FillColor = Color.FromArgb(245, 245, 221);
            guna2Panel2.Location = new Point(501, 176);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel2.Size = new Size(340, 342);
            guna2Panel2.TabIndex = 9;
            // 
            // guna2Panel1
            // 
            guna2Panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderRadius = 30;
            guna2Panel1.Controls.Add(btnCheckout);
            guna2Panel1.Controls.Add(btnChoose);
            guna2Panel1.Controls.Add(btnRemove);
            guna2Panel1.Controls.Add(lblRunningTotal);
            guna2Panel1.Controls.Add(lstOrders);
            guna2Panel1.CustomizableEdges = customizableEdges11;
            guna2Panel1.FillColor = Color.FromArgb(245, 245, 221);
            guna2Panel1.Location = new Point(81, 179);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Panel1.Size = new Size(376, 339);
            guna2Panel1.TabIndex = 8;
            // 
            // pnlStartSession
            // 
            pnlStartSession.AutoSize = true;
            pnlStartSession.BackColor = Color.Transparent;
            pnlStartSession.Controls.Add(cuiPanel1);
            pnlStartSession.Dock = DockStyle.Fill;
            pnlStartSession.ForeColor = Color.LemonChiffon;
            pnlStartSession.Location = new Point(0, 0);
            pnlStartSession.Margin = new Padding(3, 2, 3, 2);
            pnlStartSession.Name = "pnlStartSession";
            pnlStartSession.OutlineThickness = 1F;
            pnlStartSession.PanelColor = Color.FromArgb(45, 83, 26);
            pnlStartSession.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            pnlStartSession.RightToLeft = RightToLeft.No;
            pnlStartSession.Rounding = new Padding(20);
            pnlStartSession.Size = new Size(1460, 730);
            pnlStartSession.TabIndex = 3;
            pnlStartSession.Enter += pnlStartSession_Enter;
            // 
            // cuiPanel1
            // 
            cuiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cuiPanel1.Controls.Add(lblStartHint);
            cuiPanel1.Controls.Add(btnStartSession);
            cuiPanel1.Controls.Add(txtSessionName);
            cuiPanel1.Location = new Point(0, 0);
            cuiPanel1.Margin = new Padding(3, 2, 3, 2);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.Padding = new Padding(0, 0, 9, 8);
            cuiPanel1.PanelColor = Color.FromArgb(225, 244, 206);
            cuiPanel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel1.Rounding = new Padding(20);
            cuiPanel1.Size = new Size(1448, 723);
            cuiPanel1.TabIndex = 6;
            // 
            // lblStartHint
            // 
            lblStartHint.Content = "No\\ Active\\ Session";
            lblStartHint.Font = new Font("Verdana", 16.2F, FontStyle.Bold);
            lblStartHint.ForeColor = Color.DarkOliveGreen;
            lblStartHint.HorizontalAlignment = StringAlignment.Center;
            lblStartHint.Location = new Point(528, 247);
            lblStartHint.Margin = new Padding(4);
            lblStartHint.Name = "lblStartHint";
            lblStartHint.Size = new Size(306, 45);
            lblStartHint.TabIndex = 3;
            lblStartHint.VerticalAlignment = StringAlignment.Near;
            // 
            // btnStartSession
            // 
            btnStartSession.CheckButton = false;
            btnStartSession.Checked = false;
            btnStartSession.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnStartSession.CheckedForeColor = Color.White;
            btnStartSession.CheckedImageTint = Color.White;
            btnStartSession.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnStartSession.Content = "Start";
            btnStartSession.DialogResult = DialogResult.None;
            btnStartSession.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnStartSession.ForeColor = Color.LemonChiffon;
            btnStartSession.HoverBackground = Color.White;
            btnStartSession.HoverForeColor = Color.DimGray;
            btnStartSession.HoverImageTint = Color.DimGray;
            btnStartSession.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnStartSession.Image = null;
            btnStartSession.ImageExpand = new Point(0, 0);
            btnStartSession.Location = new Point(616, 346);
            btnStartSession.Margin = new Padding(3, 2, 3, 2);
            btnStartSession.Name = "btnStartSession";
            btnStartSession.NormalBackground = Color.FromArgb(53, 108, 27);
            btnStartSession.NormalForeColor = Color.LemonChiffon;
            btnStartSession.NormalImageTint = Color.Black;
            btnStartSession.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnStartSession.OutlineThickness = 1F;
            btnStartSession.PressedBackground = Color.WhiteSmoke;
            btnStartSession.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnStartSession.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnStartSession.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnStartSession.Rounding = new Padding(15);
            btnStartSession.Size = new Size(130, 31);
            btnStartSession.TabIndex = 5;
            btnStartSession.TextAlignment = StringAlignment.Center;
            btnStartSession.TextPadding = -1;
            btnStartSession.TextSpacing = 2;
            btnStartSession.Click += btnStartSession_Click;
            // 
            // txtSessionName
            // 
            txtSessionName.BackgroundColor = Color.White;
            txtSessionName.Content = "";
            txtSessionName.FocusBackgroundColor = Color.White;
            txtSessionName.FocusImageTint = Color.White;
            txtSessionName.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txtSessionName.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSessionName.ForeColor = Color.Gray;
            txtSessionName.Image = null;
            txtSessionName.ImageExpand = new Point(0, 0);
            txtSessionName.ImageOffset = new Point(0, 0);
            txtSessionName.Location = new Point(508, 288);
            txtSessionName.Margin = new Padding(4, 3, 4, 3);
            txtSessionName.Multiline = false;
            txtSessionName.Name = "txtSessionName";
            txtSessionName.NormalImageTint = Color.White;
            txtSessionName.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtSessionName.Padding = new Padding(16, 11, 16, 0);
            txtSessionName.PasswordChar = false;
            txtSessionName.PlaceholderColor = Color.LightGray;
            txtSessionName.PlaceholderText = "Placeholder text..";
            txtSessionName.Rounding = new Padding(15);
            txtSessionName.Size = new Size(347, 38);
            txtSessionName.TabIndex = 4;
            txtSessionName.TextOffset = new Size(0, 0);
            txtSessionName.UnderlinedStyle = true;
            // 
            // btnRemove
            // 
            btnRemove.BorderRadius = 15;
            btnRemove.CustomizableEdges = customizableEdges9;
            btnRemove.DisabledState.BorderColor = Color.DarkGray;
            btnRemove.DisabledState.CustomBorderColor = Color.DarkGray;
            btnRemove.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnRemove.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnRemove.FillColor = Color.FromArgb(53, 108, 27);
            btnRemove.Font = new Font("Segoe UI", 9F);
            btnRemove.ForeColor = Color.White;
            btnRemove.Location = new Point(17, 286);
            btnRemove.Name = "btnRemove";
            btnRemove.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnRemove.Size = new Size(108, 25);
            btnRemove.TabIndex = 5;
            btnRemove.Text = "Remove";
            btnRemove.Click += this.btnRemove_Click;
            // 
            // btnChoose
            // 
            btnChoose.BorderRadius = 15;
            btnChoose.CustomizableEdges = customizableEdges7;
            btnChoose.DisabledState.BorderColor = Color.DarkGray;
            btnChoose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnChoose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnChoose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnChoose.FillColor = Color.FromArgb(53, 108, 27);
            btnChoose.Font = new Font("Segoe UI", 9F);
            btnChoose.ForeColor = Color.White;
            btnChoose.Location = new Point(212, 33);
            btnChoose.Name = "btnChoose";
            btnChoose.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnChoose.Size = new Size(108, 25);
            btnChoose.TabIndex = 6;
            btnChoose.Text = "Choose Order";
            btnChoose.Click += this.btnChoose_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.BorderRadius = 15;
            btnCheckout.CustomizableEdges = customizableEdges5;
            btnCheckout.DisabledState.BorderColor = Color.DarkGray;
            btnCheckout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCheckout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCheckout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCheckout.FillColor = Color.FromArgb(53, 108, 27);
            btnCheckout.Font = new Font("Segoe UI", 9F);
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(212, 286);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnCheckout.Size = new Size(108, 25);
            btnCheckout.TabIndex = 7;
            btnCheckout.Text = "CHECKOUT";
            btnCheckout.Click += this.btnCheckout_Click;
            // 
            // btnSession
            // 
            btnSession.BorderRadius = 15;
            btnSession.CustomizableEdges = customizableEdges1;
            btnSession.DisabledState.BorderColor = Color.DarkGray;
            btnSession.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSession.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSession.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSession.FillColor = Color.FromArgb(53, 108, 27);
            btnSession.Font = new Font("Segoe UI", 9F);
            btnSession.ForeColor = Color.White;
            btnSession.Location = new Point(438, 88);
            btnSession.Name = "btnSession";
            btnSession.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSession.Size = new Size(108, 25);
            btnSession.TabIndex = 8;
            btnSession.Text = "End Session";
            btnSession.Click += btnEndSession_Click;
            // 
            // POSControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 83, 26);
            Controls.Add(pnlPOS);
            Controls.Add(pnlStartSession);
            DoubleBuffered = true;
            Name = "POSControl";
            Size = new Size(1460, 730);
            pnlPOS.ResumeLayout(false);
            pnlPOS.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            pnlStartSession.ResumeLayout(false);
            cuiPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblSession;
        private Panel panelOrder;
        private Label lblRunningTotal;
        private Button btnRemove;
        private Button btnCheckout;
        private Button btnChoose;
        private ListBox lstOrders;
        private ComboBox cmbOrderType;
        private ComboBox cmbPayment;
        private TextBox txtCustomer;
        private Label lblOrderType;
        private Label lblPayment;
        private Label lblCustomer;
        private Panel pnlPOS;
        private CuoreUI.Controls.cuiPanel pnlStartSession;
        private CuoreUI.Controls.cuiLabel lblStartHint;
        private CuoreUI.Controls.cuiButton btnStartSession;
        private CuoreUI.Controls.cuiTextBox txtSessionName;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnSession;
        private Guna.UI2.WinForms.Guna2Button btnCheckout;
        private Guna.UI2.WinForms.Guna2Button btnChoose;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btnEndSession;
    }
}
