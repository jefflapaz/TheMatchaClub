using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // Added for Path and File operations
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
    public partial class AddItemForm : Form
    {
        private string? _pendingNewCategory;
        private int? _editItemId;
        private string? _selectedImagePath;

        public AddItemForm()
        {
            InitializeComponent();
            this.Load += AddItemForm_Load;
        }

        public AddItemForm(Item item) : this()
        {
            _editItemId = item.Id;

            txtName.Text = item.Name;
            txtPrice.Text = item.Price.ToString();
            chkUsual.Checked = item.IsUsual;

            cmbCategory.SelectedItem = item.Category.Name;

            btnSave.Text = "Save Changes";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                cmbCategory.SelectedItem == null ||
                cmbCategory.SelectedItem.ToString() == "Add New Category...")
            {
                // Replaced standard MessageBox
                MyUniversalBox.Show("All fields are required.", "Validation", isError: true);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                // Replaced standard MessageBox
                MyUniversalBox.Show("Invalid price.", "Input Error", isError: true);
                return;
            }

            try
            {
                using var context = DbContextHelper.Create();

                var categoryService = new CategoryService(context);
                var itemService = new ItemService(context);

                var selectedCategory = cmbCategory.SelectedItem!.ToString()!;

                var category = await categoryService.GetOrCreateAsync(selectedCategory);

                string? savedImagePath = null;

                if (!string.IsNullOrEmpty(_selectedImagePath))
                {
                    string imagesFolder = Path.Combine(
                        AppDomain.CurrentDomain.BaseDirectory,
                        "images",
                        "items"
                    );

                    Directory.CreateDirectory(imagesFolder);

                    string extension = Path.GetExtension(_selectedImagePath);

                    string fileName = Guid.NewGuid().ToString() + extension;

                    string destinationPath = Path.Combine(imagesFolder, fileName);

                    File.Copy(_selectedImagePath, destinationPath, true);

                    savedImagePath = destinationPath;
                }

                if (_editItemId.HasValue)
                {
                    await itemService.UpdateAsync(
                        _editItemId.Value,
                        txtName.Text,
                        price,
                        category.Id,
                        chkUsual.Checked,
                        savedImagePath);
                }
                else
                {
                    await itemService.AddAsync(
                        txtName.Text,
                        price,
                        category.Id,
                        chkUsual.Checked,
                        savedImagePath);
                }

                // Replaced standard MessageBox
                MyUniversalBox.Show("Item saved successfully.", "Success", isError: false);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // Replaced standard MessageBox
                MyUniversalBox.Show(ex.Message, "System Error", isError: true);
            }
        }

        private async void AddItemForm_Load(object? sender, EventArgs e)
        {
            await LoadCategories();
        }

        private async Task LoadCategories()
        {
            using var context = DbContextHelper.Create();

            var categories = await context.Categories
                .Select(c => c.Name)
                .ToListAsync();

            cmbCategory.Items.Clear();

            foreach (var cat in categories)
                cmbCategory.Items.Add(cat);

            cmbCategory.Items.Add("Add New Category...");
        }

        private void cmbCategory_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem?.ToString() == "Add New Category...")
            {
                string? newCategory = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter new category name:",
                    "Add Category",
                    "");

                if (string.IsNullOrWhiteSpace(newCategory))
                {
                    cmbCategory.SelectedIndex = -1;
                    return;
                }

                _pendingNewCategory = newCategory;

                cmbCategory.Items.Insert(cmbCategory.Items.Count - 1, newCategory);
                cmbCategory.SelectedItem = newCategory;
            }
        }

        private void btnImageAdd_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            ofd.Title = "Select Product Image";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    _selectedImagePath = ofd.FileName;
                    btnImageAddItem.Image = Image.FromFile(_selectedImagePath);
                }
                catch (Exception ex)
                {
                    // Replaced standard MessageBox
                    MyUniversalBox.Show($"Error loading image: {ex.Message}", "Image Error", isError: true);
                }
            }
        }
    }
}