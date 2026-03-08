using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheMatchaClub.Application.Services;
using TheMatchaClub.Domain.Entities;
using TheMatchaClub.Winforms.Forms;
using TheMatchaClub.WinForms.Helpers;

namespace TheMatchaClub.Winforms
{
    public partial class ItemsControl : UserControl
    {
        public ItemsControl()
        {
            InitializeComponent();
            EnableDoubleBuffering(flpItems);
            this.Load += ItemsControl_Load;
        }

        private async void ItemsControl_Load(object? sender, EventArgs e)
        {
            await LoadItems();
        }

        private async Task LoadItems()
        {
            try
            {
                flpItems.SuspendLayout();
                flpItems.Controls.Clear();

                using var context = DbContextHelper.Create();
                var itemService = new ItemService(context);

                var items = await itemService.GetAllAsync();

                if (items == null || !items.Any())
                {
                    MyUniversalBox.Show("Your inventory is currently empty. Click 'Add' to create your first item!", "Inventory Empty", isError: false);
                    flpItems.ResumeLayout();
                    return;
                }

                var grouped = items
                    .OrderBy(x => x.Category.Name)
                    .GroupBy(x => x.Category.Name);

                foreach (var group in grouped)
                {
                    // CATEGORY TITLE
                    Label lblCategory = new Label
                    {
                        Text = group.Key,
                        Font = new Font("Segoe UI", 13, FontStyle.Bold),
                        ForeColor = Color.FromArgb(53, 108, 27),
                        AutoSize = true,
                        Margin = new Padding(10, 20, 10, 5)
                    };

                    flpItems.Controls.Add(lblCategory);

                    // CATEGORY ITEM GRID
                    FlowLayoutPanel categoryItems = new FlowLayoutPanel
                    {
                        AutoSize = true,
                        WrapContents = true,
                        FlowDirection = FlowDirection.LeftToRight,
                        Margin = new Padding(10),
                        Padding = new Padding(5)
                    };

                    foreach (var item in group)
                    {
                        categoryItems.Controls.Add(CreateItemCard(item));
                    }

                    flpItems.Controls.Add(categoryItems);
                }
            }
            catch (Exception ex)
            {
                MyUniversalBox.Show($"Failed to load menu items: {ex.Message}", "System Error", isError: true);
            }
            finally
            {
                flpItems.ResumeLayout();
            }
        }

        private Control CreateItemCard(Item item)
        {
            Panel card = new Panel
            {
                Width = 140,
                Height = 150,
                BackColor = Color.FromArgb(245, 245, 221),
                Margin = new Padding(15),
                Tag = item,
                Cursor = Cursors.Hand
            };

            card.Paint += (s, e) =>
            {
                var rect = card.ClientRectangle;
                rect.Width -= 1;
                rect.Height -= 1;

                using var path = RoundedRect(rect, 12);
                card.Region = new Region(path);

                using var pen = new Pen(Color.FromArgb(200, 200, 200));
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            };

            PictureBox pic = new PictureBox
            {
                Width = 90,
                Height = 70,
                Top = 10,
                Left = 25,
                SizeMode = PictureBoxSizeMode.Zoom,
                Tag = item,
                Cursor = Cursors.Hand
            };

            if (!string.IsNullOrEmpty(item.ImagePath))
            {
                pic.Image = LoadImage(item.ImagePath);
            }

            Label lblName = new Label
            {
                Text = item.Name,
                Top = 85,
                Width = 140,
                Height = 20,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 9),
                Tag = item,
                Cursor = Cursors.Hand
            };

            Label lblPrice = new Label
            {
                Text = $"₱{item.Price}",
                Top = 105,
                Width = 140,
                Height = 20,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.FromArgb(53, 108, 27),
                TextAlign = ContentAlignment.MiddleCenter,
                Tag = item,
                Cursor = Cursors.Hand
            };

            card.Controls.Add(pic);
            card.Controls.Add(lblName);
            card.Controls.Add(lblPrice);

            // Hook up events
            card.Click += ItemButton_Click;
            pic.Click += ItemButton_Click;
            lblName.Click += ItemButton_Click;
            lblPrice.Click += ItemButton_Click;

            void HoverOn(object? s, EventArgs e) => card.BackColor = Color.FromArgb(220, 235, 200);
            void HoverOff(object? s, EventArgs e) => card.BackColor = Color.FromArgb(245, 245, 221);

            card.MouseEnter += HoverOn; card.MouseLeave += HoverOff;
            pic.MouseEnter += HoverOn; pic.MouseLeave += HoverOff;
            lblName.MouseEnter += HoverOn; lblName.MouseLeave += HoverOff;
            lblPrice.MouseEnter += HoverOn; lblPrice.MouseLeave += HoverOff;

            return card;
        }

        private Image? LoadImage(string path)
        {
            try
            {
                if (!File.Exists(path)) return null;
                byte[] bytes = File.ReadAllBytes(path);
                using MemoryStream ms = new MemoryStream(bytes);
                return Image.FromStream(ms);
            }
            catch { return null; }
        }

        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            var path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
            path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
            path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void EnableDoubleBuffering(Control control)
        {
            var prop = typeof(Control).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
            prop?.SetValue(control, true, null);
        }

        private async void ItemButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Control ctrl || ctrl.Tag is not Item item)
                return;

            using var detail = new ItemDetailForm(item);
            if (detail.ShowDialog() == DialogResult.OK)
                await LoadItems();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            using var form = new AddItemForm();
            if (form.ShowDialog() == DialogResult.OK)
                await LoadItems();
        }
    }
}