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
using TheMatchaClub.WinForms.Helpers;


namespace TheMatchaClub.Winforms
{
    public partial class StartSessionForm : Form
    {
        public StartSessionForm()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSession.Text))
            {
                MessageBox.Show("Please enter session name.");
                return;
            }

            try
            {
                using var context = DbContextHelper.Create();
                var sessionService = new SessionService(context);

                await sessionService.StartSessionAsync(txtSession.Text);

                MessageBox.Show("Session started.");

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
