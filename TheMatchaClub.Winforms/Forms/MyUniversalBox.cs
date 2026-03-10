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

        public MyUniversalBox(string message)
        {
            InitializeComponent();
            fullText = message;

            // Set the text instantly instead of leaving it empty
            lblMessage.Text = fullText;
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

                return msgBox.ShowDialog();
            }
        }
    }
}