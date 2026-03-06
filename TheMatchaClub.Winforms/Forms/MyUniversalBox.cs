using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheMatchaClub.Winforms.Forms
{
    public partial class MyUniversalBox : Form
    {
        private string fullText;
        private int counter = 0;

        public MyUniversalBox(string message)
        {
            InitializeComponent();
            fullText = message;
            lblMessage.Text = ""; // Keep it empty for the typewriter to start
            typeTimer.Start();
        }

        public static DialogResult Show(string message, string title = "Notification", bool isError = false)
        {
            using (var msgBox = new MyUniversalBox(message))
            {
                msgBox.Text = title;
                msgBox.StartPosition = FormStartPosition.CenterParent; // Important!

                // If you chose FormBorderStyle.None, 
                // give it a nice border color so it doesn't blend into the background
                msgBox.BackColor = isError ? Color.FromArgb(255, 230, 230) : Color.White;

                msgBox.typeTimer.Start();
                return msgBox.ShowDialog();
            }
        }

        private void typeTimer_Tick(object sender, EventArgs e)
        {
            if (counter < fullText.Length)
            {
                lblMessage.Text += fullText[counter];
                counter++;

                // Optional: Play a tiny "click" sound for maximum Aristotle vibes
                // Console.Beep(500, 10); 
            }
            else
            {
                typeTimer.Stop(); // Stop when the message is complete
            }
        }
    }
}
