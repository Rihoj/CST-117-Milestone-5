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
    public class InventoryManagerTests
    {
        [TestMethod()]
        public void AddItemTest()
        {
            InventoryItem item = new InventoryItem("Test", "test", 5, 1.5M, 1M);
            InventoryManager manager = new InventoryManager();
            InventoryItem itemReturned = manager.AddItem(item);
            Assert.AreEqual(item, itemReturned);
            InventoryItem itemReturnedAgain = manager.AddItem(item);
            Assert.AreEqual(item, itemReturnedAgain);
        }

        [TestMethod()]
        public void FindItemTest()
        {
            InventoryItem item = new InventoryItem("Test", "test", 5, 1.5M, 1M);
            InventoryManager manager = new InventoryManager();
            manager.AddItem(item);
            InventoryItem foundItem = manager.FindItem("Test");
            Assert.AreEqual(item, foundItem);
        }

        [TestMethod()]
        public void FindItemTest1()
        {
            InventoryItem item = new InventoryItem("Test", "test", 5, 1.5M, 1M);
            InventoryManager manager = new InventoryManager();
            manager.AddItem(item);
            InventoryItem foundItem = manager.FindItem(item);
            Assert.AreEqual(item, foundItem);
        }

        [TestMethod()]
        public void FindItemsTest()
        {
            InventoryItem item = new InventoryItem("Test", "test", 5, 1.5M, 1M);
            InventoryItem item2 = new InventoryItem("Tester", "hello", 5, 1.5M, 1M);
            InventoryManager manager = new InventoryManager();
            manager.AddItem(item);
            manager.AddItem(item2);
            List<InventoryItem> foundResults = manager.FindItems("Test", "hello");

            Assert.AreEqual(2, foundResults.Count);
        }

        [TestMethod()]
        public void FindItemsUnderTest()
        {
            InventoryItem item = new InventoryItem("Test", "test", 5, 1.5M, 1M);
            InventoryItem item2 = new InventoryItem("Tester", "hello", 5, 15M, 1M);
            InventoryManager manager = new InventoryManager();
            manager.AddItem(item);
            manager.AddItem(item2);
            List<InventoryItem> foundResults = manager.FindItemsUnder(10M);
            Assert.AreEqual(1, foundResults.Count);
        }

        [TestMethod()]
        public void ContainsItemTest()
        {
            InventoryItem item = new InventoryItem("Test", "test", 5, 1.5M, 1M);
            InventoryManager manager = new InventoryManager();
            manager.AddItem(item);
            Assert.IsTrue(manager.ContainsItem(item));
        }

        [TestMethod()]
        public void RemoveItemTest()
        {
            InventoryItem item = new InventoryItem("Test", "test", 5, 1.5M, 1M);
            InventoryManager manager = new InventoryManager();
            manager.AddItem(item);
            Assert.IsTrue(manager.RemoveItem(item));
        }

        [TestMethod()]
        public void RestockItemTest()
        {
            InventoryItem item = new InventoryItem("Test", "test", 5, 1.5M, 1M);
            InventoryManager manager = new InventoryManager();
            manager.AddItem(item);
            InventoryItem foundItem = manager.FindItem(item);
            foundItem.Quantity = 0;
            manager.RestockItem("Test");
            InventoryItem foundItemAgain = manager.FindItem(item);
            Assert.AreEqual(InventoryManager.DEFAULT_QUANTITY, foundItemAgain.Quantity);
        }

        [TestMethod()]
        public void RestockItemTest1()
        {
            InventoryItem item = new InventoryItem("Test", "test", 5, 1.5M, 1M);
            InventoryManager manager = new InventoryManager();
            manager.AddItem(item);
            InventoryItem foundItem = manager.FindItem(item);
            foundItem.Quantity = 0;
            manager.RestockItem(foundItem);
            InventoryItem foundItemAgain = manager.FindItem(item);
            Assert.AreEqual(InventoryManager.DEFAULT_QUANTITY, foundItemAgain.Quantity);
        }
    }
}