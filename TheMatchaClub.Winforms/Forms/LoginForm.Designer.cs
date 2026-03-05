namespace TheMatchaClub.Winforms
{
    partial class LoginForm
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
            lblPassword = new Label();
            txtPassword = new CuoreUI.Controls.cuiTextBox();
            btnLogin = new CuoreUI.Controls.cuiButton();
            btnExit = new CuoreUI.Controls.cuiButton();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(43, 137);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(69, 17);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Transparent;
            txtPassword.BackgroundColor = Color.FromArgb(53, 108, 27);
            txtPassword.Content = "";
            txtPassword.FocusBackgroundColor = Color.FromArgb(53, 108, 27);
            txtPassword.FocusImageTint = Color.White;
            txtPassword.FocusOutlineColor = Color.DarkOliveGreen;
            txtPassword.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.LemonChiffon;
            txtPassword.Image = null;
            txtPassword.ImageExpand = new Point(0, 0);
            txtPassword.ImageOffset = new Point(0, 0);
            txtPassword.Location = new Point(45, 166);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.NormalImageTint = Color.White;
            txtPassword.OutlineColor = Color.LemonChiffon;
            txtPassword.Padding = new Padding(16, 6, 16, 0);
            txtPassword.PasswordChar = false;
            txtPassword.PlaceholderColor = Color.LemonChiffon;
            txtPassword.PlaceholderText = "Enter Password";
            txtPassword.Rounding = new Padding(15);
            txtPassword.Size = new Size(282, 29);
            txtPassword.TabIndex = 4;
            txtPassword.TextOffset = new Size(0, 0);
            txtPassword.UnderlinedStyle = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.CheckButton = false;
            btnLogin.Checked = false;
            btnLogin.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnLogin.CheckedForeColor = Color.White;
            btnLogin.CheckedImageTint = Color.White;
            btnLogin.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnLogin.Content = "Login";
            btnLogin.DialogResult = DialogResult.None;
            btnLogin.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnLogin.ForeColor = Color.Black;
            btnLogin.HoverBackground = Color.FromArgb(169, 209, 129);
            btnLogin.HoverForeColor = Color.White;
            btnLogin.HoverImageTint = Color.DimGray;
            btnLogin.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnLogin.Image = null;
            btnLogin.ImageExpand = new Point(0, 0);
            btnLogin.Location = new Point(42, 237);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.NormalBackground = Color.White;
            btnLogin.NormalForeColor = Color.Black;
            btnLogin.NormalImageTint = Color.Black;
            btnLogin.NormalOutline = Color.DarkOliveGreen;
            btnLogin.OutlineThickness = 1F;
            btnLogin.PressedBackground = Color.FromArgb(53, 108, 27);
            btnLogin.PressedForeColor = Color.FromArgb(169, 209, 129);
            btnLogin.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnLogin.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnLogin.Rounding = new Padding(15);
            btnLogin.Size = new Size(282, 28);
            btnLogin.TabIndex = 2;
            btnLogin.TextAlignment = StringAlignment.Center;
            btnLogin.TextPadding = -1;
            btnLogin.TextSpacing = 2;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.CheckButton = false;
            btnExit.Checked = false;
            btnExit.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnExit.CheckedForeColor = Color.White;
            btnExit.CheckedImageTint = Color.White;
            btnExit.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnExit.Content = "Exit";
            btnExit.DialogResult = DialogResult.None;
            btnExit.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnExit.ForeColor = Color.Black;
            btnExit.HoverBackground = Color.Red;
            btnExit.HoverForeColor = Color.White;
            btnExit.HoverImageTint = Color.DimGray;
            btnExit.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnExit.Image = null;
            btnExit.ImageExpand = new Point(0, 0);
            btnExit.Location = new Point(42, 284);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.NormalBackground = Color.White;
            btnExit.NormalForeColor = Color.Black;
            btnExit.NormalImageTint = Color.Black;
            btnExit.NormalOutline = Color.DarkOliveGreen;
            btnExit.OutlineThickness = 1F;
            btnExit.PressedBackground = Color.FromArgb(53, 108, 27);
            btnExit.PressedForeColor = Color.FromArgb(169, 209, 129);
            btnExit.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnExit.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnExit.Rounding = new Padding(15);
            btnExit.Size = new Size(282, 28);
            btnExit.TabIndex = 3;
            btnExit.TextAlignment = StringAlignment.Center;
            btnExit.TextPadding = -1;
            btnExit.TextSpacing = 2;
            btnExit.Click += btnExit_Click;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Welcome\\ To\\ ";
            cuiLabel1.Font = new Font("Verdana", 16.2F, FontStyle.Bold);
            cuiLabel1.ForeColor = Color.DarkOliveGreen;
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(42, 40);
            cuiLabel1.Margin = new Padding(4);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(296, 29);
            cuiLabel1.TabIndex = 5;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            cuiLabel1.Load += cuiLabel1_Load;
            // 
            // cuiLabel2
            // 
            cuiLabel2.BackColor = Color.Transparent;
            cuiLabel2.Content = "The\\ Matcha\\ Club!";
            cuiLabel2.Font = new Font("Verdana", 16.2F, FontStyle.Bold);
            cuiLabel2.ForeColor = Color.DarkOliveGreen;
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(38, 70);
            cuiLabel2.Margin = new Padding(4);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(296, 29);
            cuiLabel2.TabIndex = 6;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiPanel1
            // 
            cuiPanel1.BackColor = Color.Transparent;
            cuiPanel1.Controls.Add(cuiLabel1);
            cuiPanel1.Controls.Add(btnExit);
            cuiPanel1.Controls.Add(cuiLabel2);
            cuiPanel1.Controls.Add(btnLogin);
            cuiPanel1.Controls.Add(lblPassword);
            cuiPanel1.Controls.Add(txtPassword);
            cuiPanel1.Location = new Point(737, 45);
            cuiPanel1.Margin = new Padding(3, 2, 3, 2);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 2F;
            cuiPanel1.PanelColor = Color.FromArgb(245, 245, 221);
            cuiPanel1.PanelOutlineColor = Color.Black;
            cuiPanel1.Rounding = new Padding(20);
            cuiPanel1.Size = new Size(365, 367);
            cuiPanel1.TabIndex = 7;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Desktop___37;
            ClientSize = new Size(1164, 506);
            Controls.Add(cuiPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblPassword;
        private CuoreUI.Controls.cuiTextBox txtPassword;
        private CuoreUI.Controls.cuiButton btnLogin;
        private CuoreUI.Controls.cuiButton btnExit;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
    }
}