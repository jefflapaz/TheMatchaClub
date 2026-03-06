using CuoreUI.Controls;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheMatchaClub.Application.Services;
using TheMatchaClub.Infrastructure;
using TheMatchaClub.Winforms;
using TheMatchaClub.Winforms.Properties; // for MainForm

namespace TheMatchaClub.Winforms
{
    public partial class AdminSetupForm : Form
    {
        private readonly AuthService _authService;
      
        public AdminSetupForm()
        {
            InitializeComponent();

            var userManager = IdentityHelper.GetUserManager();
            _authService = new AuthService(userManager);

            SetupPasswordFields();

            // Wire up events
            txtPassword.TextChanged += TxtPassword_ContentChanged;
        }

        private void SetupPasswordFields()
        {
            txtPassword.PasswordChar = true;
            txtConfirm.PasswordChar = true;

            btnShowPassword.Image = Properties.Resources.eye_open;
            btnShowConfirm.Image = Properties.Resources.eye_open;

            lblStatus.Text = "Waiting for input...";
            lblStatus.ForeColor = Color.Gray;
        }

        private (string Message, Color StatusColor) GetPasswordStrength(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return ("Waiting for input...", Color.Gray);

            int score = 0;
            if (password.Length >= 8) score++;
            if (password.Length >= 12) score++;
            if (password.Any(char.IsUpper)) score++;
            if (password.Any(char.IsLower)) score++;
            if (password.Any(char.IsDigit)) score++;
            if (password.Any(ch => !char.IsLetterOrDigit(ch))) score++;

            return score switch
            {
                <= 2 => ("Weak", Color.FromArgb(231, 76, 60)),     // Flat Red
                3 or 4 => ("Medium", Color.FromArgb(230, 126, 34)), // Flat Orange
                5 => ("Strong", Color.FromArgb(46, 204, 113)),     // Flat Green
                _ => ("Very Strong", Color.FromArgb(39, 174, 96))   // Dark Green
            };
        }

        private void UpdateStrengthUI(string password)
        {
            var (message, statusColor) = GetPasswordStrength(password);

            // Apply to CuoreUI Label
            lblStatus.Text = message;
            lblStatus.ForeColor = statusColor;

            // Standard WinForms refresh to force the custom UI to repaint the text
            lblStatus.Invalidate();
            lblStatus.Update();

        }

        private void TxtPassword_ContentChanged(object? sender, EventArgs e)
        {
            var result = GetPasswordStrength(txtPassword.Text);
            lblStatus.Text = result.Message;
            lblStatus.ForeColor = result.StatusColor;
            UpdateStrengthUI(txtPassword.Text);
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            try
            {
                ToggleUI(false);
                await _authService.CreateAdminAsync("admin", txtPassword.Text);

                MessageBox.Show("Admin account created successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ToggleUI(true);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("Passwords must match and cannot be empty.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var strength = GetPasswordStrength(txtPassword.Text);
            if (txtPassword.Text.Length < 8 || strength.Message == "Weak")
            {
                MessageBox.Show("Password is too weak. Please use at least 8 characters with mixed types.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ToggleUI(bool enabled)
        {
            btnCreate.Enabled = enabled;
            txtPassword.Enabled = enabled;
            txtConfirm.Enabled = enabled;
            btnShowPassword.Enabled = enabled;
            btnShowConfirm.Enabled = enabled;
        }


        private void lblStatus_Load(object sender, EventArgs e)
        {

        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            ToggleVisibility(txtPassword, btnShowPassword);
        }

        private void btnShowConfirm_Click(object sender, EventArgs e)
        {
            ToggleVisibility(txtConfirm, btnShowConfirm);
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
                    toggleButton.Image = Properties.Resources.eye_close;
                }
                else
                {
                    toggleButton.Image = Properties.Resources.eye_open;
                }
            }
            catch (Exception ex)
            {
                // Debugging tip: If 'Content' isn't the right property, this will tell you.
                Console.WriteLine("CuoreUI Property Error: " + ex.Message);
            }
        }

      
    }
}