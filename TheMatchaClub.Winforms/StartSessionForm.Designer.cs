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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartSessionForm));
            lblSession = new Label();
            txtSession = new TextBox();
            btnStart = new Button();
            SuspendLayout();
            // 
            // lblSession
            // 
            lblSession.AutoSize = true;
            lblSession.Location = new Point(337, 212);
            lblSession.Name = "lblSession";
            lblSession.Size = new Size(105, 20);
            lblSession.TabIndex = 0;
            lblSession.Text = "Session Name:";
            // 
            // txtSession
            // 
            txtSession.Location = new Point(337, 236);
            txtSession.Margin = new Padding(3, 4, 3, 4);
            txtSession.Name = "txtSession";
            txtSession.Size = new Size(163, 27);
            txtSession.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(406, 307);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(86, 31);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start Session";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // StartSessionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1244, 649);
            Controls.Add(btnStart);
            Controls.Add(txtSession);
            Controls.Add(lblSession);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "StartSessionForm";
            StartPosition = FormStartPosition.CenterScreen;
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