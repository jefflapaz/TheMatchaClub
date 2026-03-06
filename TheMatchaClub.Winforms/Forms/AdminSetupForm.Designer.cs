namespace TheMatchaClub.Winforms
{
    partial class AdminSetupForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPassword = new Label();
            lblConfirm = new Label();
            btnCreate = new CuoreUI.Controls.cuiButton();
            txtUsername = new CuoreUI.Controls.cuiTextBox();
            txtPassword = new CuoreUI.Controls.cuiTextBox();
            txtConfirm = new CuoreUI.Controls.cuiTextBox();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            lblStatus = new Label();
            btnShowConfirm = new CuoreUI.Controls.cuiButton();
            btnShowPassword = new CuoreUI.Controls.cuiButton();
            cuiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.ForeColor = Color.FromArgb(235, 250, 221);
            lblPassword.Location = new Point(42, 100);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password:";
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.BackColor = Color.Transparent;
            lblConfirm.ForeColor = Color.FromArgb(235, 250, 221);
            lblConfirm.Location = new Point(44, 183);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(104, 15);
            lblConfirm.TabIndex = 2;
            lblConfirm.Text = "Confirm Password";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.Transparent;
            btnCreate.CheckButton = false;
            btnCreate.Checked = false;
            btnCreate.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnCreate.CheckedForeColor = Color.White;
            btnCreate.CheckedImageTint = Color.White;
            btnCreate.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnCreate.Content = "Create";
            btnCreate.DialogResult = DialogResult.None;
            btnCreate.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnCreate.ForeColor = Color.FromArgb(235, 250, 221);
            btnCreate.HoverBackground = Color.FromArgb(169, 209, 129);
            btnCreate.HoverForeColor = Color.FromArgb(53, 108, 27);
            btnCreate.HoverImageTint = Color.DimGray;
            btnCreate.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnCreate.Image = null;
            btnCreate.ImageExpand = new Point(0, 0);
            btnCreate.Location = new Point(50, 302);
            btnCreate.Margin = new Padding(3, 2, 3, 2);
            btnCreate.Name = "btnCreate";
            btnCreate.NormalBackground = Color.Transparent;
            btnCreate.NormalForeColor = Color.FromArgb(235, 250, 221);
            btnCreate.NormalImageTint = Color.Black;
            btnCreate.NormalOutline = Color.FromArgb(235, 250, 221);
            btnCreate.OutlineThickness = 1F;
            btnCreate.Padding = new Padding(10, 9, 10, 9);
            btnCreate.PressedBackground = Color.FromArgb(53, 108, 27);
            btnCreate.PressedForeColor = Color.FromArgb(169, 209, 129);
            btnCreate.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnCreate.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnCreate.Rounding = new Padding(20);
            btnCreate.Size = new Size(282, 36);
            btnCreate.TabIndex = 6;
            btnCreate.TextAlignment = StringAlignment.Center;
            btnCreate.TextPadding = -1;
            btnCreate.TextSpacing = 2;
            btnCreate.Click += btnCreate_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackgroundColor = Color.White;
            txtUsername.Content = "";
            txtUsername.FocusBackgroundColor = Color.White;
            txtUsername.FocusImageTint = Color.White;
            txtUsername.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            txtUsername.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.Gray;
            txtUsername.Image = null;
            txtUsername.ImageExpand = new Point(0, 0);
            txtUsername.ImageOffset = new Point(0, 0);
            txtUsername.Location = new Point(0, 0);
            txtUsername.Margin = new Padding(4);
            txtUsername.Multiline = false;
            txtUsername.Name = "txtUsername";
            txtUsername.NormalImageTint = Color.White;
            txtUsername.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            txtUsername.Padding = new Padding(10, 7, 10, 7);
            txtUsername.PasswordChar = false;
            txtUsername.PlaceholderColor = Color.LightGray;
            txtUsername.PlaceholderText = "Placeholder text..";
            txtUsername.Rounding = new Padding(8);
            txtUsername.Size = new Size(266, 45);
            txtUsername.TabIndex = 0;
            txtUsername.TextOffset = new Size(0, 0);
            txtUsername.UnderlinedStyle = true;
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
            txtPassword.Location = new Point(44, 120);
            txtPassword.Margin = new Padding(4, 3, 4, 3);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.NormalImageTint = Color.White;
            txtPassword.OutlineColor = Color.DimGray;
            txtPassword.Padding = new Padding(16, 6, 16, 0);
            txtPassword.PasswordChar = false;
            txtPassword.PlaceholderColor = Color.FromArgb(17, 47, 21);
            txtPassword.PlaceholderText = "Password";
            txtPassword.Rounding = new Padding(15);
            txtPassword.Size = new Size(282, 29);
            txtPassword.TabIndex = 8;
            txtPassword.Tag = "*";
            txtPassword.TextOffset = new Size(0, 0);
            txtPassword.UnderlinedStyle = true;
            txtPassword.ContentChanged += TxtPassword_ContentChanged;
            // 
            // txtConfirm
            // 
            txtConfirm.BackColor = Color.Transparent;
            txtConfirm.BackgroundColor = Color.FromArgb(235, 250, 221);
            txtConfirm.Content = "";
            txtConfirm.FocusBackgroundColor = Color.FromArgb(235, 250, 221);
            txtConfirm.FocusImageTint = Color.White;
            txtConfirm.FocusOutlineColor = Color.DarkOliveGreen;
            txtConfirm.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirm.ForeColor = Color.FromArgb(17, 47, 21);
            txtConfirm.Image = null;
            txtConfirm.ImageExpand = new Point(0, 0);
            txtConfirm.ImageOffset = new Point(0, 0);
            txtConfirm.Location = new Point(44, 203);
            txtConfirm.Margin = new Padding(4, 3, 4, 3);
            txtConfirm.Multiline = false;
            txtConfirm.Name = "txtConfirm";
            txtConfirm.NormalImageTint = Color.White;
            txtConfirm.OutlineColor = Color.DimGray;
            txtConfirm.Padding = new Padding(16, 6, 16, 0);
            txtConfirm.PasswordChar = false;
            txtConfirm.PlaceholderColor = Color.FromArgb(17, 47, 21);
            txtConfirm.PlaceholderText = "Confirm Password";
            txtConfirm.Rounding = new Padding(15);
            txtConfirm.Size = new Size(282, 29);
            txtConfirm.TabIndex = 9;
            txtConfirm.Tag = "*";
            txtConfirm.TextOffset = new Size(0, 0);
            txtConfirm.UnderlinedStyle = true;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Create\\ an\\ Account";
            cuiLabel1.ForeColor = Color.FromArgb(235, 250, 221);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(45, 53);
            cuiLabel1.Margin = new Padding(4, 4, 4, 4);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(280, 19);
            cuiLabel1.TabIndex = 10;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel2
            // 
            cuiLabel2.BackColor = Color.Transparent;
            cuiLabel2.Content = "Welcome\\ Admin!";
            cuiLabel2.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel2.ForeColor = Color.FromArgb(235, 250, 221);
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(52, 22);
            cuiLabel2.Margin = new Padding(4, 4, 4, 4);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(277, 25);
            cuiLabel2.TabIndex = 11;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiPanel1
            // 
            cuiPanel1.BackColor = Color.Transparent;
            cuiPanel1.Controls.Add(lblStatus);
            cuiPanel1.Controls.Add(btnShowConfirm);
            cuiPanel1.Controls.Add(btnShowPassword);
            cuiPanel1.Controls.Add(cuiLabel2);
            cuiPanel1.Controls.Add(btnCreate);
            cuiPanel1.Controls.Add(txtConfirm);
            cuiPanel1.Controls.Add(cuiLabel1);
            cuiPanel1.Controls.Add(txtPassword);
            cuiPanel1.Controls.Add(lblConfirm);
            cuiPanel1.Controls.Add(lblPassword);
            cuiPanel1.Location = new Point(757, 48);
            cuiPanel1.Margin = new Padding(3, 2, 3, 2);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 0F;
            cuiPanel1.PanelColor = Color.Transparent;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(235, 250, 221);
            cuiPanel1.Rounding = new Padding(30);
            cuiPanel1.Size = new Size(382, 397);
            cuiPanel1.TabIndex = 12;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(52, 154);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 15);
            lblStatus.TabIndex = 16;
            // 
            // btnShowConfirm
            // 
            btnShowConfirm.BackgroundImageLayout = ImageLayout.None;
            btnShowConfirm.CheckButton = false;
            btnShowConfirm.Checked = false;
            btnShowConfirm.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnShowConfirm.CheckedForeColor = Color.White;
            btnShowConfirm.CheckedImageTint = Color.Transparent;
            btnShowConfirm.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnShowConfirm.Content = "";
            btnShowConfirm.DialogResult = DialogResult.None;
            btnShowConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnShowConfirm.ForeColor = Color.Black;
            btnShowConfirm.HoverBackground = Color.White;
            btnShowConfirm.HoverForeColor = Color.DimGray;
            btnShowConfirm.HoverImageTint = Color.DimGray;
            btnShowConfirm.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnShowConfirm.Image = null;
            btnShowConfirm.ImageExpand = new Point(0, 0);
            btnShowConfirm.Location = new Point(328, 203);
            btnShowConfirm.Margin = new Padding(3, 2, 3, 2);
            btnShowConfirm.Name = "btnShowConfirm";
            btnShowConfirm.NormalBackground = Color.Transparent;
            btnShowConfirm.NormalForeColor = Color.Black;
            btnShowConfirm.NormalImageTint = Color.White;
            btnShowConfirm.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnShowConfirm.OutlineThickness = 1F;
            btnShowConfirm.Padding = new Padding(10, 9, 10, 9);
            btnShowConfirm.PressedBackground = Color.WhiteSmoke;
            btnShowConfirm.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnShowConfirm.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnShowConfirm.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnShowConfirm.Rounding = new Padding(20);
            btnShowConfirm.Size = new Size(34, 27);
            btnShowConfirm.TabIndex = 15;
            btnShowConfirm.TextAlignment = StringAlignment.Center;
            btnShowConfirm.TextPadding = -1;
            btnShowConfirm.TextSpacing = 2;
            btnShowConfirm.Click += btnShowConfirm_Click;
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
            btnShowPassword.Image = null;
            btnShowPassword.ImageExpand = new Point(0, 0);
            btnShowPassword.Location = new Point(326, 120);
            btnShowPassword.Margin = new Padding(3, 2, 3, 2);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.NormalBackground = Color.Transparent;
            btnShowPassword.NormalForeColor = Color.Transparent;
            btnShowPassword.NormalImageTint = Color.White;
            btnShowPassword.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnShowPassword.OutlineThickness = 1F;
            btnShowPassword.Padding = new Padding(10, 9, 10, 9);
            btnShowPassword.PressedBackground = Color.WhiteSmoke;
            btnShowPassword.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnShowPassword.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnShowPassword.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnShowPassword.Rounding = new Padding(20);
            btnShowPassword.Size = new Size(34, 27);
            btnShowPassword.TabIndex = 14;
            btnShowPassword.TextAlignment = StringAlignment.Center;
            btnShowPassword.TextPadding = -1;
            btnShowPassword.TextSpacing = 2;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // AdminSetupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 250, 221);
            BackgroundImage = Properties.Resources.Desktop___41__4_;
            ClientSize = new Size(1180, 541);
            Controls.Add(cuiPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminSetupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblPassword;
        private Label lblConfirm;
        private CuoreUI.Controls.cuiButton btnCreate;
        private CuoreUI.Controls.cuiTextBox txtUsername;
        private CuoreUI.Controls.cuiTextBox txtPassword;
        private CuoreUI.Controls.cuiTextBox txtConfirm;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiButton btnShowPassword;
        private CuoreUI.Controls.cuiButton btnShowConfirm;
        private Label lblStatus;
    }
}