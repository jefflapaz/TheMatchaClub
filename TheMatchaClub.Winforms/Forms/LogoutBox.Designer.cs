namespace TheMatchaClub.Winforms.Forms
{
    partial class LogoutBox
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnLogoutOnly = new System.Windows.Forms.Button();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(108)))), ((int)(((byte)(27)))));
            this.lblTitle.Location = new System.Drawing.Point(12, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(356, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "What would you like to do?";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogoutOnly
            // 
            this.btnLogoutOnly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(108)))), ((int)(((byte)(27)))));
            this.btnLogoutOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoutOnly.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnLogoutOnly.ForeColor = System.Drawing.Color.White;
            this.btnLogoutOnly.Location = new System.Drawing.Point(30, 65);
            this.btnLogoutOnly.Name = "btnLogoutOnly";
            this.btnLogoutOnly.Size = new System.Drawing.Size(150, 45);
            this.btnLogoutOnly.TabIndex = 1;
            this.btnLogoutOnly.Text = "Logout Only";
            this.btnLogoutOnly.UseVisualStyleBackColor = false;
            // 
            // btnExitApp
            // 
            this.btnExitApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(108)))), ((int)(((byte)(27)))));
            this.btnExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitApp.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnExitApp.ForeColor = System.Drawing.Color.White;
            this.btnExitApp.Location = new System.Drawing.Point(200, 65);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(150, 45);
            this.btnExitApp.TabIndex = 2;
            this.btnExitApp.Text = "Logout && Exit";
            this.btnExitApp.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.btnCancel.ForeColor = System.Drawing.Color.Gray;
            this.btnCancel.Location = new System.Drawing.Point(150, 125);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Stay Here";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // LogoutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(221)))));
            this.ClientSize = new System.Drawing.Size(380, 165);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExitApp);
            this.Controls.Add(this.btnLogoutOnly);
            this.Controls.Add(this.lblTitle);
           // this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            //this.MaximizeBox = false;
           // this.MinimizeBox = false;
            this.Name = "LogoutBox";
           // this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exit System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnLogoutOnly;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Button btnCancel;
    }
}