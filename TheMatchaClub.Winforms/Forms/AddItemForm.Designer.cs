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
            lblName = new Label();
            lblPrice = new Label();
            lblCategory = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            chkUsual = new CheckBox();
            btnSave = new Button();
            cmbCategory = new ComboBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(285, 128);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(285, 157);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Price";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(285, 190);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category";
            // 
            // txtName
            // 
            txtName.Location = new Point(352, 125);
            txtName.Name = "txtName";
            txtName.Size = new Size(126, 23);
            txtName.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(352, 157);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(126, 23);
            txtPrice.TabIndex = 4;
            // 
            // chkUsual
            // 
            chkUsual.AutoSize = true;
            chkUsual.Location = new Point(285, 219);
            chkUsual.Name = "chkUsual";
            chkUsual.Size = new Size(101, 19);
            chkUsual.TabIndex = 5;
            chkUsual.Text = "Mark As Usual";
            chkUsual.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(388, 261);
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
            cmbCategory.Location = new Point(357, 190);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 7;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 343);
            Controls.Add(cmbCategory);
            Controls.Add(btnSave);
            Controls.Add(chkUsual);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(lblCategory);
            Controls.Add(lblPrice);
            Controls.Add(lblName);
            Name = "AddItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddItemForm";
            Load += AddItemForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
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
    }
}