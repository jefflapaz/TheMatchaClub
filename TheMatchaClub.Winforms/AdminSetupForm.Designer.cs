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
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.FromArgb(225, 244, 206);
            lblPassword.Location = new Point(921, 308);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 20);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password:";
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.BackColor = Color.FromArgb(225, 244, 206);
            lblConfirm.Location = new Point(923, 394);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(127, 20);
            lblConfirm.TabIndex = 2;
            lblConfirm.Text = "Confirm Password";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(225, 244, 206);
            btnCreate.CheckButton = false;
            btnCreate.Checked = false;
            btnCreate.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnCreate.CheckedForeColor = Color.White;
            btnCreate.CheckedImageTint = Color.White;
            btnCreate.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnCreate.Content = "Create";
            btnCreate.DialogResult = DialogResult.None;
            btnCreate.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnCreate.ForeColor = Color.Black;
            btnCreate.HoverBackground = Color.FromArgb(169, 209, 129);
            btnCreate.HoverForeColor = Color.FromArgb(53, 108, 27);
            btnCreate.HoverImageTint = Color.DimGray;
            btnCreate.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnCreate.Image = null;
            btnCreate.ImageExpand = new Point(0, 0);
            btnCreate.Location = new Point(914, 486);
            btnCreate.Name = "btnCreate";
            btnCreate.NormalBackground = Color.White;
            btnCreate.NormalForeColor = Color.Black;
            btnCreate.NormalImageTint = Color.Black;
            btnCreate.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnCreate.OutlineThickness = 1F;
            btnCreate.Padding = new Padding(12);
            btnCreate.PressedBackground = Color.FromArgb(53, 108, 27);
            btnCreate.PressedForeColor = Color.FromArgb(169, 209, 129);
            btnCreate.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnCreate.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnCreate.Rounding = new Padding(20);
            btnCreate.Size = new Size(322, 48);
            btnCreate.TabIndex = 6;
            btnCreate.TextAlignment = StringAlignment.Center;
            btnCreate.TextPadding = 12;
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
            txtPassword.BackColor = Color.FromArgb(225, 244, 206);
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
            txtPassword.Location = new Point(915, 342);
            txtPassword.Margin = new Padding(4);
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.NormalImageTint = Color.White;
            txtPassword.OutlineColor = Color.DimGray;
            txtPassword.Padding = new Padding(20, 9, 20, 0);
            txtPassword.PasswordChar = false;
            txtPassword.PlaceholderColor = Color.LemonChiffon;
            txtPassword.PlaceholderText = "Password";
            txtPassword.Rounding = new Padding(15);
            txtPassword.Size = new Size(322, 39);
            txtPassword.TabIndex = 8;
            txtPassword.Tag = "*";
            txtPassword.TextOffset = new Size(0, 0);
            txtPassword.UnderlinedStyle = true;
            // 
            // txtConfirm
            // 
            txtConfirm.BackColor = Color.FromArgb(225, 244, 206);
            txtConfirm.BackgroundColor = Color.FromArgb(53, 108, 27);
            txtConfirm.Content = "";
            txtConfirm.FocusBackgroundColor = Color.FromArgb(53, 108, 27);
            txtConfirm.FocusImageTint = Color.White;
            txtConfirm.FocusOutlineColor = Color.DarkOliveGreen;
            txtConfirm.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirm.ForeColor = Color.LemonChiffon;
            txtConfirm.Image = null;
            txtConfirm.ImageExpand = new Point(0, 0);
            txtConfirm.ImageOffset = new Point(0, 0);
            txtConfirm.Location = new Point(914, 425);
            txtConfirm.Margin = new Padding(4);
            txtConfirm.Multiline = false;
            txtConfirm.Name = "txtConfirm";
            txtConfirm.NormalImageTint = Color.White;
            txtConfirm.OutlineColor = Color.DimGray;
            txtConfirm.Padding = new Padding(20, 9, 20, 0);
            txtConfirm.PasswordChar = false;
            txtConfirm.PlaceholderColor = Color.LemonChiffon;
            txtConfirm.PlaceholderText = "Confirm Password";
            txtConfirm.Rounding = new Padding(15);
            txtConfirm.Size = new Size(322, 39);
            txtConfirm.TabIndex = 9;
            txtConfirm.Tag = "*";
            txtConfirm.TextOffset = new Size(0, 0);
            txtConfirm.UnderlinedStyle = true;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.FromArgb(225, 244, 206);
            cuiLabel1.Content = "Create\\ an\\ Account";
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(909, 174);
            cuiLabel1.Margin = new Padding(4, 5, 4, 5);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(320, 25);
            cuiLabel1.TabIndex = 10;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiLabel2
            // 
            cuiLabel2.BackColor = Color.FromArgb(225, 244, 206);
            cuiLabel2.Content = "Welcome\\ Admin!";
            cuiLabel2.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel2.ForeColor = Color.DarkOliveGreen;
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(925, 131);
            cuiLabel2.Margin = new Padding(4, 5, 4, 5);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(287, 33);
            cuiLabel2.TabIndex = 11;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // AdminSetupForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.Desktop___37;
            ClientSize = new Size(1348, 721);
            Controls.Add(cuiLabel2);
            Controls.Add(cuiLabel1);
            Controls.Add(txtConfirm);
            Controls.Add(txtPassword);
            Controls.Add(btnCreate);
            Controls.Add(lblConfirm);
            Controls.Add(lblPassword);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminSetupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
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
    }
}
