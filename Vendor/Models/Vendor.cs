using System;
using System.Collections.Generic;

namespace VendorTracker.Models
{
    public class Vendor
    {
        static public List<Vendor> _Instances = new List<Vendor>();
        public int ID;
        public List<Item> Items;
        public string Name;
        public string Address;
        public Vendor(string name, string address)
        {
            Items = new List<Item>();
            Name = name;
            Address = address;
            _Instances.Add(this);
            ID = _Instances.Count;
        }

        public float CountVendorTotal(bool usingCpns = false)
        {
            float workingTotal = 0;
            foreach (Item thing in Items)
            {
                workingTotal += thing.Total;
            }
            return workingTotal;
        }
        public void AddItem(Item toAdd)
        {
            Items.Add(toAdd);
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

