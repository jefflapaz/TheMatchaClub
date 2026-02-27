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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblName = new Label();
            lblPrice = new Label();
            lblCategory = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            chkUsual = new CheckBox();
            btnSave = new Button();
            cmbCategory = new ComboBox();
            guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            guna2GradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(17, 18);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(17, 47);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Price";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(17, 80);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category";
            // 
            // txtName
            // 
            txtName.Location = new Point(126, 15);
            txtName.Name = "txtName";
            txtName.Size = new Size(126, 23);
            txtName.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(126, 47);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(126, 23);
            txtPrice.TabIndex = 4;
            // 
            // chkUsual
            // 
            chkUsual.AutoSize = true;
            chkUsual.Location = new Point(17, 109);
            chkUsual.Name = "chkUsual";
            chkUsual.Size = new Size(101, 19);
            chkUsual.TabIndex = 5;
            chkUsual.Text = "Mark As Usual";
            chkUsual.UseVisualStyleBackColor = true;
            chkUsual.CheckedChanged += chkUsual_CheckedChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(146, 153);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(126, 77);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 7;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // guna2GradientPanel1
            // 
            guna2GradientPanel1.BackColor = Color.FromArgb(225, 244, 206);
            guna2GradientPanel1.BorderRadius = 100;
            guna2GradientPanel1.BorderThickness = 1;
            guna2GradientPanel1.Controls.Add(lblName);
            guna2GradientPanel1.Controls.Add(lblPrice);
            guna2GradientPanel1.Controls.Add(txtName);
            guna2GradientPanel1.Controls.Add(cmbCategory);
            guna2GradientPanel1.Controls.Add(chkUsual);
            guna2GradientPanel1.Controls.Add(btnSave);
            guna2GradientPanel1.Controls.Add(txtPrice);
            guna2GradientPanel1.Controls.Add(lblCategory);
            guna2GradientPanel1.CustomizableEdges = customizableEdges1;
            guna2GradientPanel1.Location = new Point(291, 72);
            guna2GradientPanel1.Name = "guna2GradientPanel1";
            guna2GradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2GradientPanel1.Size = new Size(277, 205);
            guna2GradientPanel1.TabIndex = 8;
            // 
            // guna2ImageButton1
            // 
            guna2ImageButton1.BackColor = Color.White;
            guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.HoverState.ImageSize = new Size(64, 64);
            guna2ImageButton1.Image = (Image)resources.GetObject("guna2ImageButton1.Image");
            guna2ImageButton1.ImageOffset = new Point(0, 0);
            guna2ImageButton1.ImageRotate = 0F;
            guna2ImageButton1.Location = new Point(24, 72);
            guna2ImageButton1.Name = "guna2ImageButton1";
            guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
            guna2ImageButton1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2ImageButton1.Size = new Size(231, 205);
            guna2ImageButton1.TabIndex = 9;
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(53, 108, 27);
            ClientSize = new Size(592, 343);
            Controls.Add(guna2ImageButton1);
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
        private Button btnSave;
        private ComboBox cmbCategory;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
    }
}