namespace TheMatchaClub.Winforms
{
    partial class CheckoutDialog
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
            lstSummary = new ListBox();
            lblTotal = new Label();
            lblCash = new Label();
            txtCash = new TextBox();
            btnConfirm = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lstSummary
            // 
            lstSummary.BackColor = Color.FromArgb(245, 245, 221);
            lstSummary.FormattingEnabled = true;
            lstSummary.ItemHeight = 15;
            lstSummary.Location = new Point(33, 34);
            lstSummary.Name = "lstSummary";
            lstSummary.Size = new Size(386, 229);
            lstSummary.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(59, 286);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 15);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total:";
            // 
            // lblCash
            // 
            lblCash.AutoSize = true;
            lblCash.Location = new Point(59, 324);
            lblCash.Name = "lblCash";
            lblCash.Size = new Size(36, 15);
            lblCash.TabIndex = 2;
            lblCash.Text = "Cash:";
            // 
            // txtCash
            // 
            txtCash.Location = new Point(133, 324);
            txtCash.Name = "txtCash";
            txtCash.Size = new Size(100, 23);
            txtCash.TabIndex = 3;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(133, 387);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(129, 23);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Confirm and  Save";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(33, 387);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 5;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // CheckoutDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 108, 27);
            ClientSize = new Size(465, 450);
            Controls.Add(btnBack);
            Controls.Add(btnConfirm);
            Controls.Add(txtCash);
            Controls.Add(lblCash);
            Controls.Add(lblTotal);
            Controls.Add(lstSummary);
            Name = "CheckoutDialog";
            Text = "CheckoutDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstSummary;
        private Label lblTotal;
        private Label lblCash;
        private TextBox txtCash;
        private Button btnConfirm;
        private Button btnBack;
    }
}