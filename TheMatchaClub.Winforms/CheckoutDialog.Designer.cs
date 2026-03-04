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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lstSummary = new ListBox();
            lblTotal = new Label();
            lblCash = new Label();
            txtCash = new TextBox();
            gtxtCash = new Guna.UI2.WinForms.Guna2TextBox();
            gtxtTotalCash = new Guna.UI2.WinForms.Guna2TextBox();
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
            // gtxtCash
            // 
            gtxtCash.BorderRadius = 10;
            gtxtCash.CustomizableEdges = customizableEdges9;
            gtxtCash.DefaultText = "";
            gtxtCash.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            gtxtCash.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            gtxtCash.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            gtxtCash.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            gtxtCash.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gtxtCash.Font = new Font("Segoe UI", 9F);
            gtxtCash.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            gtxtCash.Location = new Point(239, 324);
            gtxtCash.Name = "gtxtCash";
            gtxtCash.PlaceholderText = "";
            gtxtCash.SelectedText = "";
            gtxtCash.ShadowDecoration.CustomizableEdges = customizableEdges10;
            gtxtCash.Size = new Size(139, 23);
            gtxtCash.TabIndex = 6;
            // 
            // gtxtTotalCash
            // 
            gtxtTotalCash.BorderRadius = 10;
            gtxtTotalCash.CustomizableEdges = customizableEdges11;
            gtxtTotalCash.DefaultText = "";
            gtxtTotalCash.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            gtxtTotalCash.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            gtxtTotalCash.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            gtxtTotalCash.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            gtxtTotalCash.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gtxtTotalCash.Font = new Font("Segoe UI", 9F);
            gtxtTotalCash.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            gtxtTotalCash.Location = new Point(133, 278);
            gtxtTotalCash.Name = "gtxtTotalCash";
            gtxtTotalCash.PlaceholderText = "";
            gtxtTotalCash.SelectedText = "";
            gtxtTotalCash.ShadowDecoration.CustomizableEdges = customizableEdges12;
            gtxtTotalCash.Size = new Size(139, 23);
            gtxtTotalCash.TabIndex = 7;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderRadius = 15;
            guna2Button1.CustomizableEdges = customizableEdges13;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(225, 244, 206);
            guna2Button1.Font = new Font("Segoe UI", 10F);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Location = new Point(33, 374);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2Button1.Size = new Size(75, 33);
            guna2Button1.TabIndex = 8;
            guna2Button1.Text = "Back";
            // 
            // guna2Button2
            // 
            guna2Button2.BackColor = Color.Transparent;
            guna2Button2.BorderRadius = 15;
            guna2Button2.CustomizableEdges = customizableEdges15;
            guna2Button2.DisabledState.BorderColor = Color.DarkGray;
            guna2Button2.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button2.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button2.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button2.FillColor = Color.FromArgb(225, 244, 206);
            guna2Button2.Font = new Font("Segoe UI", 10F);
            guna2Button2.ForeColor = Color.Black;
            guna2Button2.Location = new Point(135, 374);
            guna2Button2.Name = "guna2Button2";
            guna2Button2.ShadowDecoration.CustomizableEdges = customizableEdges16;
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
            Controls.Add(gtxtTotalCash);
            Controls.Add(gtxtCash);
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
        private Guna.UI2.WinForms.Guna2TextBox gtxtCash;
        private Guna.UI2.WinForms.Guna2TextBox gtxtTotalCash;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}