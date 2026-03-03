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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblSession = new Label();
            txtSession = new TextBox();
            btnStart = new Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // lblSession
            // 
            lblSession.AutoSize = true;
            lblSession.Location = new Point(295, 66);
            lblSession.Name = "lblSession";
            lblSession.Size = new Size(84, 15);
            lblSession.TabIndex = 0;
            lblSession.Text = "Session Name:";
            // 
            // txtSession
            // 
            txtSession.Location = new Point(295, 84);
            txtSession.Name = "txtSession";
            txtSession.Size = new Size(143, 23);
            txtSession.TabIndex = 1;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(355, 137);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start Session";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.Transparent;
            guna2Button1.BorderRadius = 15;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(53, 108, 27);
            guna2Button1.Font = new Font("Segoe UI", 12F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(371, 314);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(103, 31);
            guna2Button1.TabIndex = 3;
            guna2Button1.Text = "Start";
            // 
            // guna2TextBox1
            // 
            guna2TextBox1.BorderRadius = 15;
            guna2TextBox1.BorderThickness = 2;
            guna2TextBox1.CustomizableEdges = customizableEdges3;
            guna2TextBox1.DefaultText = "";
            guna2TextBox1.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            guna2TextBox1.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            guna2TextBox1.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            guna2TextBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Font = new Font("Segoe UI", 9F);
            guna2TextBox1.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2TextBox1.Location = new Point(274, 261);
            guna2TextBox1.Name = "guna2TextBox1";
            guna2TextBox1.PlaceholderText = "";
            guna2TextBox1.SelectedText = "";
            guna2TextBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2TextBox1.Size = new Size(200, 36);
            guna2TextBox1.TabIndex = 4;
            // 
            // StartSessionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 221);
            ClientSize = new Size(800, 450);
            Controls.Add(guna2TextBox1);
            Controls.Add(guna2Button1);
            Controls.Add(btnStart);
            Controls.Add(txtSession);
            Controls.Add(lblSession);
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
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
    }
}