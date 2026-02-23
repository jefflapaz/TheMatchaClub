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
using TheMatchaClub.Winforms.Helpers;
using TheMatchaClub.WinForms.Helpers;


namespace TheMatchaClub.Winforms
{
    public partial class StartSessionForm : Form
    {
        public StartSessionForm()
        {
            InitializeComponent();
            // Set the form to fill the screen or a fixed large size
            this.Size = new Size(1000, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Load += (s, e) => CreateSessionUI();
        }

        private void CreateSessionUI()
        {
            // 1. Form Background
            this.BackColor = Color.White;
            Color cardColor = Color.FromArgb(232, 245, 233); // Soft Matcha
            Color primaryGreen = Color.FromArgb(46, 125, 50);

            // 2. CREATE THE MAIN CARD (Floating Panel)
            Panel mainCard = new Panel();
            mainCard.Size = new Size(450, 350);
            mainCard.BackColor = cardColor;
            // Center the card in the form
            mainCard.Location = new Point((this.Width - mainCard.Width) / 2,
                                          (this.Height - mainCard.Height) / 2);
            this.Controls.Add(mainCard);
            UIStyleHelper.ApplyMatchaStyle(mainCard, 30); // Extra rounded for the card look

            int currentY = 40;

            // 3. TITLE: "Start Your Day!"
            Label lblTitle = new Label
            {
                Text = "Start Your Day!",
                Font = new Font("Century Gothic", 18, FontStyle.Bold),
                ForeColor = primaryGreen,
                BackColor = Color.Transparent,
                Size = new Size(mainCard.Width, 40),
                Location = new Point(0, currentY),
                TextAlign = ContentAlignment.MiddleCenter
            };
            mainCard.Controls.Add(lblTitle);
            currentY += 70;

            // 4. INPUT CONTAINER (The gray-ish box in your picture)
            Panel inputContainer = new Panel
            {
                Size = new Size(350, 50),
                Location = new Point((mainCard.Width - 350) / 2, currentY),
                BackColor = Color.FromArgb(210, 210, 210) // Light Gray/Silver
            };
            mainCard.Controls.Add(inputContainer);
            UIStyleHelper.ApplyMatchaStyle(inputContainer, 20);

            // RE-PARENT YOUR EXISTING TEXTBOX
            txtSession.Parent = inputContainer;
            txtSession.BorderStyle = BorderStyle.None;
            txtSession.BackColor = Color.FromArgb(210, 210, 210);
            txtSession.Font = new Font("Segoe UI", 12);
            txtSession.Size = new Size(310, 30);
            txtSession.Location = new Point(20, 13);
            txtSession.PlaceholderText = "Enter Session Name..."; // Optional modern touch

            currentY += 100;

            // 5. THE START BUTTON
            btnStart.Size = new Size(120, 40);
            btnStart.Location = new Point((mainCard.Width - 120) / 2, currentY);
            btnStart.Text = "Start Day";
            btnStart.BackColor = Color.FromArgb(129, 199, 132); // Brighter matcha green
            btnStart.ForeColor = Color.White;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.Font = new Font("Segoe UI Semibold", 10);
            UIStyleHelper.ApplyMatchaStyle(btnStart, 20);

            // Re-linking the event just in case
            btnStart.Click -= btnStart_Click;
            btnStart.Click += btnStart_Click;
        }

        // --- Keep your database logic exactly as it was ---
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
