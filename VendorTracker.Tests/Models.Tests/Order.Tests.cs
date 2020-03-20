using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using VendorTracker.Models;
using System;

namespace OrderTracker.Tests
{
    [TestClass]
    public class VendorTests
    {
        [TestCleanup()]
        public void Cleanup()
        {
            Order.ClearAll();
        }
        [TestMethod]
        public void Order_Constructs_Object()
        {
            Order testOrder = new Order("Cinnamon Roll", "It's a cinnamon roll.", 2.50F, 1);
            Assert.AreEqual(testOrder.Name, "Cinnamon Roll");
        }
        [TestMethod]
        public void Order_GetSet_Object()
        {
            Order testOrder = new Order("Cinnamon Roll", "It's a cinnamon roll.", 2.50F, 1);
            testOrder.Name = "Maple Bar";
            Assert.AreEqual(testOrder.Name, "Maple Bar");
        }
        [TestMethod]
        public void Order_AddedToInstances_Object()
        {
            Order testOrder = new Order("Cinnamon Roll", "It's a cinnamon roll.", 2.50F, 1);
            Assert.AreEqual(testOrder.Name, Order._Instances[0].Name);

        }
        [TestMethod]
        public void Order_SetsID_Int()
        {
            Order testOrder = new Order("Cinnamon Roll", "It's a cinnamon roll.", 2.50F, 1);
            Order testOrder1 = new Order("Cinnamon Roll", "It's a cinnamon roll.", 2.50F, 1);
            Order testOrder2 = new Order("Cinnamon Roll", "It's a cinnamon roll.", 2.50F, 1);
            Order testOrder3 = new Order("Cinnamon Roll", "It's a cinnamon roll.", 2.50F, 1);
            Assert.AreEqual(testOrder3.ID, Order._Instances[3].ID);
        }

    }
}