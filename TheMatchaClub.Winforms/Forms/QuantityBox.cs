using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheMatchaClub.Winforms.Forms
{
    public partial class QuantityBox : Form
    {
        // Public property to store the result
        public int SelectedQuantity { get; private set; }

        public QuantityBox(string itemName)
        {
            InitializeComponent();

            // Update the label with the item name
            lblPrompt.Text = $"Enter quantity for {itemName}:";

            // Link buttons to DialogResults
            btnOK.Click += (s, e) => Submit();
            btnCancel.Click += (s, e) => this.DialogResult = DialogResult.Cancel;

            // Allow pressing "Enter" key to submit
            this.AcceptButton = btnOK;
            this.CancelButton = btnCancel;
        }

        private void Submit()
        {
            if (int.TryParse(txtQuantity.Text, out int qty) && qty > 0)
            {
                SelectedQuantity = qty;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // You can use your custom MessageBox here!
                MyUniversalBox.Show("Please enter a valid number.", "Invalid Input", isError: true);
            }
        }
    }
}
