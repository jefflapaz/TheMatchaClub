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
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.Font = new Font("Segoe UI", 10F);
            lblMessage.Location = new Point(12, 33);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(422, 80);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Typewriter text goes here...";
            // 
            // btnOk
            // 
            btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOk.BackColor = Color.FromArgb(225, 244, 206);
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(349, 117);
            btnOk.Margin = new Padding(3, 4, 3, 4);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(86, 40);
            btnOk.TabIndex = 1;
            btnOk.Text = "Got it";
            btnOk.UseVisualStyleBackColor = false;
            // 
            // typeTimer
            // 
        
            
             typeTimer.Interval = 2;
       //    typeTimer.Tick += typeTimer_Tick;
            // 
            // MyUniversalBox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 221);
            ClientSize = new Size(457, 184);
            Controls.Add(btnOk);
            Controls.Add(lblMessage);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MyUniversalBox";
            StartPosition = FormStartPosition.CenterParent;
            Text = "System Message";
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Timer typeTimer;
    }
}