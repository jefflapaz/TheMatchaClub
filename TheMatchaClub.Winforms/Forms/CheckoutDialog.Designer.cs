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
            lstSummary = new ListBox();
            lblTotal = new Label();
            lblCash = new Label();
            gtxtCash = new Guna.UI2.WinForms.Guna2TextBox();
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
            lstSummary.Size = new Size(400, 229);
            lstSummary.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(59, 286);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(48, 20);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total:";
            // 
            // lblCash
            // 
            lblCash.AutoSize = true;
            lblCash.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblCash.ForeColor = Color.White;
            lblCash.Location = new Point(59, 324);
            lblCash.Name = "lblCash";
            lblCash.Size = new Size(46, 20);
            lblCash.TabIndex = 2;
            lblCash.Text = "Cash:";
            // 
            // gtxtCash
            // 
            gtxtCash.BorderRadius = 10;
            gtxtCash.CustomizableEdges = customizableEdges1;
            gtxtCash.DefaultText = "";
            gtxtCash.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            gtxtCash.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            gtxtCash.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            gtxtCash.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            gtxtCash.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gtxtCash.Font = new Font("Segoe UI", 9F);
            gtxtCash.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            gtxtCash.Location = new Point(133, 324);
            gtxtCash.Name = "gtxtCash";
            gtxtCash.PlaceholderText = "";
            gtxtCash.SelectedText = "";
            gtxtCash.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gtxtCash.Size = new Size(139, 23);
            gtxtCash.TabIndex = 6;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderRadius = 10;
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(225, 244, 206);
            guna2Button1.Font = new Font("Segoe UI", 10F);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(44, 374);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(75, 23);
            guna2Button1.TabIndex = 8;
            guna2Button1.Text = "Back";
            guna2Button1.Click += btnBack_Click;
            // 
            // guna2Button2
            // 
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BorderRadius = 10;
            guna2Button2.CustomizableEdges = customizableEdges5;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.FromArgb(225, 244, 206);
            guna2Button2.Font = new Font("Segoe UI", 10F);
            guna2Button2.ForeColor = Color.Black;
            guna2Button2.Location = new Point(131, 374);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Button2.Size = new Size(137, 23);
            guna2Button2.TabIndex = 9;
            guna2Button2.Text = "Confirm and Save";
            guna2Button2.Click += btnConfirm_Click;
            // 
            // CheckoutDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 108, 27);
            ClientSize = new Size(465, 450);
            Controls.Add(guna2Button2);
            Controls.Add(guna2Button1);
            Controls.Add(gtxtCash);
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
        private Guna.UI2.WinForms.Guna2TextBox gtxtCash;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}