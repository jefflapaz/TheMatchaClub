using Microsoft.EntityFrameworkCore;
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

            flpItems.Controls.Clear();

            // USUALS PART
            var usuals = items.Where(x => x.IsUsual).ToList();
            if (usuals.Any())
            {
                AddHeader("⭐ Usuals");

                foreach (var item in usuals)
                    AddItemButton(item);
            }

            // GROUP BY CATEGORY (Under Usuals)
            var grouped = items
                .Where(x => !x.IsUsual)
                .GroupBy(x => x.Category.Name);

            foreach (var group in grouped)
            {
                AddHeader(group.Key);

                foreach (var item in group)
                    AddItemButton(item);
            }
        }

        private void AddHeader(string text)
        {
            var lbl = new Label
            {
                Text = text,
                Font = new Font(FontFamily.GenericSansSerif, 11, FontStyle.Bold),
                AutoSize = true,
                Padding = new Padding(5)
            };

            flpItems.Controls.Add(lbl);
        }

        private void AddItemButton(Item item)
        {
            var btn = new Button
            {
                Text = $"{item.Name}\n₱{item.Price}",
                Width = 140,
                Height = 70,
                Tag = item
            };

            btn.Click += Item_Click;

            flpItems.Controls.Add(btn);
        }

        private void Item_Click(object? sender, EventArgs e)
        {
            if (sender is not Button btn || btn.Tag is not Item item)
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
