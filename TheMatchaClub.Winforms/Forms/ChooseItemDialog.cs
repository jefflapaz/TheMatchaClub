using Microsoft.EntityFrameworkCore;
using System.Drawing.Drawing2D;
using TheMatchaClub.Domain;
using TheMatchaClub.Domain.Entities;
using TheMatchaClub.WinForms.Helpers;

namespace TheMatchaClub.Winforms
{
    public partial class ChooseItemDialog : Form
    {
        public CartItem? SelectedItem { get; private set; }

        public ChooseItemDialog()
        {
            InitializeComponent();

            this.DoubleBuffered = true;

            flpItems.FlowDirection = FlowDirection.TopDown;
            flpItems.WrapContents = false;
            flpItems.AutoScroll = true;


            this.Load += ChooseItemDialog_Load;
        }

        private async void ChooseItemDialog_Load(object? sender, EventArgs e)
        {
            await LoadItems();
        }

        private async Task LoadItems()
        {
            using var context = DbContextHelper.Create();

            var items = await context.Items
                .Include(x => x.Category)
                .Where(x => x.IsActive)
                .ToListAsync();

            flpItems.SuspendLayout();
            flpItems.Controls.Clear();

            // ⭐ USUALS
            var usuals = items.Where(x => x.IsUsual).ToList();

            if (usuals.Any())
            {
                AddCategorySection("⭐ Usuals", usuals);
            }

            // GROUP BY CATEGORY
            var grouped = items
                .OrderBy(x => x.Category.Name)
                .GroupBy(x => x.Category.Name);

            foreach (var group in grouped)
            {
                AddCategorySection(group.Key, group.ToList());
            }

            flpItems.ResumeLayout();
        }
        private void AddCategorySection(string categoryName, List<Item> items)
        {
            Label lbl = new Label
            {
                Text = categoryName,
                Font = new Font("Segoe UI", 13, FontStyle.Bold),
                ForeColor = Color.FromArgb(53, 108, 27),
                AutoSize = true,
                Margin = new Padding(20, 20, 10, 5)
            };

            flpItems.Controls.Add(lbl);

            FlowLayoutPanel panel = new FlowLayoutPanel
            {
                Width = flpItems.ClientSize.Width - 40,
                AutoSize = true,
                WrapContents = true,
                FlowDirection = FlowDirection.LeftToRight,
                Margin = new Padding(20, 5, 20, 10),
                Padding = new Padding(10)
            };

            foreach (var item in items)
            {
                panel.Controls.Add(CreateItemCard(item));
            }

            flpItems.Controls.Add(panel);
        }
        private Control CreateItemCard(Item item)
        {
            Panel card = new Panel
            {
                Width = 120,
                Height = 135,
                BackColor = Color.FromArgb(245, 245, 221),
                Margin = new Padding(15),
                Tag = item,
                Cursor = Cursors.Hand
            };

            // Rounded corners
            card.Paint += (s, e) =>
            {
                var rect = card.ClientRectangle;
                rect.Width -= 1;
                rect.Height -= 1;

                using var path = RoundedRect(rect, 12);
                card.Region = new Region(path);

                using var pen = new Pen(Color.FromArgb(200, 200, 200));
                e.Graphics.DrawPath(pen, path);
            };

            PictureBox pic = new PictureBox
            {
                Width = 80,
                Height = 60,
                Top = 12,
                Left = 20,
                SizeMode = PictureBoxSizeMode.Zoom,
                Tag = item
            };

            if (!string.IsNullOrEmpty(item.ImagePath) && File.Exists(item.ImagePath))
            {
                byte[] bytes = File.ReadAllBytes(item.ImagePath);
                using MemoryStream ms = new MemoryStream(bytes);
                pic.Image = Image.FromStream(ms);
            }

            Label lblName = new Label
            {
                Text = item.Name,
                Top = 75,
                Width = 120,
                Height = 18,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 9, FontStyle.Regular),
                Tag = item
            };

            Label lblPrice = new Label
            {
                Text = $"₱{item.Price}",
                Top = 95,
                Width = 120,
                Height = 20,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.FromArgb(53, 108, 27),
                Tag = item
            };

            card.Controls.Add(pic);
            card.Controls.Add(lblName);
            card.Controls.Add(lblPrice);

            // click events
            card.Click += Item_Click;
            pic.Click += Item_Click;
            lblName.Click += Item_Click;
            lblPrice.Click += Item_Click;

            void HoverOn(object? s, EventArgs e)
            {
                card.BackColor = Color.FromArgb(220, 235, 200);
            }

            void HoverOff(object? s, EventArgs e)
            {
                card.BackColor = Color.FromArgb(245, 245, 221);
            }

            card.MouseEnter += HoverOn;
            card.MouseLeave += HoverOff;

            pic.MouseEnter += HoverOn;
            pic.MouseLeave += HoverOff;

            lblName.MouseEnter += HoverOn;
            lblName.MouseLeave += HoverOff;

            lblPrice.MouseEnter += HoverOn;
            lblPrice.MouseLeave += HoverOff;
            return card;
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
      
        private void Item_Click(object? sender, EventArgs e)
        {
            if (sender is not Control ctrl || ctrl.Tag is not Item item)
                return;

            string? input = Microsoft.VisualBasic.Interaction.InputBox(
                $"Enter quantity for {item.Name}:",
                "Quantity",
                "1");

            if (!int.TryParse(input, out int qty) || qty <= 0)
                return;

            SelectedItem = new CartItem
            {
                ItemId = item.Id,
                Name = item.Name,
                Price = item.Price,
                Quantity = qty
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}