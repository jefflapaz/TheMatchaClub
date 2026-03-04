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
            btnEndSession = new Button();
            lblSession = new Label();
            panelOrder = new Panel();
            lblRunningTotal = new Label();
            btnRemove = new Button();
            btnCheckout = new Button();
            btnChoose = new Button();
            lstOrders = new ListBox();
            panelCustomerInfo = new Panel();
            cmbOrderType = new ComboBox();
            cmbPayment = new ComboBox();
            txtCustomer = new TextBox();
            lblOrderType = new Label();
            lblPayment = new Label();
            lblCustomer = new Label();
            pnlPOS = new Panel();
            pnlStartSession = new CuoreUI.Controls.cuiPanel();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            lblStartHint = new CuoreUI.Controls.cuiLabel();
            btnStartSession = new CuoreUI.Controls.cuiButton();
            txtSessionName = new CuoreUI.Controls.cuiTextBox();
            panelOrder.SuspendLayout();
            panelCustomerInfo.SuspendLayout();
            pnlPOS.SuspendLayout();
            pnlStartSession.SuspendLayout();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEndSession
            // 
            btnEndSession.Location = new Point(632, 117);
            btnEndSession.Margin = new Padding(3, 4, 3, 4);
            btnEndSession.Name = "btnEndSession";
            btnEndSession.Size = new Size(133, 31);
            btnEndSession.TabIndex = 7;
            btnEndSession.Text = "End Session";
            btnEndSession.UseVisualStyleBackColor = true;
            btnEndSession.Click += btnEndSession_Click;
            // 
            // lblSession
            // 
            lblSession.AutoSize = true;
            lblSession.Location = new Point(573, 91);
            lblSession.Name = "lblSession";
            lblSession.Size = new Size(61, 20);
            lblSession.TabIndex = 6;
            lblSession.Text = "Session:";
            // 
            // panelOrder
            // 
            panelOrder.Controls.Add(lblRunningTotal);
            panelOrder.Controls.Add(btnRemove);
            panelOrder.Controls.Add(btnCheckout);
            panelOrder.Controls.Add(btnChoose);
            panelOrder.Controls.Add(lstOrders);
            panelOrder.Location = new Point(91, 156);
            panelOrder.Margin = new Padding(3, 4, 3, 4);
            panelOrder.Name = "panelOrder";
            panelOrder.Size = new Size(321, 360);
            panelOrder.TabIndex = 5;
            // 
            // lblRunningTotal
            // 
            lblRunningTotal.AutoSize = true;
            lblRunningTotal.Location = new Point(104, 275);
            lblRunningTotal.Name = "lblRunningTotal";
            lblRunningTotal.Size = new Size(85, 20);
            lblRunningTotal.TabIndex = 4;
            lblRunningTotal.Text = "Total: ₱0.00";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(155, 55);
            btnRemove.Margin = new Padding(3, 4, 3, 4);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(131, 31);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove Selected";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(97, 313);
            btnCheckout.Margin = new Padding(3, 4, 3, 4);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(131, 31);
            btnCheckout.TabIndex = 2;
            btnCheckout.Text = "CHECKOUT";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnChoose
            // 
            btnChoose.Location = new Point(155, 16);
            btnChoose.Margin = new Padding(3, 4, 3, 4);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(131, 31);
            btnChoose.TabIndex = 1;
            btnChoose.Text = "Choose Order";
            btnChoose.UseVisualStyleBackColor = true;
            btnChoose.Click += btnChoose_Click;
            // 
            // lstOrders
            // 
            lstOrders.FormattingEnabled = true;
            lstOrders.Location = new Point(26, 101);
            lstOrders.Margin = new Padding(3, 4, 3, 4);
            lstOrders.Name = "lstOrders";
            lstOrders.Size = new Size(260, 164);
            lstOrders.TabIndex = 0;
            // 
            // panelCustomerInfo
            // 
            panelCustomerInfo.Controls.Add(cmbOrderType);
            panelCustomerInfo.Controls.Add(cmbPayment);
            panelCustomerInfo.Controls.Add(txtCustomer);
            panelCustomerInfo.Controls.Add(lblOrderType);
            panelCustomerInfo.Controls.Add(lblPayment);
            panelCustomerInfo.Controls.Add(lblCustomer);
            panelCustomerInfo.Location = new Point(442, 156);
            panelCustomerInfo.Margin = new Padding(3, 4, 3, 4);
            panelCustomerInfo.Name = "panelCustomerInfo";
            panelCustomerInfo.Size = new Size(337, 360);
            panelCustomerInfo.TabIndex = 4;
            // 
            // cmbOrderType
            // 
            cmbOrderType.FormattingEnabled = true;
            cmbOrderType.Location = new Point(130, 173);
            cmbOrderType.Margin = new Padding(3, 4, 3, 4);
            cmbOrderType.Name = "cmbOrderType";
            cmbOrderType.Size = new Size(173, 28);
            cmbOrderType.TabIndex = 5;
            // 
            // cmbPayment
            // 
            cmbPayment.FormattingEnabled = true;
            cmbPayment.Location = new Point(130, 111);
            cmbPayment.Margin = new Padding(3, 4, 3, 4);
            cmbPayment.Name = "cmbPayment";
            cmbPayment.Size = new Size(173, 28);
            cmbPayment.TabIndex = 4;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(130, 61);
            txtCustomer.Margin = new Padding(3, 4, 3, 4);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(173, 27);
            txtCustomer.TabIndex = 3;
            // 
            // lblOrderType
            // 
            lblOrderType.AutoSize = true;
            lblOrderType.Location = new Point(13, 173);
            lblOrderType.Name = "lblOrderType";
            lblOrderType.Size = new Size(85, 20);
            lblOrderType.TabIndex = 2;
            lblOrderType.Text = "Order Type:";
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Location = new Point(13, 121);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(68, 20);
            lblPayment.TabIndex = 1;
            lblPayment.Text = "Payment:";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(13, 65);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(119, 20);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "Customer Name:";
            // 
            // pnlPOS
            // 
            pnlPOS.AutoSize = true;
            pnlPOS.Controls.Add(panelCustomerInfo);
            pnlPOS.Controls.Add(panelOrder);
            pnlPOS.Controls.Add(lblSession);
            pnlPOS.Controls.Add(btnEndSession);
            pnlPOS.Dock = DockStyle.Fill;
            pnlPOS.Location = new Point(0, 0);
            pnlPOS.Margin = new Padding(3, 4, 3, 4);
            pnlPOS.Name = "pnlPOS";
            pnlPOS.Size = new Size(1669, 974);
            pnlPOS.TabIndex = 8;
            // 
            // pnlStartSession
            // 
            pnlStartSession.AutoSize = true;
            pnlStartSession.BackColor = Color.Transparent;
            pnlStartSession.Controls.Add(cuiPanel1);
            pnlStartSession.Dock = DockStyle.Fill;
            pnlStartSession.ForeColor = Color.LemonChiffon;
            pnlStartSession.Location = new Point(0, 0);
            pnlStartSession.Name = "pnlStartSession";
            pnlStartSession.OutlineThickness = 1F;
            pnlStartSession.PanelColor = Color.FromArgb(45, 83, 26);
            pnlStartSession.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            pnlStartSession.RightToLeft = RightToLeft.No;
            pnlStartSession.Rounding = new Padding(20);
            pnlStartSession.Size = new Size(1669, 974);
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
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.Padding = new Padding(0, 0, 10, 10);
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel1.Rounding = new Padding(20);
            cuiPanel1.Size = new Size(1655, 964);
            cuiPanel1.TabIndex = 6;
            // 
            // lblStartHint
            // 
            lblStartHint.Content = "No\\ Active\\ Session";
            lblStartHint.Font = new Font("Verdana", 16.2F, FontStyle.Bold);
            lblStartHint.ForeColor = Color.DarkOliveGreen;
            lblStartHint.HorizontalAlignment = StringAlignment.Center;
            lblStartHint.Location = new Point(603, 329);
            lblStartHint.Margin = new Padding(4, 5, 4, 5);
            lblStartHint.Name = "lblStartHint";
            lblStartHint.Size = new Size(350, 60);
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
            btnStartSession.Location = new Point(704, 461);
            btnStartSession.Name = "btnStartSession";
            btnStartSession.NormalBackground = Color.FromArgb(53, 108, 27);
            btnStartSession.NormalForeColor = Color.LemonChiffon;
            btnStartSession.NormalImageTint = Color.Black;
            btnStartSession.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnStartSession.OutlineThickness = 1F;
            btnStartSession.Padding = new Padding(12);
            btnStartSession.PressedBackground = Color.WhiteSmoke;
            btnStartSession.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnStartSession.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnStartSession.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnStartSession.Rounding = new Padding(15);
            btnStartSession.Size = new Size(148, 41);
            btnStartSession.TabIndex = 5;
            btnStartSession.TextAlignment = StringAlignment.Center;
            btnStartSession.TextPadding = 12;
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
            txtSessionName.Location = new Point(580, 384);
            txtSessionName.Margin = new Padding(4);
            txtSessionName.Multiline = false;
            txtSessionName.Name = "txtSessionName";
            txtSessionName.NormalImageTint = Color.White;
            txtSessionName.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtSessionName.Padding = new Padding(20, 15, 20, 0);
            txtSessionName.PasswordChar = false;
            txtSessionName.PlaceholderColor = Color.LightGray;
            txtSessionName.PlaceholderText = "Placeholder text..";
            txtSessionName.Rounding = new Padding(15);
            txtSessionName.Size = new Size(397, 51);
            txtSessionName.TabIndex = 4;
            txtSessionName.TextOffset = new Size(0, 0);
            txtSessionName.UnderlinedStyle = true;
            // 
            // POSControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 83, 26);
            Controls.Add(pnlStartSession);
            Controls.Add(pnlPOS);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "POSControl";
            Size = new Size(1669, 974);
            panelOrder.ResumeLayout(false);
            panelOrder.PerformLayout();
            panelCustomerInfo.ResumeLayout(false);
            panelCustomerInfo.PerformLayout();
            pnlPOS.ResumeLayout(false);
            pnlPOS.PerformLayout();
            pnlStartSession.ResumeLayout(false);
            cuiPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEndSession;
        private Label lblSession;
        private Panel panelOrder;
        private Label lblRunningTotal;
        private Button btnRemove;
        private Button btnCheckout;
        private Button btnChoose;
        private ListBox lstOrders;
        private Panel panelCustomerInfo;
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
    }
}
