namespace TheMatchaClub.Winforms
{
    partial class ChooseItemDialog
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
            flpItems = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpItems
            // 
            flpItems.AutoScroll = true;
            flpItems.Dock = DockStyle.Fill;
            flpItems.Location = new Point(0, 0);
            flpItems.Name = "flpItems";
            flpItems.Size = new Size(408, 421);
            flpItems.TabIndex = 0;
            // 
            // ChooseItemDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 421);
            Controls.Add(flpItems);
            Name = "ChooseItemDialog";
            Text = "ChooseItemDialog";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpItems;
    }
}