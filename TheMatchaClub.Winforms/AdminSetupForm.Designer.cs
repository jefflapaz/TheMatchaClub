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
            txtPassword = new TextBox();
            txtConfirm = new TextBox();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(435, 206);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password:";
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Location = new Point(435, 253);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(114, 15);
            lblConfirm.TabIndex = 2;
            lblConfirm.Text = "Re-eneter Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(570, 198);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(189, 23);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(570, 245);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(189, 23);
            txtConfirm.TabIndex = 5;
            txtConfirm.UseSystemPasswordChar = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(684, 295);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 29);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // AdminSetupForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCreate);
            Controls.Add(txtConfirm);
            Controls.Add(txtPassword);
            Controls.Add(lblConfirm);
            Controls.Add(lblPassword);
            Name = "AdminSetupForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPassword;
        private Label lblConfirm;
        private TextBox txtPassword;
        private TextBox txtConfirm;
        private Button btnCreate;
    }
}
