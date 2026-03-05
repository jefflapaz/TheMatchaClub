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
    public partial class ItemDetailForm : Form
    {

        private Item _item;


        public ItemDetailForm(Item item, byte[]? imageBytes)
        {
            InitializeComponent();

            _item = item;

            lblName.Text = $"Name: {item.Name}";
            lblPrice.Text = $"Price: ₱{item.Price}";
            lblCategory.Text = $"Category: {item.Category.Name}";

            // Handle the Image
            if (imageBytes != null && imageBytes.Length > 0)
            {
                try
                {
                    using (var ms = new MemoryStream(imageBytes))
                    {
                        // Assign image to your Guna2ImageButton
                        btnImageAddItem.Image = Image.FromStream(ms);

                        // FIX THE "SMOL" BUG: Stretch image to fill the button area
                        btnImageAddItem.ImageSize = new Size(btnImageAddItem.Width, btnImageAddItem.Height);

                        // Ensure no offset is pushing the image out of center
                        btnImageAddItem.ImageOffset = new Point(0, 0);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error displaying image: " + ex.Message);
                }
            }
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