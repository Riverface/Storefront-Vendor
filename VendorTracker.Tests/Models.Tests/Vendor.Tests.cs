using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
    [TestClass]
    public class VendorTests
    {
        [TestCleanup()]
        public void Cleanup()
        {
            Vendor.ClearAll();
        }

        [TestMethod]
        public void Vendor_Constructs_Object()
        {
            Vendor testVendor = new Vendor("Fat Todd's", "10592 NE dead squirrel road");
            Assert.AreEqual(testVendor.Name, "Fat Todd's");
        }

        [TestMethod]
        public void Vendor_GetSet_Object()
        {
            Vendor testVendor = new Vendor("Fat Todd's", "10592 NE dead squirrel road");
            testVendor.Name = "Skinny Ted's";
            Assert.AreEqual(testVendor.Name, "Skinny Ted's");
        }

        [TestMethod]
        public void Vendor_AddedToInstances_Object()
        {
            Vendor testVendor = new Vendor("Fat Todd's", "10592 NE dead squirrel road");
            Assert.AreEqual(testVendor.Name, Vendor._Instances[0].Name);
        }

        [TestMethod]
        public void Vendor_SetsID_Int()
        {
            Vendor testVendor = new Vendor("Fat Todd's", "10592 NE dead squirrel road");
            Vendor testVendor1 = new Vendor("Fat Todd's", "10592 NE dead squirrel road");
            Vendor testVendor2 = new Vendor("Fat Todd's", "10592 NE dead squirrel road");
            Vendor testVendor3 = new Vendor("Ted's Munchies", "The Honda Civic outside of the dispensary");
            Assert.AreEqual(testVendor3.ID, Vendor._Instances[3].ID);
        }

        [TestMethod]
        public void Vendor_AcceptsOrders_Object()
        {
            Vendor testVendor = new Vendor("Fat Todd's", "10592 NE de   ad squirrel road");
            Order testOrder3 = new Order("Cinnamon Roll", "It's a cinnamon roll.", 2.50F, 1);
            testVendor.Orders.Add(testOrder3);
            Assert.AreEqual(testVendor.Orders[0].ID, testOrder3.ID);
        }
    }
}