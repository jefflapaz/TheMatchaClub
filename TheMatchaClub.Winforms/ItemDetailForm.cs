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
using TheMatchaClub.Infrastructure.Services;
using TheMatchaClub.WinForms.Helpers;


namespace TheMatchaClub.Winforms
{
    public partial class ItemDetailForm : Form
    {
        private readonly int _itemId;
        private readonly int _categoryId;
        private Item _item;


        public ItemDetailForm(Item item)
        {
            InitializeComponent();

            _item = item;

            lblName.Text = $"Name: {item.Name}";
            lblPrice.Text = $"Price: ₱{item.Price}";
            lblCategory.Text = $"Category: {item.Category.Name}";
        }


        private async void btnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Delete this item?", "Confirm", MessageBoxButtons.YesNo);

            if (confirm != DialogResult.Yes)
                return;

            using var context = DbContextHelper.Create();
            var itemService = new ItemService(context);
            var categoryService = new CategoryService(context);

            await itemService.DeleteAsync(_item.Id);
            await categoryService.DeleteIfEmptyAsync(_item.CategoryId);


            MessageBox.Show("Item deleted.");

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            using var editForm = new AddItemForm(_item);
            if (editForm.ShowDialog() == DialogResult.OK)
                this.DialogResult = DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
