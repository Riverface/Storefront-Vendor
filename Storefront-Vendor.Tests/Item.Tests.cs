using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using VendorTracker.Models;
using System;

namespace ItemTracker.Tests
{
    [TestClass]
    public class VendorTests
    {
        [TestCleanup()]
        public void Cleanup()
        {
            Item.ClearAll();
        }
        [TestMethod]
        public void Item_Constructs_Object()
        {
            Item testItem = new Item("Cinnamon Roll", "It's a cinnamon roll.", 2.50F, 1);
            Assert.AreEqual(testItem.Name, "Cinnamon Roll");
        }
        [TestMethod]
        public void Item_GetSet_Object()
        {
            Item testItem = new Item("Cinnamon Roll", "It's a cinnamon roll.", 2.50F, 1);
            testItem.Name = "Maple Bar";
            Assert.AreEqual(testItem.Name, "Maple Bar");
        }
        [TestMethod]
        public void Item_AddedToInstances_Object()
        {
            Item testItem = new Item("Cinnamon Roll", "It's a cinnamon roll.", 2.50F, 1);
            Assert.AreEqual(testItem.Name, Item._Instances[0].Name);

        }
        [TestMethod]
        public void Item_SetsID_Int()
        {
            Item testItem = new Item("Cinnamon Roll", "It's a cinnamon roll.", 2.50F, 1);
            Item testItem1 = new Item("Cinnamon Roll", "It's a cinnamon roll.", 2.50F, 1);
            Item testItem2 = new Item("Cinnamon Roll", "It's a cinnamon roll.", 2.50F, 1);
            Item testItem3 = new Item("Cinnamon Roll", "It's a cinnamon roll.", 2.50F, 1);
            Assert.AreEqual(testItem3.ID, Item._Instances[3].ID);
        }

    }
}