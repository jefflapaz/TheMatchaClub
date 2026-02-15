namespace TheMatchaClub.Winforms
{
    partial class POSForm
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
            panelCustomerInfo = new Panel();
            cmbOrderType = new ComboBox();
            cmbPayment = new ComboBox();
            txtCustomer = new TextBox();
            lblOrderType = new Label();
            lblPayment = new Label();
            lblCustomer = new Label();
            panel1 = new Panel();
            btnRemove = new Button();
            btnCheckout = new Button();
            btnChoose = new Button();
            lstOrders = new ListBox();
            lblRunningTotal = new Label();
            panelCustomerInfo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelCustomerInfo
            // 
            panelCustomerInfo.Controls.Add(cmbOrderType);
            panelCustomerInfo.Controls.Add(cmbPayment);
            panelCustomerInfo.Controls.Add(txtCustomer);
            panelCustomerInfo.Controls.Add(lblOrderType);
            panelCustomerInfo.Controls.Add(lblPayment);
            panelCustomerInfo.Controls.Add(lblCustomer);
            panelCustomerInfo.Location = new Point(41, 130);
            panelCustomerInfo.Name = "panelCustomerInfo";
            panelCustomerInfo.Size = new Size(295, 270);
            panelCustomerInfo.TabIndex = 0;
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
            // panel1
            // 
            panel1.Controls.Add(lblRunningTotal);
            panel1.Controls.Add(btnRemove);
            panel1.Controls.Add(btnCheckout);
            panel1.Controls.Add(btnChoose);
            panel1.Controls.Add(lstOrders);
            panel1.Location = new Point(440, 130);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 270);
            panel1.TabIndex = 1;
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
            // lblRunningTotal
            // 
            lblRunningTotal.AutoSize = true;
            lblRunningTotal.Location = new Point(91, 206);
            lblRunningTotal.Name = "lblRunningTotal";
            lblRunningTotal.Size = new Size(67, 15);
            lblRunningTotal.TabIndex = 4;
            lblRunningTotal.Text = "Total: ₱0.00";
            // 
            // POSForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panelCustomerInfo);
            Name = "POSForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "POSForm";
            panelCustomerInfo.ResumeLayout(false);
            panelCustomerInfo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelCustomerInfo;
        private Label lblOrderType;
        private Label lblPayment;
        private Label lblCustomer;
        private ComboBox cmbOrderType;
        private ComboBox cmbPayment;
        private TextBox txtCustomer;
        private Panel panel1;
        private Button btnCheckout;
        private Button btnChoose;
        private ListBox lstOrders;
        private Button btnRemove;
        private Label lblRunningTotal;
    }
}