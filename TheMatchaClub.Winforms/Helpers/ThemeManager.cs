using CuoreUI.Controls;
using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace TheMatchaClub.WinForms.Helpers
{
    public static class ThemeManager
    {
        // Global Color Palette
        public static readonly Color LightBackground = Color.FromArgb(235, 250, 221);
        public static readonly Color DarkOlive = Color.FromArgb(45, 83, 26);
        public static readonly Color PrimaryGreen = Color.FromArgb(53, 108, 27);
        public static readonly Color LightGreen = Color.FromArgb(169, 209, 129);
        public static readonly Color AccentOrange = Color.FromArgb(255, 106, 0);
        public static readonly Color TextDarkGreen = Color.FromArgb(17, 47, 21);
        public static readonly Color TextWhite = Color.FromArgb(235, 250, 221);
        public static readonly Color GrayOutline = Color.FromArgb(64, 128, 128, 128);

        /// <summary>
        /// Recursively applies the defined theme colors to all controls to prevent 
        /// corruption and ensure consistency if properties are lost.
        /// </summary>
        public static void ApplyTheme(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                // Apply to CuoreUI TextBoxes
                if (control is cuiTextBox txt)
                {
                    txt.BackColor = Color.Transparent;
                    txt.BackgroundColor = LightBackground;
                    txt.FocusBackgroundColor = LightBackground;
                    txt.FocusOutlineColor = DarkOlive;
                    txt.ForeColor = TextDarkGreen;
                    txt.PlaceholderColor = TextDarkGreen;
                    txt.OutlineColor = Color.LemonChiffon; // As per existing design
                }
                // Apply to CuoreUI Buttons
                else if (control is cuiButton btn)
                {
                    btn.BackColor = Color.Transparent;

                    // If it's the exit button or a red button, we skip overwriting,
                    // but for standard buttons, we enforce the theme:
                    if (btn.Name.Contains("Exit") || btn.Name.Contains("Logout") || btn.Name.Contains("btnRemove") || btn.Name.Contains("btnCancel"))
                    {
                        // Maintain existing colors for destructive actions or specific buttons
                    }
                    else if (btn.Name.Contains("btnPOS") || btn.Name.Contains("btnItems") || btn.Name.Contains("btnCustomer") || btn.Name.Contains("btnItemSales") || btn.Name.Contains("btnReport"))
                    {
                        // Sidebar buttons
                        // These are handled dynamically in MainForm when clicked, so we just ensure base transparency
                        btn.BackColor = Color.Transparent;
                    }
                    else
                    {
                        // General Buttons (like Login)
                        btn.NormalBackground = Color.Transparent;
                        btn.NormalForeColor = TextWhite;
                        btn.HoverBackground = LightGreen;
                        btn.HoverForeColor = PrimaryGreen;
                        btn.PressedBackground = PrimaryGreen;
                        btn.PressedForeColor = LightGreen;
                    }
                }
                // Apply to CuoreUI Panels
                else if (control is cuiPanel panel)
                {
                    panel.BackColor = Color.Transparent;
                    if (panel.PanelColor == Color.Transparent || panel.PanelColor == Color.Empty)
                    {
                        // Keep transparent if intentionally transparent
                    }
                    else if (panel.Name.Contains("sidebar") || panel.Name.Contains("StartSession") || panel.Name == "cuiPanel1" && parent is UserControl)
                    {
                         // Standard panel colors
                    }
                }
                // Apply to standard Labels
                else if (control is Label lbl)
                {
                    lbl.BackColor = Color.Transparent;
                }
                // Apply to CuoreUI Labels
                else if (control is cuiLabel clbl)
                {
                    clbl.BackColor = Color.Transparent;
                }

                // Recursively apply to children
                if (control.HasChildren)
                {
                    ApplyTheme(control);
                }
            }
        }

        /// <summary>
        /// Hooks into form events to prevent the "white stuff" transparency bug 
        /// common with layered GDI+ controls on resize or focus changes.
        /// </summary>
        public static void EnableAntiCorruption(Form form)
        {
            form.Activated += (s, e) => ForceRedraw(form);
            form.ResizeEnd += (s, e) => ForceRedraw(form);
        }

        /// <summary>
        /// Forces a deep invalidation to restore any lost transparency pixels.
        /// </summary>
        public static void ForceRedraw(Control control)
        {
            control.SuspendLayout();
            
            // Invalidate the control and all its children to force a complete redraw
            control.Invalidate(true);
            control.Update();
            
            control.ResumeLayout(false);
        }
    }
}
