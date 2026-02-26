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
            rtbReceipt = new RichTextBox();
            btnDone = new Button();
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
            // ReceiptPreviewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 450);
            Controls.Add(btnDone);
            Controls.Add(rtbReceipt);
            Name = "ReceiptPreviewForm";
            Text = "ReceiptPreviewForm";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbReceipt;
        private Button btnDone;
    }
}