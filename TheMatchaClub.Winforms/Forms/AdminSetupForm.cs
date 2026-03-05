using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheMatchaClub.Application.Services;
using TheMatchaClub.Infrastructure;
using TheMatchaClub.Winforms; // for MainForm

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

            txtPassword.TextChanged += TxtPassword_ContentChanged;
        }

        private (bool IsValid, string Message, Color StatusColor) ValidatePassword(string password)
        {
            if (password.Length < 8)
                return (false, "Password must be at least 8 characters.", Color.Red);

            if (!password.Any(char.IsUpper))
                return (false, "Must contain at least one uppercase letter.", Color.OrangeRed);

            if (!password.Any(char.IsLower))
                return (false, "Must contain at least one lowercase letter.", Color.OrangeRed);

            if (!password.Any(char.IsDigit))
                return (false, "Must contain at least one number.", Color.DarkOrange);

            if (!password.Any(ch => !char.IsLetterOrDigit(ch)))
                return (false, "Must contain at least one special character.", Color.DarkOrange);

            return (true, "Strong password ✔", Color.Green);
        }

        private (string Message, Color StatusColor) GetPasswordStrength(string password)
        {
            if (string.IsNullOrEmpty(password))
                return ("", Color.Black);

            int score = 0;

            if (password.Length >= 8) score++;
            if (password.Length >= 12) score++; 
            if (password.Any(char.IsUpper)) score++;
            if (password.Any(char.IsLower)) score++;
            if (password.Any(char.IsDigit)) score++;
            if (password.Any(ch => !char.IsLetterOrDigit(ch))) score++;

            // Determine status based on score
            return score switch
            {
                <= 2 => ("Very Weak", Color.Red),
                3 => ("Weak", Color.OrangeRed),
                4 => ("Medium", Color.Goldenrod),
                5 => ("Strong", Color.Green),
                >= 6 => ("Very Strong", Color.DarkGreen),
            };
        }

        private void TxtPassword_ContentChanged(object? sender, EventArgs e)
        {
            var result = GetPasswordStrength(txtPassword.Text);
            lblStatus.Text = result.Message;
            lblStatus.ForeColor = result.StatusColor;
            lblStatus.Refresh();
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            try
            {
                ToggleUI(false);

                await _authService.CreateAdminAsync("admin", txtPassword.Text);

                MessageBox.Show("Admin account created successfully.",
                                "Success",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            finally
            {
                ToggleUI(true);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtConfirm.Text))
            {
                MessageBox.Show("All fields are required.",
                                "Validation",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            if (txtPassword.Text != txtConfirm.Text)
            {
                MessageBox.Show("Passwords do not match.",
                                "Validation",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            var result = ValidatePassword(txtPassword.Text);
            if (!result.IsValid)
            {
                MessageBox.Show(result.Message,
                                "Weak Password",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ToggleUI(bool enabled)
        {
            btnCreate.Enabled = enabled;
            txtPassword.Enabled = enabled;
            txtConfirm.Enabled = enabled;
        }

        private void lblStatus_Load(object sender, EventArgs e)
        {

        }
    }
}