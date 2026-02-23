using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheMatchaClub.Application.Services;
using TheMatchaClub.Infrastructure;
using TheMatchaClub.WinForms.Helpers;
using System.Drawing.Drawing2D;



namespace TheMatchaClub.Winforms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            CreateGlassPanel();
        }

        private void CreateGlassPanel()
        {
            this.BackColor = Color.FromArgb(232, 245, 233);

            int sectionWidth = 320;
            int sectionX = this.Width - 460 + (420 - sectionWidth) / 2;
            int startY = 140;

            Color primaryGreen = Color.FromArgb(46, 125, 50);
            Color softGreen = Color.FromArgb(56, 142, 60);

          
            Panel rightContainer = new Panel();
            rightContainer.Size = new Size(sectionWidth, this.Height);
            rightContainer.Location = new Point(sectionX, 0);
            rightContainer.BackColor = Color.Transparent;
            this.Controls.Add(rightContainer);

            int currentY = startY;

          
            Label lblTitle = new Label();
            lblTitle.Text = "Welcome to";
            lblTitle.Font = new Font("Century Gothic", 14, FontStyle.Regular);
            lblTitle.ForeColor = primaryGreen;
            lblTitle.Width = sectionWidth;
            lblTitle.Height = 30; 
            lblTitle.AutoSize = false;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Location = new Point(0, currentY);
            rightContainer.Controls.Add(lblTitle);

            currentY += lblTitle.Height + 5; 

           
            Label lblTitle1 = new Label();
            lblTitle1.Text = "The Matcha Club ☁";
            lblTitle1.Font = new Font("Century Gothic", 18, FontStyle.Bold);
            lblTitle1.ForeColor = primaryGreen;
            lblTitle1.Width = sectionWidth;
            lblTitle1.Height = 40;
            lblTitle1.AutoSize = false;
            lblTitle1.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle1.Location = new Point(0, currentY);
            rightContainer.Controls.Add(lblTitle1);

            currentY += lblTitle1.Height + 20;

         
            Label lblSub = new Label();
            lblSub.Text = "Login to continue";
            lblSub.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblSub.ForeColor = softGreen;
            lblSub.Width = sectionWidth;
            lblSub.AutoSize = false;
            lblSub.TextAlign = ContentAlignment.MiddleCenter;
            lblSub.Location = new Point(0, currentY);
            rightContainer.Controls.Add(lblSub);

            currentY += lblSub.Height + 40; 

          
            Label lblPassword = new Label();
            lblPassword.Text = "Password";
            lblPassword.Font = new Font("Segoe UI Semibold", 10); 
            lblPassword.ForeColor = primaryGreen;
            lblPassword.Width = sectionWidth;
            lblPassword.AutoSize = false;
            lblPassword.TextAlign = ContentAlignment.MiddleLeft; 
            lblPassword.Location = new Point(0, currentY);
            rightContainer.Controls.Add(lblPassword);

            currentY += lblPassword.Height + 8;

          
            Panel txtContainer = new Panel();
            txtContainer.Size = new Size(sectionWidth, 45);
            txtContainer.Location = new Point(0, currentY);
            txtContainer.BackColor = Color.White;
            MakeRounded(txtContainer, 20);
            rightContainer.Controls.Add(txtContainer);

         
            Label lblToggle = new Label();
            lblToggle.Text = "👁"; 
            lblToggle.Font = new Font("Segoe UI", 12);
            lblToggle.ForeColor = Color.Gray;
            lblToggle.Size = new Size(30, 30);
            lblToggle.Location = new Point(txtContainer.Width - 35, 8);
            lblToggle.Cursor = Cursors.Hand;
            lblToggle.TextAlign = ContentAlignment.MiddleCenter;
            txtContainer.Controls.Add(lblToggle);

          
            txtPassword.Parent = txtContainer;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 11);
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Width = sectionWidth - 50;    
            txtPassword.Location = new Point(15, 12);
            txtPassword.BackColor = Color.White;

           
            lblToggle.Click += (s, e) => {
                txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
                lblToggle.ForeColor = txtPassword.UseSystemPasswordChar ? Color.Gray : primaryGreen;
            };

            currentY += txtContainer.Height + 30;

          
            btnLogin.Size = new Size(sectionWidth, 48);
            btnLogin.Location = new Point(0, currentY);
            btnLogin.Text = "Login";
            btnLogin.Font = new Font("Segoe UI Semibold", 11, FontStyle.Bold);
            StyleMatchaButton(btnLogin);
            rightContainer.Controls.Add(btnLogin);

            currentY += btnLogin.Height + 15;

          
            btnExit.Size = new Size(sectionWidth, 42);
            btnExit.Location = new Point(0, currentY);
            btnExit.Text = "Exit";
            btnExit.Font = new Font("Segoe UI", 10);
            StyleExitButton(btnExit);
            rightContainer.Controls.Add(btnExit);
        }
        private void MakeRounded(Control control, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(control.Width - radius, 0, radius, radius), 270, 90);
            path.AddArc(new Rectangle(control.Width - radius, control.Height - radius, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, control.Height - radius, radius, radius), 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }
        private void StyleMatchaButton(Button btn)
        {
          
            Color primaryGreen = Color.FromArgb(46, 125, 50);  
            Color hoverGreen = Color.FromArgb(76, 175, 80);    
            Color textWhite = Color.White;

          
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = primaryGreen;
            btn.ForeColor = textWhite;
            btn.Cursor = Cursors.Hand;

          
            MakeRounded(btn, 20);

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = hoverGreen;
             
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = primaryGreen;
           
            };
        }
        private void StyleExitButton(Button btn)
        {
            Color primaryGreen = Color.FromArgb(46, 125, 50);
            Color softBackground = Color.FromArgb(232, 245, 233);

            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.Transparent; 
            btn.ForeColor = primaryGreen;
            btn.FlatAppearance.BorderColor = primaryGreen;
            btn.FlatAppearance.BorderSize = 1;
            btn.Cursor = Cursors.Hand;

            MakeRounded(btn, 20);

          
            btn.MouseEnter += (s, e) => {
                btn.BackColor = Color.FromArgb(200, 230, 201); 
            };
            btn.MouseLeave += (s, e) => {
                btn.BackColor = Color.Transparent;
            };
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter password.");
                return;
            }
            try
            {
                var userManager = IdentityHelper.GetUserManager();
                var authService = new AuthService(userManager);

                var success = await authService.LoginAsync("admin", txtPassword.Text);

                if (!success)
                {
                    MessageBox.Show("Invalid password.");
                    return;
                }

                MessageBox.Show("Login successful.");

                this.Hide();

                var main = new MainForm();
                main.ShowDialog();

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            var auth = new AuthService(IdentityHelper.GetUserManager());

            if (!await auth.AdminExistsAsync())
            {
                using var setup = new AdminSetupForm();
                setup.ShowDialog();
            }
        }
    }
}
