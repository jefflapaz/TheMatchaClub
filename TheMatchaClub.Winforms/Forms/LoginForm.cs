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
            btnShowPassword.Image = Properties.Resources.eyes_open;

        }

        private void ToggleVisibility(cuiTextBox targetTextBox, cuiButton toggleButton)
        {
            try
            {
                // 1. Get the current state from the internal CuoreUI textbox
                bool isCurrentlyHidden = targetTextBox.PasswordChar;

                // 2. Toggle the password visibility
                targetTextBox.PasswordChar = !isCurrentlyHidden;

                // 3. Switch the Image based on the NEW state
                // If it WAS hidden, we just revealed it, so show 'eye_closed' (the slash eye)
                // If it WAS visible, we just hid it, so show 'eye_open'
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
                // Debugging tip: If 'Content' isn't the right property, this will tell you.
                Console.WriteLine("CuoreUI Property Error: " + ex.Message);
            }
        }


        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                // Using your custom typewriter box for an empty field
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
                    // Error style (red theme if you set it up that way)
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
                // Exception handler using the universal box
                MyUniversalBox.Show($"A system error occurred: {ex.Message}", "Critical Error", isError: true);
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

        private void cuiLabel1_Load(object sender, EventArgs e)
        {

        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            ToggleVisibility(txtPassword, btnShowPassword);
        }
    }
}