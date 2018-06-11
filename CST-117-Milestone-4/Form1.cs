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
    public partial class inventoryManagerForm : Form
    {
        public InventoryManager Im { get; set; } = new InventoryManager();
        private AddItemForm AddItemForm;
        private CSVManager CSVManager;
        private static string INVENTORY_LOCATION = "../../Inventory.csv";

        public inventoryManagerForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CSVManager = new CSVManager();
            List<string[]> inventory = CSVManager.readCsv(INVENTORY_LOCATION);
            Im.AddItems(inventory);
            UpdateInventoryList();
            AddItemForm = new AddItemForm(this, Im);
        }
           
        public void UpdateInventoryList()
        {
            SearchTextBox.Text = "";
            inventoryListBox.ClearSelected();
            inventoryListBox.Items.Clear();
            foreach (InventoryItem item in Im.Inventory)
            {
                inventoryListBox.Items.Add(item);
            }
            UpdateSelected();
            CSVManager.saveCsv(INVENTORY_LOCATION, Im.GetCSVList());
        }

        private void UpdateInventoryList(List<InventoryItem> inventory)
        {
            inventoryListBox.ClearSelected();
            inventoryListBox.Items.Clear();
            foreach (InventoryItem item in inventory)
            {
                inventoryListBox.Items.Add(item);
            }
            UpdateSelected();
        }
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (inventoryListBox.SelectedIndex != -1) {
                removeButton.Enabled = true;
                restockButton.Enabled = true;
                InventoryItem selectedItem = (InventoryItem)inventoryListBox.SelectedItem;
                UpdateSelected(selectedItem);
            }
            else
            {
                removeButton.Enabled = false;
                restockButton.Enabled = false;
                UpdateSelected();
            }
        }

        private void UpdateSelected()
        {
            nameOutput.Text = "";
            descOutput.Text = "";
            quantityOutput.Text = "";
            priceOutput.Text = "";
            weightOutput.Text = "";
        }

        private void UpdateSelected(InventoryItem selectedItem)
        {
            nameOutput.Text = selectedItem.Name;
            descOutput.Text = selectedItem.Description;
            quantityOutput.Text = selectedItem.Quantity.ToString();
            priceOutput.Text = selectedItem.Price.ToString("C2");
            weightOutput.Text = selectedItem.Weight.ToString() + " lbs";
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            AddItemForm.ShowDialog();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (inventoryListBox.SelectedIndex != -1)
            {
                InventoryItem selectedItem = (InventoryItem)inventoryListBox.SelectedItem;
                Im.RemoveItem(selectedItem);
                UpdateInventoryList();
            }
        }

        private void RestockButton_Click(object sender, EventArgs e)
        {
            if (inventoryListBox.SelectedIndex != -1)
            {
                InventoryItem selectedItem = (InventoryItem)inventoryListBox.SelectedItem;
                Im.RestockItem(selectedItem);
                UpdateSelected(selectedItem);
                
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                UpdateInventoryList();
            }
            else
            {
                bool resultDecimal = decimal.TryParse(SearchTextBox.Text, out decimal price);
                if (resultDecimal)
                {
                    UpdateInventoryList(Im.FindItemsUnder(price));
                }
                else
                {
                    UpdateInventoryList(Im.FindItems(SearchTextBox.Text, SearchTextBox.Text));
                }
            }
        }
    }
}
