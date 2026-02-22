using System.Runtime.InteropServices;
using TheMatchaClub.Application.Services;
using TheMatchaClub.Winforms.Helpers;
using TheMatchaClub.WinForms.Helpers;

namespace TheMatchaClub.Winforms
{
    public partial class AdminSetupForm : Form
    {
       
        private Panel strengthBar;

        public AdminSetupForm()
        {
            InitializeComponent();
            this.Load += (s, e) => CreateSetupUI();
        }

        private void CreateSetupUI()
        {
           
            int rightSectionCenter = this.Width - 230;
            int sectionWidth = 320;
            int startX = rightSectionCenter - (sectionWidth / 2);
            int currentY = 100; 
            Color primaryGreen = Color.FromArgb(46, 125, 50);

          
            Label lblHeader = new Label
            {
                Text = "Admin Setup",
                Font = new Font("Century Gothic", 22, FontStyle.Bold),
                ForeColor = primaryGreen,
                BackColor = Color.Transparent, 
                Size = new Size(sectionWidth, 50),
                Location = new Point(startX, currentY),
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(lblHeader);
            lblHeader.BringToFront(); 
            currentY += 80;

           
            TextBox[] myFields = { txtUsername, txtPassword, txtConfirm };
            string[] fieldNames = { "Username", "Password", "Confirm Password" };

            for (int i = 0; i < myFields.Length; i++)
            {
              
                Label lbl = new Label
                {
                    Text = fieldNames[i],
                    Font = new Font("Segoe UI Semibold", 10),
                    ForeColor = primaryGreen,
                    BackColor = Color.Transparent, 
                    Location = new Point(startX, currentY),
                    AutoSize = true
                };
                this.Controls.Add(lbl);
                lbl.BringToFront();
                currentY += 25;

               
                Panel container = new Panel
                {
                    Size = new Size(sectionWidth, 45),
                    Location = new Point(startX, currentY),
                    BackColor = Color.White
                };
                this.Controls.Add(container);
                container.BringToFront();
                UIStyleHelper.ApplyMatchaStyle(container, 20);

               
                myFields[i].Parent = container;
                myFields[i].BorderStyle = BorderStyle.None;
                myFields[i].Location = new Point(15, 12);
                myFields[i].Width = sectionWidth - 60; 
                myFields[i].Font = new Font("Segoe UI", 11);

               
                if (fieldNames[i].Contains("Password")) AddEyeToggle(container, myFields[i]);
                if (fieldNames[i] == "Password") AddStrengthIndicator(myFields[i], startX, currentY + 45, sectionWidth);

                currentY += 75;
            }

         
            btnCreate.Size = new Size(sectionWidth, 50);
            btnCreate.Location = new Point(startX, currentY);
            btnCreate.BackColor = primaryGreen;
            btnCreate.ForeColor = Color.White;
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.FlatAppearance.BorderSize = 0;
            btnCreate.BringToFront();
            UIStyleHelper.ApplyMatchaStyle(btnCreate, 20);
        }

      

        private void AddEyeToggle(Panel parent, TextBox box)
        {
            Label lblToggle = new Label
            {
                Text = "👁",
                Cursor = Cursors.Hand,
                ForeColor = Color.Gray,
                Size = new Size(30, 30),
                Location = new Point(parent.Width - 35, 8),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 12)
            };

            lblToggle.Click += (s, e) => {
                box.UseSystemPasswordChar = !box.UseSystemPasswordChar;
                lblToggle.ForeColor = box.UseSystemPasswordChar ? Color.Gray : Color.FromArgb(46, 125, 50);
            };

            parent.Controls.Add(lblToggle);
        }

        private void AddStrengthIndicator(TextBox box, int startX, int currentY, int width)
        {
          
            Panel barBg = new Panel
            {
                Size = new Size(width, 4),
                Location = new Point(startX, currentY - 15),
                BackColor = Color.FromArgb(200, 200, 200)
            };
            this.Controls.Add(barBg);

          
            Panel strengthBar = new Panel { Size = new Size(0, 4), BackColor = Color.Red };
            barBg.Controls.Add(strengthBar);

            box.TextChanged += (s, e) => {
                int score = 0;
                if (box.Text.Length >= 8) score++;
                if (System.Text.RegularExpressions.Regex.IsMatch(box.Text, @"[A-Z]")) score++;
                if (System.Text.RegularExpressions.Regex.IsMatch(box.Text, @"[0-9]")) score++;
                if (System.Text.RegularExpressions.Regex.IsMatch(box.Text, @"[^a-zA-Z0-9]")) score++;

                strengthBar.Width = (width / 4) * score;
                strengthBar.BackColor = score <= 1 ? Color.Red : score == 2 ? Color.Orange : Color.FromArgb(46, 125, 50);
            };
        }
     

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirm.Text))
            {
                MessageBox.Show("All fields are required.");
                return;
            }

            if (txtPassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            try
            {
                using var context = DbContextHelper.Create();
                var auth = new AuthService(context);

                await auth.CreateAdminAsync(txtUsername.Text, txtPassword.Text);

                MessageBox.Show("Admin created successfully.");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}