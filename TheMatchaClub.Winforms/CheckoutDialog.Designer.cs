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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lstSummary = new ListBox();
            lblTotal = new Label();
            lblCash = new Label();
            txtCash = new TextBox();
            btnConfirm = new Button();
            btnBack = new Button();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
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
            // guna2TextBox1
            // 
            guna2TextBox1.BorderRadius = 10;
            guna2TextBox1.CustomizableEdges = customizableEdges1;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(239, 324);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2TextBox1.Size = new Size(139, 23);
            guna2TextBox1.TabIndex = 6;
            // 
            // guna2TextBox2
            // 
            guna2TextBox2.BorderRadius = 10;
            guna2TextBox2.CustomizableEdges = customizableEdges3;
            guna2TextBox2.DefaultText = "";
            guna2TextBox2.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox2.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox2.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox2.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Font = new Font("Segoe UI", 9F);
            guna2TextBox2.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox2.Location = new Point(133, 278);
            guna2TextBox2.Name = "guna2TextBox2";
            guna2TextBox2.PlaceholderText = "";
            guna2TextBox2.SelectedText = "";
            guna2TextBox2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TextBox2.Size = new Size(139, 23);
            guna2TextBox2.TabIndex = 7;
            // 
            // CheckoutDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 108, 27);
            ClientSize = new Size(465, 450);
            Controls.Add(guna2TextBox2);
            Controls.Add(guna2TextBox1);
            Controls.Add(btnBack);
            Controls.Add(btnConfirm);
            Controls.Add(txtCash);
            Controls.Add(lblCash);
            Controls.Add(lblTotal);
            Controls.Add(lstSummary);
            Name = "CheckoutDialog";
            Text = "CheckoutDialog";
            Load += CheckoutDialog_Load_1;
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
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
    }
}