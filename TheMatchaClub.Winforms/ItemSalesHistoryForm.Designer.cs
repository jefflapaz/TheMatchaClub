namespace TheMatchaClub.Winforms
{
    partial class ItemSalesHistoryForm
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
            dgvItems = new DataGridView();
            lblGrandTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.Location = new Point(0, 0);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.Size = new Size(800, 450);
            dgvItems.TabIndex = 0;
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Dock = DockStyle.Bottom;
            lblGrandTotal.Font = new Font("Segoe UI", 16F);
            lblGrandTotal.Location = new Point(0, 420);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(189, 30);
            lblGrandTotal.TabIndex = 1;
            lblGrandTotal.Text = "Grand Total: ₱0.00";
            // 
            // ItemSalesHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblGrandTotal);
            Controls.Add(dgvItems);
            Name = "ItemSalesHistoryForm";
            Text = "ItemSalesHistoryForm";
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvItems;
        private Label lblGrandTotal;
    }
}