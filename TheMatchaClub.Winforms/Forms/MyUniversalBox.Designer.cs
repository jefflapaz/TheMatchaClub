namespace TheMatchaClub.Winforms.Forms
{
    partial class MyUniversalBox
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

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblMessage = new Label();
            btnOk = new Button();
            typeTimer = new System.Windows.Forms.Timer(components);
            picIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 10F);
            lblMessage.Location = new Point(80, 25);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(300, 80);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Typewriter text goes here...";
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.BackColor = Color.FromArgb(225, 244, 206);
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(305, 88);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 30);
            btnOk.TabIndex = 1;
            btnOk.Text = "Got it";
            btnOk.UseVisualStyleBackColor = false;
            // 
            // typeTimer
            // 
            typeTimer.Interval = 30;
            typeTimer.Tick += typeTimer_Tick;
            // 
            // picIcon
            // 
            picIcon.Location = new Point(20, 25);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(48, 48);
            picIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picIcon.TabIndex = 2;
            picIcon.TabStop = false;
            // 
            // MyUniversalBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 221);
            ClientSize = new Size(400, 138);
            Controls.Add(picIcon);
            Controls.Add(btnOk);
            Controls.Add(lblMessage);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MyUniversalBox";
            StartPosition = FormStartPosition.CenterParent;
            Text = "System Message";
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Timer typeTimer;
        private System.Windows.Forms.PictureBox picIcon;
    }
}