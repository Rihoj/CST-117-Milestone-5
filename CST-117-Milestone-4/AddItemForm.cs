using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CST_117_Milestone_4
{
    public partial class AddItemForm : Form
    {
        inventoryManagerForm imf;
        InventoryManager Im;
        public AddItemForm(inventoryManagerForm inventoryManagerForm, InventoryManager inventoryManager)
        {
            InitializeComponent();
            imf = inventoryManagerForm;
            Im = inventoryManager;
        }
        private bool ValidateInput()
        {
            return (
                !string.IsNullOrWhiteSpace(nameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(descTextBox.Text) &&
                !string.IsNullOrWhiteSpace(priceTextBox.Text) &&
                !string.IsNullOrWhiteSpace(quantityTextBox.Text) &&
                !string.IsNullOrWhiteSpace(weightTextBox.Text) &&
                int.TryParse(quantityTextBox.Text, out int quantity) &&
                decimal.TryParse(priceTextBox.Text, out decimal price) &&
                decimal.TryParse(weightTextBox.Text, out decimal weight));
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                InventoryItem newItem = new InventoryItem(nameTextBox.Text, descTextBox.Text, int.Parse(quantityTextBox.Text), decimal.Parse(priceTextBox.Text), decimal.Parse(weightTextBox.Text));
                Im.AddItem(newItem);
                imf.UpdateInventoryList();
                this.Hide();
                nameTextBox.Text = "";
                descTextBox.Text = "";
                priceTextBox.Text = "";
                quantityTextBox.Text = "";
                weightTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Please review the fields", "Error on Save");
            }
        }
    }
}
