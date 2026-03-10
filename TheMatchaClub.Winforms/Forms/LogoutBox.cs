using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheMatchaClub.Winforms.Forms
{
    public partial class LogoutBox : UserControl
    {
        public LogoutBox()
        {
            InitializeComponent();

            // Wire up the events manually if they aren't set in the Designer
            this.btnLogoutOnly.Click += btnLogoutOnly_Click;
            this.btnExitApp.Click += btnExitApp_Click;
            this.btnCancel.Click += btnCancel_Click;
        }

        /* private void btnLogoutOnly_Click(object sender, EventArgs e)
         {
             new LoginForm().Show();

             // 'this' is the UserControl
             // FindForm() is the popup dialog
             // .Owner is the MainForm
             Form popup = this.FindForm();
             Form mainForm = popup?.Owner;

             popup?.Close();
             mainForm?.Close();
         }
         */

        private void btnLogoutOnly_Click(object sender, EventArgs e)
        {
            // 1. Find the MainForm first
            var mainForm = global::System.Windows.Forms.Application.OpenForms
                .OfType<MainForm>()
                .FirstOrDefault();

            // 2. Create the Login Form
            LoginForm login = new LoginForm();

            // Ensure if they close the login form, the whole process ends
            login.FormClosed += (s, args) => global::System.Windows.Forms.Application.Exit();

            // 3. Hide the Main Form and Show the Login Form
            if (mainForm != null)
            {
                mainForm.Hide();
                login.Show();
            }
            else
            {
                // Fallback: if MainForm isn't found, just show login anyway
                login.Show();
            }

            // 4. Close the logout popup itself
            // We use BeginInvoke to ensure the popup closes AFTER the other forms shift
            this.FindForm()?.Close();
        }

        private void btnExitApp_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            System.Windows.Forms.Application.Exit();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close(); // Just closes the popup
        }
    }
}
