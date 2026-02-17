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
            btnAdd = new Button();
            SuspendLayout();
            // 
            // flpItems
            // 
            flpItems.AutoScroll = true;
            flpItems.Dock = DockStyle.Fill;
            flpItems.Location = new Point(0, 40);
            flpItems.Name = "flpItems";
            flpItems.Size = new Size(598, 467);
            flpItems.TabIndex = 3;
            flpItems.Click += btnAdd_Click;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Top;
            btnAdd.Location = new Point(0, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(598, 40);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "+ Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // ItemsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flpItems);
            Controls.Add(btnAdd);
            Name = "ItemsControl";
            Size = new Size(598, 507);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpItems;
        private Button btnAdd;
    }
}
