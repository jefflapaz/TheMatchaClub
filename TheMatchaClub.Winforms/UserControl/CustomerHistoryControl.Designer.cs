namespace TheMatchaClub.Winforms
{
    partial class CustomerHistoryControl
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
            dgvHistory = new DataGridView();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            cuiPanel1.SuspendLayout();
            cuiPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHistory
            // 
            dgvHistory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvHistory.BackgroundColor = Color.White;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.GridColor = Color.DarkOliveGreen;
            dgvHistory.Location = new Point(86, 114);
            dgvHistory.Margin = new Padding(3, 4, 3, 4);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersWidth = 80;
            dgvHistory.Size = new Size(1468, 765);
            dgvHistory.TabIndex = 1;
            // 
            // cuiPanel1
            // 
            cuiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cuiPanel1.Controls.Add(cuiLabel1);
            cuiPanel1.Controls.Add(dgvHistory);
            cuiPanel1.Location = new Point(0, 0);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.Padding = new Padding(0, 0, 10, 10);
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel1.Rounding = new Padding(20);
            cuiPanel1.Size = new Size(1655, 964);
            cuiPanel1.TabIndex = 2;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Customer\\ History";
            cuiLabel1.Font = new Font("Verdana", 21F, FontStyle.Bold);
            cuiLabel1.ForeColor = Color.DarkOliveGreen;
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(65, 35);
            cuiLabel1.Margin = new Padding(4, 5, 4, 5);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(400, 45);
            cuiLabel1.TabIndex = 2;
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
            cuiPanel2.TabIndex = 3;
            // 
            // CustomerHistoryControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 83, 26);
            Controls.Add(cuiPanel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerHistoryControl";
            Size = new Size(1669, 974);
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            cuiPanel1.ResumeLayout(false);
            cuiPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvHistory;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
    }
}
