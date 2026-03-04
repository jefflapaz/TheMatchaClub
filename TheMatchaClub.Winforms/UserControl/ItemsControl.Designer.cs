namespace TheMatchaClub.Winforms
{
    partial class ItemsControl
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
            flpItems = new FlowLayoutPanel();
            btnAdd = new CuoreUI.Controls.cuiButton();
            cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            cuiPanel1.SuspendLayout();
            cuiPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flpItems
            // 
            flpItems.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flpItems.AutoScroll = true;
            flpItems.Location = new Point(0, 0);
            flpItems.Margin = new Padding(3, 4, 3, 4);
            flpItems.Name = "flpItems";
            flpItems.Size = new Size(1645, 954);
            flpItems.TabIndex = 3;
            flpItems.Click += btnAdd_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnAdd.CheckButton = false;
            btnAdd.Checked = false;
            btnAdd.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnAdd.CheckedForeColor = Color.White;
            btnAdd.CheckedImageTint = Color.White;
            btnAdd.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnAdd.Content = "+Add";
            btnAdd.DialogResult = DialogResult.None;
            btnAdd.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnAdd.ForeColor = Color.LemonChiffon;
            btnAdd.HoverBackground = Color.White;
            btnAdd.HoverForeColor = Color.DimGray;
            btnAdd.HoverImageTint = Color.DimGray;
            btnAdd.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnAdd.Image = null;
            btnAdd.ImageExpand = new Point(0, 0);
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.NormalBackground = Color.FromArgb(53, 108, 27);
            btnAdd.NormalForeColor = Color.LemonChiffon;
            btnAdd.NormalImageTint = Color.Black;
            btnAdd.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnAdd.OutlineThickness = 1F;
            btnAdd.Padding = new Padding(12);
            btnAdd.PressedBackground = Color.WhiteSmoke;
            btnAdd.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnAdd.PressedImageTint = Color.FromArgb(32, 32, 32);
            btnAdd.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnAdd.Rounding = new Padding(20);
            btnAdd.Size = new Size(1635, 56);
            btnAdd.TabIndex = 0;
            btnAdd.TextAlignment = StringAlignment.Center;
            btnAdd.TextPadding = 12;
            btnAdd.TextSpacing = 2;
            btnAdd.Click += btnAdd_Click;
            // 
            // cuiPanel1
            // 
            cuiPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cuiPanel1.BackColor = Color.Transparent;
            cuiPanel1.Controls.Add(btnAdd);
            cuiPanel1.Controls.Add(flpItems);
            cuiPanel1.Location = new Point(3, 3);
            cuiPanel1.Name = "cuiPanel1";
            cuiPanel1.OutlineThickness = 1F;
            cuiPanel1.Padding = new Padding(0, 0, 10, 10);
            cuiPanel1.PanelColor = Color.White;
            cuiPanel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuiPanel1.Rounding = new Padding(20);
            cuiPanel1.Size = new Size(1655, 964);
            cuiPanel1.TabIndex = 0;
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
            cuiPanel2.TabIndex = 0;
            // 
            // ItemsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 83, 26);
            Controls.Add(cuiPanel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ItemsControl";
            Size = new Size(1669, 974);
            cuiPanel1.ResumeLayout(false);
            cuiPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpItems;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiButton btnAdd;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
    }
}
