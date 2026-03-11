namespace TheMatchaClub.Winforms
{
    partial class CustomerHistoryControl
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
            dgvHistory = new DataGridView();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            btnSearch = new Guna.UI2.WinForms.Guna2CircleButton();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            cuiPanel1.SuspendLayout();
            cuiPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 252, 248);
            dgvHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.BackgroundColor = Color.White;
            dgvHistory.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 83, 26);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(45, 83, 26);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvHistory.ColumnHeadersHeight = 45;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(235, 240, 230);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(45, 83, 26);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvHistory.DefaultCellStyle = dataGridViewCellStyle3;
            dgvHistory.EnableHeadersVisualStyles = false;
            dgvHistory.GridColor = Color.FromArgb(224, 224, 224);
            dgvHistory.Location = new Point(40, 109);
            dgvHistory.MultiSelect = false;
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersVisible = false;
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.RowTemplate.Height = 40;
            dgvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHistory.Size = new Size(1570, 811);
            dgvHistory.TabIndex = 1;
            // 
            // cuiPanel1
            // 
            cuiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cuiPanel1.Controls.Add(btnSearch);
            cuiPanel1.Controls.Add(txtSearch);
            cuiPanel1.Controls.Add(cuiLabel1);
            cuiPanel1.Controls.Add(dgvHistory);
            cuiPanel1.Location = new Point(21, 20);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(200, 200, 200);
            cuiPanel1.Rounding = new Padding(20);
            cuiPanel1.Size = new Size(1629, 933);
            cuiPanel1.TabIndex = 2;
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
            btnSearch.Location = new Point(821, 35);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnSearch.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnSearch.Size = new Size(41, 48);
            btnSearch.TabIndex = 4;
            btnSearch.Click += btnSearch_Click;
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
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Location = new Point(869, 35);
            txtSearch.Margin = new Padding(3, 5, 3, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderForeColor = Color.Black;
            txtSearch.PlaceholderText = "Search Here";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges3;
            txtSearch.Size = new Size(741, 48);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Customer\\ History";
            cuiLabel1.Font = new Font("Verdana", 24F, FontStyle.Bold);
            cuiLabel1.ForeColor = Color.FromArgb(45, 83, 26);
            cuiLabel1.HorizontalAlignment = StringAlignment.Near;
            cuiLabel1.Location = new Point(40, 35);
            cuiLabel1.Margin = new Padding(5, 3, 5, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(501, 51);
            cuiLabel1.TabIndex = 2;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // cuiPanel2
            // 
            cuiPanel2.Controls.Add(cuiPanel1);
            cuiPanel2.Dock = DockStyle.Fill;
            cuiPanel2.Location = new Point(0, 0);
            cuiPanel2.Name = "cuiPanel2";
            cuiPanel2.OutlineThickness = 0F;
            cuiPanel2.PanelColor = Color.FromArgb(45, 83, 26);
            cuiPanel2.PanelOutlineColor = Color.Transparent;
            cuiPanel2.Rounding = new Padding(0);
            cuiPanel2.Size = new Size(1669, 973);
            cuiPanel2.TabIndex = 3;
            // 
            // CustomerHistoryControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 83, 26);
            Controls.Add(cuiPanel2);
            Name = "CustomerHistoryControl";
            Size = new Size(1669, 973);
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
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2CircleButton btnSearch;
    }
}