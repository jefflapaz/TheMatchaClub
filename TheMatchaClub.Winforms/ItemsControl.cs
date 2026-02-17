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
            Load += ItemsControl_Load;
        }


        private async void ItemsControl_Load(object? sender, EventArgs e)
        {
            await LoadItems();
        }

        private async Task LoadItems()
        {
            flpItems.Controls.Clear();

            using var context = DbContextHelper.Create();
            var itemService = new ItemService(context);

            var items = await itemService.GetAllAsync();

            var grouped = items.GroupBy(x => x.Category.Name);

            foreach (var group in grouped)
            {
                // Category header
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
                    var btn = new Button
                    {
                        Text = $"{item.Name}\n₱{item.Price}",
                        Width = 150,
                        Height = 80,
                        Tag = item
                    };

                    btn.Click += ItemButton_Click;

                    flpItems.Controls.Add(btn);

                }
            }
        }
        private async void ItemButton_Click(object? sender, EventArgs e)
        {
            if (sender is not Button btn || btn.Tag is not Item item)
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
