using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheMatchaClub.Winforms.Forms
{
    public partial class TestDeleteWhenPublish : Form
    {
        public TestDeleteWhenPublish()
        {
            InitializeComponent();
        }



            private void Guna2Button1_MouseMove(object sender, MouseEventArgs e)
        {
            var button = (Guna.UI2.WinForms.Guna2Button)sender;

            // Create a bitmap to draw our custom glow
            Bitmap bmp = new Bitmap(button.Width, button.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Create the "Spotlight" effect
                using (GraphicsPath path = new GraphicsPath())
                {
                    path.AddEllipse(e.X - 100, e.Y - 100, 200, 200); // 200 is the size of the glow
                    using (PathGradientBrush pgb = new PathGradientBrush(path))
                    {
                        // The center is bright, the edges are the button's base color
                        pgb.CenterColor = Color.FromArgb(60, Color.White); // Subtle white glow
                        pgb.SurroundColors = new Color[] { Color.FromArgb(94, 148, 255) }; // Your base FillColor

                        g.FillRectangle(new SolidBrush(button.FillColor), button.ClientRectangle);
                        g.FillPath(pgb, path);
                    }
                }
            }
            // Apply the generated image as the button's background
            button.Image = bmp;
            button.ImageAlign = HorizontalAlignment.Center;
        }

        private void Guna2Button1_MouseLeave(object sender, EventArgs e)
        {
            var button = (Guna.UI2.WinForms.Guna2Button)sender;
            button.Image = null; // Remove the glow when mouse leaves
        }
    }
}
