using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheMatchaClub.Infrastructure.Services;
using TheMatchaClub.WinForms.Helpers;


namespace TheMatchaClub.Winforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadSession();
        }

        private async void btnEndSession_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Are you sure you want to end this session?",
                "Confirm",
                MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using var context = DbContextHelper.Create();
                var sessionService = new SessionService(context);

                await sessionService.EndSessionAsync();

                MessageBox.Show("Session ended.");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void LoadSession()
        {
            using var context = DbContextHelper.Create();
            var service = new SessionService(context);

            var session = await service.GetActiveSessionAsync();
            if (session != null)
                lblSession.Text = $"Active Session: {session.SessionName}";
        }

    }
}
