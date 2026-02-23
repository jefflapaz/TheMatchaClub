using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace TheMatchaClub.Winforms.Helpers
{
    public static class UIStyleHelper
    {
       
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public static void ApplyMatchaStyle(Control ctrl, int radius)
        {
            IntPtr ptr = CreateRoundRectRgn(0, 0, ctrl.Width, ctrl.Height, radius, radius);
            ctrl.Region = Region.FromHrgn(ptr);
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn1(
 int nLeftRect,
 int nTopRect,
 int nRightRect,
 int nBottomRect,
 int nWidthEllipse,
 int nHeightEllipse);


    }

}
