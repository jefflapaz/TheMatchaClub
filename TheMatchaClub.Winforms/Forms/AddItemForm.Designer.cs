namespace TheMatchaClub.Winforms
{
    partial class AddItemForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblName = new Label();
            lblPrice = new Label();
            lblCategory = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            chkUsual = new CheckBox();
            cmbCategory = new ComboBox();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            btnImageAddItem = new Guna.UI2.WinForms.Guna2ImageButton();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(19, 41);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(19, 70);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Price";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(19, 103);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category";
            // 
            // txtName
            // 
            txtName.Location = new Point(128, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(126, 23);
            txtName.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(128, 70);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(126, 23);
            txtPrice.TabIndex = 4;
            // 
            // chkUsual
            // 
            chkUsual.AutoSize = true;
            chkUsual.Location = new Point(19, 132);
            chkUsual.Name = "chkUsual";
            chkUsual.Size = new Size(101, 19);
            chkUsual.TabIndex = 5;
            chkUsual.Text = "Mark As Usual";
            chkUsual.UseVisualStyleBackColor = true;
            chkUsual.CheckedChanged += chkUsual_CheckedChanged;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(128, 100);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(126, 23);
            cmbCategory.TabIndex = 7;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.BackColor = Color.Transparent;
            guna2GradientPanel1.BorderRadius = 50;
            guna2GradientPanel1.BorderThickness = 1;
            guna2GradientPanel1.Controls.Add(btnSave);
            guna2GradientPanel1.Controls.Add(lblName);
            guna2GradientPanel1.Controls.Add(lblPrice);
            guna2GradientPanel1.Controls.Add(txtName);
            guna2GradientPanel1.Controls.Add(cmbCategory);
            guna2GradientPanel1.Controls.Add(chkUsual);
            guna2GradientPanel1.Controls.Add(txtPrice);
            guna2GradientPanel1.Controls.Add(lblCategory);
            guna2GradientPanel1.CustomizableEdges = customizableEdges8;
            guna2GradientPanel1.FillColor = Color.FromArgb(225, 244, 206);
            guna2GradientPanel1.FillColor2 = Color.FromArgb(225, 244, 206);
            guna2GradientPanel1.Location = new Point(291, 59);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2GradientPanel1.Size = new Size(277, 230);
            guna2GradientPanel1.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.BorderRadius = 10;
            btnSave.CustomizableEdges = customizableEdges6;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.FromArgb(53, 108, 27);
            btnSave.Font = new Font("Segoe UI", 9F);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(153, 156);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges7;
            btnSave.Size = new Size(72, 22);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnImageAddItem
            // 
            btnImageAddItem.BackColor = Color.White;
            btnImageAddItem.CheckedState.ImageSize = new Size(64, 64);
            btnImageAddItem.HoverState.ImageSize = new Size(64, 64);
            btnImageAddItem.ImageOffset = new Point(0, 0);
            btnImageAddItem.ImageRotate = 0F;
            btnImageAddItem.Location = new Point(37, 59);
            btnImageAddItem.Name = "btnImageAddItem";
            btnImageAddItem.PressedState.ImageSize = new Size(64, 64);
            btnImageAddItem.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnImageAddItem.Size = new Size(230, 230);
            btnImageAddItem.TabIndex = 9;
            btnImageAddItem.Click += btnImageAdd_Click;
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 108, 27);
            ClientSize = new Size(592, 343);
            Controls.Add(btnImageAddItem);
            Controls.Add(guna2GradientPanel1);
            Name = "AddItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += AddItemForm_Load_1;
            guna2GradientPanel1.ResumeLayout(false);
            guna2GradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblName;
        private Label lblPrice;
        private Label lblCategory;
        private TextBox txtName;
        private TextBox txtPrice;
        private CheckBox chkUsual;
        private ComboBox cmbCategory;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnImageAddItem;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}