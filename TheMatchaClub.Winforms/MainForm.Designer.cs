namespace TheMatchaClub.Winforms
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            pnlSidebar = new Panel();
            btnLogout = new Button();
            btnReport = new Button();
            btnItemSales = new Button();
            btnCustomer = new Button();
            btnItems = new Button();
            btnPOS = new Button();
            pnlContent = new Panel();
            sidebarTimer = new System.Windows.Forms.Timer(components);
            pnlSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = Color.PaleGreen;
            pnlSidebar.Controls.Add(btnLogout);
            pnlSidebar.Controls.Add(btnReport);
            pnlSidebar.Controls.Add(btnItemSales);
            pnlSidebar.Controls.Add(btnCustomer);
            pnlSidebar.Controls.Add(btnItems);
            pnlSidebar.Controls.Add(btnPOS);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 0);
            pnlSidebar.Margin = new Padding(3, 4, 3, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(229, 600);
            pnlSidebar.TabIndex = 0;
            pnlSidebar.Paint += pnlSidebar_Paint;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(39, 459);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(152, 31);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(39, 400);
            btnReport.Margin = new Padding(3, 4, 3, 4);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(152, 31);
            btnReport.TabIndex = 4;
            btnReport.Text = "Sales Report";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnItemSales
            // 
            btnItemSales.Location = new Point(39, 344);
            btnItemSales.Margin = new Padding(3, 4, 3, 4);
            btnItemSales.Name = "btnItemSales";
            btnItemSales.Size = new Size(152, 31);
            btnItemSales.TabIndex = 3;
            btnItemSales.Tag = "";
            btnItemSales.Text = "Item Sales";
            btnItemSales.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            btnCustomer.Location = new Point(39, 288);
            btnCustomer.Margin = new Padding(3, 4, 3, 4);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(152, 31);
            btnCustomer.TabIndex = 2;
            btnCustomer.Text = "Customer History";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnItems
            // 
            btnItems.Location = new Point(39, 229);
            btnItems.Margin = new Padding(3, 4, 3, 4);
            btnItems.Name = "btnItems";
            btnItems.Size = new Size(152, 31);
            btnItems.TabIndex = 1;
            btnItems.Text = "Items";
            btnItems.UseVisualStyleBackColor = true;
            // 
            // btnPOS
            // 
            btnPOS.Location = new Point(39, 173);
            btnPOS.Margin = new Padding(3, 4, 3, 4);
            btnPOS.Name = "btnPOS";
            btnPOS.Size = new Size(152, 31);
            btnPOS.TabIndex = 0;
            btnPOS.Text = "POS";
            btnPOS.UseVisualStyleBackColor = true;
            btnPOS.Click += btnPOS_Click;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.White;
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(229, 0);
            pnlContent.Margin = new Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(685, 600);
            pnlContent.TabIndex = 1;
            // 
            // sidebarTimer
            // 
            sidebarTimer.Interval = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            pnlSidebar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSidebar;
        private Panel pnlContent;
        private Button btnLogout;
        private Button btnReport;
        private Button btnItemSales;
        private Button btnCustomer;
        private Button btnItems;
        private Button btnPOS;
        private System.Windows.Forms.Timer sidebarTimer;
    }
}