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

namespace TheMatchaClub.Winforms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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
