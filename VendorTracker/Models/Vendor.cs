using System;
using System.Collections.Generic;

namespace VendorTracker.Models
{
    public class Vendor
    {
        static public List<Vendor> _Instances = new List<Vendor>();
        public int ID;
        public List<Order> Orders;
        public string Name;
        public string Address;
        public Vendor(string name, string address)
        {
            Orders = new List<Order>();
            Name = name;
            Address = address;
            _Instances.Add(this);
            ID = _Instances.Count;
        }

        public float CountVendorTotal(bool usingCpns = false)
        {
            float workingTotal = 0;
            foreach (Order thing in Orders)
            {
                workingTotal += thing.Total;
            }
            return workingTotal;
        }
        public void AddOrder(Order toAdd)
        {
            Orders.Add(toAdd);
        }
        public static List<Vendor> GetAll()
        {
            return _Instances;
        }
        public static void ClearAll()
        {
            _Instances = new List<Vendor>();
            
        }
        public static Vendor GetByID(int id){
            return _Instances[id-1];
        }
    }
}

