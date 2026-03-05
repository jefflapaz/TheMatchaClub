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