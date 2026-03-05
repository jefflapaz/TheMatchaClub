using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheMatchaClub.Domain.Entities;
using TheMatchaClub.Application.Services;
using TheMatchaClub.WinForms.Helpers;

namespace TheMatchaClub.Winforms
{
    public partial class ItemsControl : UserControl
    {
        public ItemsControl()
        {
            InitializeComponent();
            EnableDoubleBuffering(flpItems);
            Load += ItemsControl_Load;
        }

        private async void ItemsControl_Load(object? sender, EventArgs e)
        {
            await LoadItems();
        }

        private async Task LoadItems()
        {
            flpItems.SuspendLayout();

            flpItems.Controls.Clear();

            using var context = DbContextHelper.Create();
            var itemService = new ItemService(context);

            var items = await itemService.GetAllAsync();
            var grouped = items.GroupBy(x => x.Category.Name);

            foreach (var group in grouped)
            {
                var lblCategory = new Label
                {
                    Text = group.Key,
                    Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold),
                    AutoSize = true,
                    Padding = new Padding(10)
                };

                flpItems.Controls.Add(lblCategory);

                foreach (var item in group)
                {
                    Panel card = new Panel
                    {
                        Width = 150,
                        Height = 160,
                        BackColor = Color.White,
                        Margin = new Padding(10),
                        Tag = item
                    };

                    PictureBox pic = new PictureBox
                    {
                        Width = 130,
                        Height = 90,
                        Top = 10,
                        Left = 10,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Tag = item
                    };

                    if (!string.IsNullOrEmpty(item.ImagePath))
                    {
                        pic.Image = LoadImage(item.ImagePath);
                    }

                    Label lblName = new Label
                    {
                        Text = item.Name,
                        Top = 105,
                        Width = 130,
                        Height = 20,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Tag = item
                    };
                    Label lblPrice = new Label
                    {
                        Text = $"₱{item.Price}",
                        Top = 125,
                        Width = 130,
                        Height = 20,
                        Font = new Font(FontFamily.GenericSansSerif, 9, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Tag = item
                    };

                    card.Controls.Add(pic);
                    card.Controls.Add(lblName);
                    card.Controls.Add(lblPrice);

                    card.Click += ItemButton_Click;
                    pic.Click += ItemButton_Click;
                    lblName.Click += ItemButton_Click;
                    lblPrice.Click += ItemButton_Click;
                    flpItems.Controls.Add(card);

                    card.Cursor = Cursors.Hand;
                    pic.Cursor = Cursors.Hand;
                    lblName.Cursor = Cursors.Hand;
                    lblPrice.Cursor = Cursors.Hand;
                }
            }

            flpItems.ResumeLayout();
        }
        private void EnableDoubleBuffering(Control control)
        {
            var prop = typeof(Control).GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.NonPublic |
                System.Reflection.BindingFlags.Instance);

            prop?.SetValue(control, true, null);
        }
        private Image? LoadImage(string path)
        {
            if (!File.Exists(path))
                return null;

            byte[] bytes = File.ReadAllBytes(path);

            using MemoryStream ms = new MemoryStream(bytes);

            return Image.FromStream(ms);
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.DoubleBuffered = true;
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
