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
            pnlStartSession = new Panel();
            btnStartSession = new Button();
            txtSessionName = new TextBox();
            lblStartHint = new Label();
            panelOrder.SuspendLayout();
            panelCustomerInfo.SuspendLayout();
            pnlPOS.SuspendLayout();
            pnlStartSession.SuspendLayout();
            SuspendLayout();
            // 
            // btnEndSession
            // 
            btnEndSession.Location = new Point(553, 88);
            btnEndSession.Name = "btnEndSession";
            btnEndSession.Size = new Size(116, 23);
            btnEndSession.TabIndex = 7;
            btnEndSession.Text = "End Session";
            btnEndSession.UseVisualStyleBackColor = true;
            btnEndSession.Click += btnEndSession_Click;
            // 
            // lblSession
            // 
            lblSession.AutoSize = true;
            lblSession.Location = new Point(501, 68);
            lblSession.Name = "lblSession";
            lblSession.Size = new Size(49, 15);
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
            panelOrder.Location = new Point(80, 117);
            panelOrder.Name = "panelOrder";
            panelOrder.Size = new Size(281, 270);
            panelOrder.TabIndex = 5;
            // 
            // lblRunningTotal
            // 
            lblRunningTotal.AutoSize = true;
            lblRunningTotal.Location = new Point(91, 206);
            lblRunningTotal.Name = "lblRunningTotal";
            lblRunningTotal.Size = new Size(67, 15);
            lblRunningTotal.TabIndex = 4;
            lblRunningTotal.Text = "Total: ₱0.00";
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(136, 41);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(115, 23);
            btnRemove.TabIndex = 3;
            btnRemove.Text = "Remove Selected";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(85, 235);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(115, 23);
            btnCheckout.TabIndex = 2;
            btnCheckout.Text = "CHECKOUT";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnChoose
            // 
            btnChoose.Location = new Point(136, 12);
            btnChoose.Name = "btnChoose";
            btnChoose.Size = new Size(115, 23);
            btnChoose.TabIndex = 1;
            btnChoose.Text = "Choose Order";
            btnChoose.UseVisualStyleBackColor = true;
            btnChoose.Click += btnChoose_Click;
            // 
            // lstOrders
            // 
            lstOrders.FormattingEnabled = true;
            lstOrders.ItemHeight = 15;
            lstOrders.Location = new Point(23, 76);
            lstOrders.Name = "lstOrders";
            lstOrders.Size = new Size(228, 124);
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
            panelCustomerInfo.Location = new Point(387, 117);
            panelCustomerInfo.Name = "panelCustomerInfo";
            panelCustomerInfo.Size = new Size(295, 270);
            panelCustomerInfo.TabIndex = 4;
            // 
            // cmbOrderType
            // 
            cmbOrderType.FormattingEnabled = true;
            cmbOrderType.Location = new Point(114, 130);
            cmbOrderType.Name = "cmbOrderType";
            cmbOrderType.Size = new Size(152, 23);
            cmbOrderType.TabIndex = 5;
            // 
            // cmbPayment
            // 
            cmbPayment.FormattingEnabled = true;
            cmbPayment.Location = new Point(114, 83);
            cmbPayment.Name = "cmbPayment";
            cmbPayment.Size = new Size(152, 23);
            cmbPayment.TabIndex = 4;
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(114, 46);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(152, 23);
            txtCustomer.TabIndex = 3;
            // 
            // lblOrderType
            // 
            lblOrderType.AutoSize = true;
            lblOrderType.Location = new Point(11, 130);
            lblOrderType.Name = "lblOrderType";
            lblOrderType.Size = new Size(68, 15);
            lblOrderType.TabIndex = 2;
            lblOrderType.Text = "Order Type:";
            // 
            // lblPayment
            // 
            lblPayment.AutoSize = true;
            lblPayment.Location = new Point(11, 91);
            lblPayment.Name = "lblPayment";
            lblPayment.Size = new Size(57, 15);
            lblPayment.TabIndex = 1;
            lblPayment.Text = "Payment:";
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Location = new Point(11, 49);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(97, 15);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "Customer Name:";
            // 
            // pnlPOS
            // 
            pnlPOS.Controls.Add(panelCustomerInfo);
            pnlPOS.Controls.Add(panelOrder);
            pnlPOS.Controls.Add(lblSession);
            pnlPOS.Controls.Add(btnEndSession);
            pnlPOS.Dock = DockStyle.Fill;
            pnlPOS.Location = new Point(0, 0);
            pnlPOS.Name = "pnlPOS";
            pnlPOS.Size = new Size(1259, 701);
            pnlPOS.TabIndex = 8;
            // 
            // pnlStartSession
            // 
            pnlStartSession.BackColor = Color.Gray;
            pnlStartSession.Controls.Add(btnStartSession);
            pnlStartSession.Controls.Add(txtSessionName);
            pnlStartSession.Controls.Add(lblStartHint);
            pnlStartSession.Dock = DockStyle.Fill;
            pnlStartSession.Location = new Point(0, 0);
            pnlStartSession.Name = "pnlStartSession";
            pnlStartSession.Size = new Size(1259, 701);
            pnlStartSession.TabIndex = 8;
            // 
            // btnStartSession
            // 
            btnStartSession.Location = new Point(578, 306);
            btnStartSession.Name = "btnStartSession";
            btnStartSession.Size = new Size(75, 23);
            btnStartSession.TabIndex = 2;
            btnStartSession.Text = "Start Day";
            btnStartSession.UseVisualStyleBackColor = true;
            btnStartSession.Click += btnStartSession_Click;
            // 
            // txtSessionName
            // 
            txtSessionName.Location = new Point(517, 267);
            txtSessionName.Name = "txtSessionName";
            txtSessionName.Size = new Size(197, 23);
            txtSessionName.TabIndex = 1;
            // 
            // lblStartHint
            // 
            lblStartHint.AutoSize = true;
            lblStartHint.Location = new Point(565, 229);
            lblStartHint.Name = "lblStartHint";
            lblStartHint.Size = new Size(101, 15);
            lblStartHint.TabIndex = 0;
            lblStartHint.Text = "No  active session";
            // 
            // POSControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlStartSession);
            Controls.Add(pnlPOS);
            Name = "POSControl";
            Size = new Size(1259, 701);
            panelOrder.ResumeLayout(false);
            panelOrder.PerformLayout();
            panelCustomerInfo.ResumeLayout(false);
            panelCustomerInfo.PerformLayout();
            pnlPOS.ResumeLayout(false);
            pnlPOS.PerformLayout();
            pnlStartSession.ResumeLayout(false);
            pnlStartSession.PerformLayout();
            ResumeLayout(false);
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
        private Panel pnlStartSession;
        private Button btnStartSession;
        private TextBox txtSessionName;
        private Label lblStartHint;
    }
}
