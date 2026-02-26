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
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text) ||
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
                // Force username to "admin"
                await _authService.CreateAdminAsync("admin", txtPassword.Text);

                MessageBox.Show("Admin account created successfully.");

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