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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lstSummary = new ListBox();
            lblTotal = new Label();
            lblCash = new Label();
            txtCash = new TextBox();
            btnConfirm = new Button();
            btnBack = new Button();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
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
            btnConfirm.Location = new Point(133, 363);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(129, 23);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Confirm and  Save";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(33, 363);
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
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderRadius = 15;
            guna2Button1.CustomizableEdges = customizableEdges5;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(225, 244, 206);
            guna2Button1.Font = new Font("Segoe UI", 10F);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(33, 405);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button1.Size = new Size(75, 33);
            guna2Button1.TabIndex = 8;
            guna2Button1.Text = "Back";
            // 
            // guna2Button2
            // 
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BorderRadius = 15;
            guna2Button2.CustomizableEdges = customizableEdges7;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.FromArgb(225, 244, 206);
            guna2Button2.Font = new Font("Segoe UI", 10F);
            guna2Button2.ForeColor = Color.Black;
            guna2Button2.Location = new Point(135, 405);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button2.Size = new Size(137, 33);
            guna2Button2.TabIndex = 9;
            guna2Button2.Text = "Confirm and Save";
            // 
            // CheckoutDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 108, 27);
            ClientSize = new Size(465, 450);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
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
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}