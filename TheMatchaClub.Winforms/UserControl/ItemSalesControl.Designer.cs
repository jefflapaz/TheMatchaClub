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
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            cuiPanel1.SuspendLayout();
            cuiPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.AutoSize = true;
            lblGrandTotal.BackColor = Color.White;
            lblGrandTotal.Dock = DockStyle.Bottom;
            lblGrandTotal.Font = new Font("Segoe UI", 16F);
            lblGrandTotal.Location = new Point(0, 917);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(234, 37);
            lblGrandTotal.TabIndex = 3;
            lblGrandTotal.Text = "Grand Total: ₱0.00";
            // 
            // dgvItems
            // 
            dgvItems.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvItems.BackgroundColor = Color.White;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Location = new Point(78, 120);
            dgvItems.Margin = new Padding(3, 4, 3, 4);
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersWidth = 51;
            dgvItems.Size = new Size(1492, 771);
            dgvItems.TabIndex = 2;
            // 
            // cuiPanel1
            // 
            cuiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cuiPanel1.Controls.Add(cuiLabel1);
            cuiPanel1.Controls.Add(lblGrandTotal);
            cuiPanel1.Controls.Add(dgvItems);
            cuiPanel1.Location = new Point(0, 0);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.Padding = new Padding(0, 0, 10, 10);
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.Transparent;
            cuiPanel1.Rounding = new Padding(20);
            cuiPanel1.Size = new Size(1655, 964);
            cuiPanel1.TabIndex = 4;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Item\\ Sales";
            cuiLabel1.Font = new Font("Verdana", 21F, FontStyle.Bold);
            cuiLabel1.ForeColor = Color.OliveDrab;
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(78, 35);
            cuiLabel1.Margin = new Padding(4, 5, 4, 5);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(255, 58);
            cuiLabel1.TabIndex = 4;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiPanel2
            // 
            cuiPanel2.Controls.Add(cuiPanel1);
            cuiPanel2.Dock = DockStyle.Fill;
            cuiPanel2.Location = new Point(0, 0);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 1F;
            cuiPanel2.PanelColor = Color.FromArgb(45, 83, 26);
            cuiPanel2.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel2.Rounding = new Padding(8);
            cuiPanel2.Size = new Size(1669, 974);
            cuiPanel2.TabIndex = 5;
            // 
            // ItemSalesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 83, 26);
            Controls.Add(cuiPanel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ItemSalesControl";
            Size = new Size(1669, 974);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            cuiPanel1.ResumeLayout(false);
            cuiPanel1.PerformLayout();
            cuiPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblGrandTotal;
        private DataGridView dgvItems;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
    }
}
