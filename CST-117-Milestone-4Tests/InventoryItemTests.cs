using Microsoft.VisualStudio.TestTools.UnitTesting;
using CST_117_Milestone_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_117_Milestone_4.Tests
{
    [TestClass()]
    public class InventoryItemTests
    {
        private string name = "Test Item";
        private string desc = "This is a test item";
        private int quantity = 10;
        private decimal weight = 15.534M;
        private decimal price = 18.126M;

        [TestMethod()]
        public void InventoryItemTest()
        {
            InventoryItem item = new InventoryItem(name, desc, quantity, price, weight);
            Assert.IsNotNull(item);
            Assert.AreEqual(name, item.Name);
            Assert.AreEqual(desc, item.Description);
            Assert.AreEqual(quantity, item.Quantity);
            Assert.AreEqual(18.13M, item.Price);
            Assert.AreEqual(15.5M, item.Weight);
        }

        [TestMethod()]
        public void purchaseItemTest()
        {
            InventoryItem item = new InventoryItem(name, desc, quantity, price, weight);
            Assert.IsTrue(item.PurchaseItem(1));
            Assert.IsFalse(item.PurchaseItem(10));
        }

        [TestMethod()]
        public void OutOfStockTest()
        {
            InventoryItem item = new InventoryItem(name, desc, quantity, price, weight);
            Assert.IsFalse(item.OutOfStock());
            item.PurchaseItem(10);
            Assert.IsTrue(item.OutOfStock());
        }

        [TestMethod()]
        public void EqualsTest()
        {
            InventoryItem item = new InventoryItem(name, desc, quantity, price, weight);
            InventoryItem item2 = new InventoryItem(name, "diff desc", 2, 2.5M, 3.5M);
            Assert.IsTrue(item.Equals(item2));
        }
    }
}