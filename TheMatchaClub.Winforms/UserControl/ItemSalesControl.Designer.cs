namespace TheMatchaClub.Winforms
{
    partial class ItemSalesControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblGrandTotal = new Label();
            dgvItems = new DataGridView();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            btnSearch = new Guna.UI2.WinForms.Guna2CircleButton();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            cuiPanel1.SuspendLayout();
            cuiPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblGrandTotal
            // 
            lblGrandTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblGrandTotal.BackColor = Color.Transparent;
            lblGrandTotal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblGrandTotal.ForeColor = Color.FromArgb(45, 83, 26);
            lblGrandTotal.Location = new Point(1029, 853);
            lblGrandTotal.Name = "lblGrandTotal";
            lblGrandTotal.Size = new Size(571, 60);
            lblGrandTotal.TabIndex = 3;
            lblGrandTotal.Text = "Grand Total: ₱0.00";
            lblGrandTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 252, 248);
            dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvItems.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.BackgroundColor = Color.White;
            dgvItems.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 83, 26);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(45, 83, 26);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvItems.ColumnHeadersHeight = 45;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(235, 240, 230);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(45, 83, 26);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvItems.DefaultCellStyle = dataGridViewCellStyle3;
            dgvItems.EnableHeadersVisualStyles = false;
            dgvItems.GridColor = Color.FromArgb(235, 235, 235);
            dgvItems.Location = new Point(46, 120);
            dgvItems.Margin = new Padding(3, 4, 3, 4);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.RowHeadersVisible = false;
            dgvItems.RowHeadersWidth = 51;
            dgvItems.RowTemplate.Height = 40;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(1554, 707);
            dgvItems.TabIndex = 2;
            // 
            // cuiPanel1
            // 
            cuiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cuiPanel1.Controls.Add(btnSearch);
            cuiPanel1.Controls.Add(cuiLabel1);
            cuiPanel1.Controls.Add(txtSearch);
            cuiPanel1.Controls.Add(lblGrandTotal);
            cuiPanel1.Controls.Add(dgvItems);
            cuiPanel1.Location = new Point(23, 27);
            cuiPanel1.Margin = new Padding(3, 4, 3, 4);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(220, 220, 220);
            cuiPanel1.Rounding = new Padding(20);
            cuiPanel1.Size = new Size(1623, 920);
            cuiPanel1.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.Transparent;
            btnSearch.BorderColor = Color.FromArgb(45, 83, 26);
            btnSearch.BorderThickness = 1;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.FillColor = Color.FromArgb(245, 245, 221);
            btnSearch.Font = new Font("Segoe UI", 9F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(827, 40);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnSearch.Size = new Size(41, 48);
            btnSearch.TabIndex = 7;
            btnSearch.Click += btnSearch_Click;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Item\\ Sales\\ Report";
            cuiLabel1.Font = new Font("Verdana", 21F, FontStyle.Bold);
            cuiLabel1.ForeColor = Color.FromArgb(45, 83, 26);
            cuiLabel1.HorizontalAlignment = StringAlignment.Near;
            cuiLabel1.Location = new Point(46, 40);
            cuiLabel1.Margin = new Padding(5, 4, 5, 4);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(457, 60);
            cuiLabel1.TabIndex = 4;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BackColor = Color.Transparent;
            txtSearch.BorderColor = Color.FromArgb(45, 83, 26);
            txtSearch.BorderRadius = 15;
            txtSearch.CustomizableEdges = customizableEdges2;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FillColor = Color.FromArgb(245, 245, 221);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.ForeColor = Color.Black;
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Location = new Point(875, 40);
            txtSearch.Margin = new Padding(3, 5, 3, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderForeColor = Color.Black;
            txtSearch.PlaceholderText = "Search Here";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges3;
            txtSearch.Size = new Size(725, 48);
            txtSearch.TabIndex = 6;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cuiPanel2
            // 
            cuiPanel2.Controls.Add(cuiPanel1);
            cuiPanel2.Dock = DockStyle.Fill;
            cuiPanel2.Location = new Point(0, 0);
            cuiPanel2.Margin = new Padding(3, 4, 3, 4);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 0F;
            cuiPanel2.PanelColor = Color.FromArgb(45, 83, 26);
            cuiPanel2.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel2.Rounding = new Padding(0);
            cuiPanel2.Size = new Size(1669, 973);
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
            Size = new Size(1669, 973);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            cuiPanel1.ResumeLayout(false);
            cuiPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblGrandTotal;
        private DataGridView dgvItems;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}