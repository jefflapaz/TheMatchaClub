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
            btnShowPassword = new CuoreUI.Controls.cuiButton();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.ForeColor = Color.FromArgb(235, 250, 221);
            lblPassword.Location = new Point(61, 150);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Transparent;
            txtPassword.BackgroundColor = Color.FromArgb(235, 250, 221);
            txtPassword.Content = "";
            txtPassword.FocusBackgroundColor = Color.FromArgb(235, 250, 221);
            txtPassword.FocusImageTint = Color.White;
            txtPassword.FocusOutlineColor = Color.DarkOliveGreen;
            txtPassword.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(17, 47, 21);
            txtPassword.Image = null;
            txtPassword.ImageExpand = new Point(0, 0);
            txtPassword.ImageOffset = new Point(0, 0);
            txtPassword.Location = new Point(56, 182);
            txtPassword.Margin = new Padding(4);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.NormalImageTint = Color.White;
            txtPassword.OutlineColor = Color.LemonChiffon;
            txtPassword.Padding = new Padding(20, 9, 20, 0);
            txtPassword.PasswordChar = false;
            txtPassword.PlaceholderColor = Color.FromArgb(17, 47, 21);
            txtPassword.PlaceholderText = "Password";
            txtPassword.Rounding = new Padding(15);
            txtPassword.Size = new Size(322, 39);
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
            btnLogin.ForeColor = Color.FromArgb(235, 250, 221);
            btnLogin.HoverBackground = Color.FromArgb(169, 209, 129);
            btnLogin.HoverForeColor = Color.FromArgb(53, 108, 27);
            btnLogin.HoverImageTint = Color.DimGray;
            btnLogin.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnLogin.Image = null;
            btnLogin.ImageExpand = new Point(0, 0);
            btnLogin.Location = new Point(56, 331);
            btnLogin.Name = "btnLogin";
            btnLogin.NormalBackground = Color.Transparent;
            btnLogin.NormalForeColor = Color.FromArgb(235, 250, 221);
            btnLogin.NormalImageTint = Color.Black;
            btnLogin.NormalOutline = Color.FromArgb(235, 250, 221);
            btnLogin.OutlineThickness = 1F;
            btnLogin.Padding = new Padding(12);
            btnLogin.PressedBackground = Color.FromArgb(53, 108, 27);
            btnLogin.PressedForeColor = Color.FromArgb(169, 209, 129);
            btnLogin.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnLogin.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnLogin.Rounding = new Padding(20);
            btnLogin.Size = new Size(322, 37);
            btnLogin.TabIndex = 2;
            btnLogin.TextAlignment = StringAlignment.Center;
            btnLogin.TextPadding = 12;
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
            btnExit.ForeColor = Color.FromArgb(235, 250, 221);
            btnExit.HoverBackground = Color.FromArgb(169, 209, 129);
            btnExit.HoverForeColor = Color.FromArgb(53, 108, 27);
            btnExit.HoverImageTint = Color.DimGray;
            btnExit.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnExit.Image = null;
            btnExit.ImageExpand = new Point(0, 0);
            btnExit.Location = new Point(56, 412);
            btnExit.Name = "btnExit";
            btnExit.NormalBackground = Color.Transparent;
            btnExit.NormalForeColor = Color.FromArgb(235, 250, 221);
            btnExit.NormalImageTint = Color.Black;
            btnExit.NormalOutline = Color.FromArgb(235, 250, 221);
            btnExit.OutlineThickness = 1F;
            btnExit.Padding = new Padding(12);
            btnExit.PressedBackground = Color.FromArgb(53, 108, 27);
            btnExit.PressedForeColor = Color.FromArgb(169, 209, 129);
            btnExit.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnExit.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnExit.Rounding = new Padding(20);
            btnExit.Size = new Size(322, 37);
            btnExit.TabIndex = 3;
            btnExit.TextAlignment = StringAlignment.Center;
            btnExit.TextPadding = 12;
            btnExit.TextSpacing = 2;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Welcome\\ To\\ ";
            cuiLabel1.Font = new Font("Verdana", 17F, FontStyle.Bold);
            cuiLabel1.ForeColor = Color.FromArgb(235, 250, 221);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(48, 22);
            cuiLabel1.Margin = new Padding(4, 5, 4, 5);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(338, 39);
            cuiLabel1.TabIndex = 5;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            cuiLabel1.Load += cuiLabel1_Load;
            // 
            // cuiLabel2
            // 
            cuiLabel2.BackColor = Color.Transparent;
            cuiLabel2.Content = "The\\ Matcha\\ Club!";
            cuiLabel2.Font = new Font("Verdana", 17F, FontStyle.Bold);
            cuiLabel2.ForeColor = Color.FromArgb(235, 250, 221);
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(48, 61);
            cuiLabel2.Margin = new Padding(4, 5, 4, 5);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(338, 39);
            cuiLabel2.TabIndex = 6;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiPanel1
            // 
            cuiPanel1.BackColor = Color.Transparent;
            cuiPanel1.Controls.Add(btnShowPassword);
            cuiPanel1.Controls.Add(cuiLabel1);
            cuiPanel1.Controls.Add(btnExit);
            cuiPanel1.Controls.Add(cuiLabel2);
            cuiPanel1.Controls.Add(btnLogin);
            cuiPanel1.Controls.Add(lblPassword);
            cuiPanel1.Controls.Add(txtPassword);
            cuiPanel1.Location = new Point(865, 64);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 0F;
            cuiPanel1.PanelColor = Color.Transparent;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(235, 250, 221);
            cuiPanel1.Rounding = new Padding(25);
            cuiPanel1.Size = new Size(436, 529);
            cuiPanel1.TabIndex = 7;
            // 
            // btnShowPassword
            // 
            btnShowPassword.BackColor = Color.Transparent;
            btnShowPassword.BackgroundImageLayout = ImageLayout.None;
            btnShowPassword.CheckButton = false;
            btnShowPassword.Checked = false;
            btnShowPassword.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnShowPassword.CheckedForeColor = Color.Transparent;
            btnShowPassword.CheckedImageTint = Color.Transparent;
            btnShowPassword.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnShowPassword.Content = "";
            btnShowPassword.DialogResult = DialogResult.None;
            btnShowPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowPassword.ForeColor = Color.Transparent;
            btnShowPassword.HoverBackground = Color.White;
            btnShowPassword.HoverForeColor = Color.DimGray;
            btnShowPassword.HoverImageTint = Color.DimGray;
            btnShowPassword.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnShowPassword.Image = Properties.Resources.eyes_open;
            btnShowPassword.ImageExpand = new Point(0, 0);
            btnShowPassword.Location = new Point(380, 181);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.NormalBackground = Color.Transparent;
            btnShowPassword.NormalForeColor = Color.Transparent;
            btnShowPassword.NormalImageTint = Color.FromArgb(235, 250, 221);
            btnShowPassword.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnShowPassword.OutlineThickness = 1F;
            btnShowPassword.Padding = new Padding(12);
            btnShowPassword.PressedBackground = Color.WhiteSmoke;
            btnShowPassword.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnShowPassword.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnShowPassword.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnShowPassword.Rounding = new Padding(20);
            btnShowPassword.Size = new Size(39, 36);
            btnShowPassword.TabIndex = 15;
            btnShowPassword.TextAlignment = StringAlignment.Center;
            btnShowPassword.TextPadding = 12;
            btnShowPassword.TextSpacing = 2;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 250, 221);
            BackgroundImage = Properties.Resources.Desktop___41__4_;
            ClientSize = new Size(1351, 721);
            Controls.Add(cuiPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
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
        private CuoreUI.Controls.cuiButton btnShowPassword;
    }
}