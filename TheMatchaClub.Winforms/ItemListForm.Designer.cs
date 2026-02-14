namespace TheMatchaClub.Winforms
{
    partial class ItemListForm
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
            btnAdd = new Button();
            flpItems = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Top;
            btnAdd.Location = new Point(0, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(800, 40);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+ Add Item";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // flpItems
            // 
            flpItems.AutoScroll = true;
            flpItems.Dock = DockStyle.Fill;
            flpItems.Location = new Point(0, 40);
            flpItems.Name = "flpItems";
            flpItems.Size = new Size(800, 410);
            flpItems.TabIndex = 1;
            // 
            // ItemListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flpItems);
            Controls.Add(btnAdd);
            Name = "ItemListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ItemListForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private FlowLayoutPanel flpItems;
    }
}