using System.Collections.Generic;

namespace CST_117_Milestone_4
{
    public class InventoryManager
    {

        public List<InventoryItem> Inventory { get; private set; } = new List<InventoryItem>();
        public static int DEFAULT_QUANTITY { get; } = 10;

        public InventoryItem AddItem(InventoryItem item)
        {
            if(ContainsItem(item))
            {
                InventoryItem foundItem = FindItem(item);
                foundItem.Quantity += item.Quantity;
                return foundItem;
            }else
            {
                Inventory.Add(item);
                return item;
            }
        }

        public void AddItems(List<string[]> items)
        {
            foreach(string[] item in items)
            {
                InventoryItem newItem = new InventoryItem(item);
                AddItem(newItem);
            }
        }

        public InventoryItem FindItem(string itemName)
        {
            return Inventory.Find(x => x.Equals(itemName));
        }

        public InventoryItem FindItem(InventoryItem item)
        {
            return Inventory.Find(x => x.Equals(item));
        }

        public List<InventoryItem> FindItems(string itemName, string desc)
        {
            List<InventoryItem> searchResults = new List<InventoryItem>();
            return Inventory.FindAll(x => x.Equals(itemName, desc));
        }

        public List<InventoryItem> FindItemsUnder(decimal price)
        {
            List<InventoryItem> searchResults = new List<InventoryItem>();
            return Inventory.FindAll(x => x.Price < price);
        }

        public bool ContainsItem(InventoryItem item)
        {
            return Inventory.Contains(item);
        }

        public bool RemoveItem(InventoryItem item)
        {
            if (ContainsItem(item))
            {
                Inventory.Remove(item);
                return true;
            }
            return false;
        }

        public void RestockItem(string item)
        {
            InventoryItem inventoryItem = FindItem(item);
            if (inventoryItem.OutOfStock() || inventoryItem.Quantity < DEFAULT_QUANTITY) {
                inventoryItem.Quantity = DEFAULT_QUANTITY;
            }
        }

        public void RestockItem(InventoryItem item)
        {
            InventoryItem inventoryItem = FindItem(item);
            if (inventoryItem.OutOfStock() || inventoryItem.Quantity < DEFAULT_QUANTITY)
            {
                inventoryItem.Quantity = DEFAULT_QUANTITY;
            }
        }

        public override string ToString()
        {
            string value = "";
            foreach(InventoryItem item in Inventory)
            {
                value += "[" + item.ToString() + "]\n\n";
            }
            return value;
        }

        public List<string[]> GetCSVList()
        {
            List<string[]> lines = new List<string[]>();
            foreach(InventoryItem item in Inventory)
            {
                lines.Add(item.ToArray());
            }
            return lines;
        }
    }
}
