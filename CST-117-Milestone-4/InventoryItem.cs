using System;

namespace CST_117_Milestone_4
{
    public class InventoryItem
    {
        public int Quantity { get; set; }
        public decimal Price { get; private set; }
        public decimal Weight { get; private set; }
        public string Description { get; private set; }
        public string Name { get; private set; }

        /// <summary>
        /// Creates an Inventory Item
        /// </summary>
        /// <param name="name">Name of the item</param>
        /// <param name="description">Description of the item</param>
        /// <param name="quantity">Quantity of item in inventory</param>
        /// <param name="price">How much the item costs. Will be rounded to 2 decimal places.</param>
        /// <param name="weight">How much the item weighs. Will be routed to 1 decimal place.</param>
        public InventoryItem(string name, string description, int quantity, decimal price, decimal weight)
        {
            this.Name = name;
            this.Description = description;
            this.Quantity = quantity;
            this.Price = Math.Round(price, 2);
            this.Weight = Math.Round(weight, 1);
        }

        /// <summary>
        /// Checks to see if the item is out of stock.
        /// </summary>
        /// <returns>Boolean true if quantity == 0</returns>
        public bool OutOfStock()
        {
            return Quantity == 0;
        }

        /// <summary>
        /// Checks to see if the amount requested is available
        /// </summary>
        /// <param name="requested"></param>
        /// <returns>Bool if the amount is available.</returns>
        private bool QuantityPurchasable(int requested)
        {
            return Quantity >= requested;
        }

        /// <summary>
        /// If the <paramref name="requested"/> is availble in quantity than the <paramref name="requested"/> is reduced from the quantity
        /// </summary>
        /// <param name="requested">The number of items requested</param>
        /// <returns>Returns boolean based on if the purchase was successful.</returns>
        public bool PurchaseItem(int requested)
        {
            if (requested > 0 && !OutOfStock() && QuantityPurchasable(requested))
            {
                Quantity = Quantity - requested;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Allows the Inventory Item to be compared by name for same values.
        /// </summary>
        /// <param name="obj">The object we are trying to compare</param>
        /// <returns>Returns boolean based on if the objects are equal.</returns>
        public override bool Equals(Object obj)
        {
            return (obj is InventoryItem) && ((InventoryItem)obj).Name == Name;
        }

        public bool Equals(string name)
        {
            return name == Name;
        }

        public bool Equals(string name, string desc)
        {
            return Name.ToLower().Contains(name.ToLower()) || Description.ToLower().Contains(desc.ToLower());
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
