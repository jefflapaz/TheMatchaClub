using CuoreUI.Controls;
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
using TheMatchaClub.Winforms.Forms;
using TheMatchaClub.WinForms.Helpers;

namespace TheMatchaClub.Winforms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            SetupPasswordFields();
        }

        private void SetupPasswordFields()
        {
            txtPassword.PasswordChar = true;
            // Ensure you have these images in your Resources
            btnShowPassword.Image = Properties.Resources.eyes_open;
        }

        private void ToggleVisibility(cuiTextBox targetTextBox, cuiButton toggleButton)
        {
            try
            {
                // 1. Get the current state
                bool isCurrentlyHidden = targetTextBox.PasswordChar;

                // 2. Toggle the password visibility
                targetTextBox.PasswordChar = !isCurrentlyHidden;

                // 3. Switch the Image based on the NEW state
                if (isCurrentlyHidden)
                {
                    toggleButton.Image = Properties.Resources.eye_closed;
                }
                else
                {
                    toggleButton.Image = Properties.Resources.eyes_open;
                }
            }
            catch (Exception ex)
            {
                // Using UniversalBox for internal UI errors
                MyUniversalBox.Show("UI Error: Unable to toggle password visibility.", "System Error", isError: true);
            }
        }


        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MyUniversalBox.Show("Please enter your password to proceed.", "Input Required", isError: false);
                return;
            }

            try
            {
                var userManager = IdentityHelper.GetUserManager();
                var authService = new AuthService(userManager);

                var success = await authService.LoginAsync("admin", txtPassword.Text);

                if (!success)
                {
                    MyUniversalBox.Show("The password you entered is incorrect. Please try again.", "Auth Failed", isError: true);
                    return;
                }

                // Success message
                MyUniversalBox.Show("Login successful! Welcome back to The Matcha Club.", "Success", isError: false);

                this.Hide();

                var main = new MainForm();
                main.ShowDialog();

                this.Close();
            }
            catch (Exception ex)
            {
                MyUniversalBox.Show($"A system error occurred: {ex.Message}", "Critical Error", isError: true);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // You could even use MyUniversalBox here to ask "Are you sure?" 
            // but for now, we'll keep the direct exit.
            System.Windows.Forms.Application.Exit();
        }

        private async void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                var auth = new AuthService(IdentityHelper.GetUserManager());

                if (!await auth.AdminExistsAsync())
                {
                    MyUniversalBox.Show("No administrator account found. Redirecting to setup...", "First Run", isError: false);
                    using var setup = new AdminSetupForm();
                    setup.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MyUniversalBox.Show("Database connection failed. Please check if the server is running.", "Connection Error", isError: true);
            }
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            ToggleVisibility(txtPassword, btnShowPassword);
        }

        // Cleaned up unused empty events
    }
}