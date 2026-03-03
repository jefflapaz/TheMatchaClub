namespace TheMatchaClub.Winforms
{
    partial class ReceiptPreviewForm
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
            rtbReceipt = new RichTextBox();
            btnDone = new Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // rtbReceipt
            // 
            rtbReceipt.BackColor = Color.FromArgb(250, 255, 208);
            rtbReceipt.Dock = DockStyle.Fill;
            rtbReceipt.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbReceipt.Location = new Point(0, 0);
            rtbReceipt.Name = "rtbReceipt";
            rtbReceipt.ReadOnly = true;
            rtbReceipt.Size = new Size(384, 450);
            rtbReceipt.TabIndex = 0;
            rtbReceipt.Text = "";
            // 
            // btnDone
            // 
            btnDone.Dock = DockStyle.Bottom;
            btnDone.Location = new Point(0, 410);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(384, 40);
            btnDone.TabIndex = 1;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = true;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(53, 108, 27);
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(118, 246);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(180, 45);
            guna2Button1.TabIndex = 2;
            guna2Button1.Text = "guna2Button1";
            // 
            // ReceiptPreviewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 450);
            Controls.Add(guna2Button1);
            Controls.Add(btnDone);
            Controls.Add(rtbReceipt);
            Name = "ReceiptPreviewForm";
            Text = "ReceiptPreviewForm";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbReceipt;
        private Button btnDone;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}