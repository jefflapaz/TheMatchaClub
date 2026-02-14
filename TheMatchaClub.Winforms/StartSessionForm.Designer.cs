namespace TheMatchaClub.Winforms
{
    partial class StartSessionForm
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
            lblSession = new Label();
            txtSession = new TextBox();
            btnStart = new Button();
            SuspendLayout();
            // 
            // lblSession
            // 
            lblSession.AutoSize = true;
            lblSession.Location = new Point(295, 159);
            lblSession.Name = "lblSession";
            lblSession.Size = new Size(84, 15);
            lblSession.TabIndex = 0;
            lblSession.Text = "Session Name:";
            // 
            // txtSession
            // 
            txtSession.Location = new Point(295, 177);
            txtSession.Name = "txtSession";
            txtSession.Size = new Size(143, 23);
            txtSession.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(355, 230);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start Session";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // StartSessionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStart);
            Controls.Add(txtSession);
            Controls.Add(lblSession);
            Name = "StartSessionForm";
            Text = "StartSessionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSession;
        private TextBox txtSession;
        private Button btnStart;
    }
}