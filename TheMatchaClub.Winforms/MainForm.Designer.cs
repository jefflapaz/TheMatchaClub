namespace TheMatchaClub.Winforms
{
    partial class MainForm
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
            btnEndSession = new Button();
            lblSession = new Label();
            SuspendLayout();
            // 
            // btnEndSession
            // 
            btnEndSession.Location = new Point(594, 172);
            btnEndSession.Name = "btnEndSession";
            btnEndSession.Size = new Size(94, 23);
            btnEndSession.TabIndex = 0;
            btnEndSession.Text = "End Session";
            btnEndSession.UseVisualStyleBackColor = true;
            btnEndSession.Click += btnEndSession_Click;
            // 
            // lblSession
            // 
            lblSession.AutoSize = true;
            lblSession.Location = new Point(488, 83);
            lblSession.Name = "lblSession";
            lblSession.Size = new Size(85, 15);
            lblSession.TabIndex = 1;
            lblSession.Text = "Active Session:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSession);
            Controls.Add(btnEndSession);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEndSession;
        private Label lblSession;
    }
}