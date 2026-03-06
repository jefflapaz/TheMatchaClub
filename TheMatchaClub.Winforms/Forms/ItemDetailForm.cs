using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    public partial class ItemDetailForm : Form
    {
        private Item _item;

        public ItemDetailForm(Item item)
        {
            InitializeComponent();

            _item = item;

            lblName.Text = $"Name: {item.Name}";
            lblPrice.Text = $"Price: ₱{item.Price}";
            lblCategory.Text = $"Category: {item.Category.Name}";
            LoadImage();
        }

        private void LoadImage()
        {
            if (string.IsNullOrEmpty(_item.ImagePath))
                return;

            if (!File.Exists(_item.ImagePath))
                return;

            try
            {
                byte[] bytes = File.ReadAllBytes(_item.ImagePath);
                using MemoryStream ms = new MemoryStream(bytes);
                pictureBoxItem.Image = Image.FromStream(ms);
            }
            catch
            {
                // Silent fail for image loading
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var rect = pnlImageContainer.ClientRectangle;
            rect.Width -= 1;
            rect.Height -= 1;

            using var path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 12;

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();

            pnlImageContainer.Region = new Region(path);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            // Note: Standard MessageBox used for Yes/No confirmation 
            // until MyUniversalBox is upgraded with two buttons!
            var confirm = MessageBox.Show($"Are you sure you want to delete {_item.Name}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                using var context = DbContextHelper.Create();
                var itemService = new ItemService(context);
                var categoryService = new CategoryService(context);

                await itemService.DeleteAsync(_item.Id);
                await categoryService.DeleteIfEmptyAsync(_item.CategoryId);

                // Replaced with custom typewriter box
                MyUniversalBox.Show("The item has been successfully removed.", "Item Deleted", isError: false);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MyUniversalBox.Show($"Error during deletion: {ex.Message}", "System Error", isError: true);
            }
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