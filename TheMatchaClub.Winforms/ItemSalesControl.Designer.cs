namespace TheMatchaClub.Winforms
{
    partial class ItemSalesControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblGrandTotal = new Label();
            dgvItems = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            SuspendLayout();
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.Dock = DockStyle.Bottom;
            lblGrandTotal.Font = new Font("Segoe UI", 16F);
            lblGrandTotal.Location = new Point(0, 500);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(189, 30);
            lblGrandTotal.TabIndex = 3;
            lblGrandTotal.Text = "Grand Total: ₱0.00";
            // 
            // dgvItems
            // 
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Dock = DockStyle.Fill;
            dgvItems.Location = new Point(0, 0);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.Size = new Size(649, 530);
            dgvItems.TabIndex = 2;
            // 
            // ItemSalesControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblGrandTotal);
            Controls.Add(dgvItems);
            Name = "ItemSalesControl";
            Size = new Size(649, 530);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGrandTotal;
        private DataGridView dgvItems;
    }
}
