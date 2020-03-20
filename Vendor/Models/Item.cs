using System;
using System.Collections.Generic;

namespace VendorTracker.Models
{
    public class Item
    {
        static int IDQueue = 1;
        public int ID;
        public static List<Item> _Instances = new List<Item>();
        public string Name;
        public float PricePer;
        public int Amount;
        public float Total;
        public string ItemDesc;
        public string Plural;

        public Item(string name, string itemDesc, float individualPrice, int quantity = 1)
        {
            Name = name;
            PricePer = individualPrice;
            Amount = quantity;
            Total = PricePer * quantity;
            ItemDesc = itemDesc;
            _Instances.Add(this);
            ID = _Instances.Count;

        }
        public float CountItemTotal()
        {
            return PricePer * Amount;
        }
        public List<Item> GetAll()
        {
            return _Instances;
        }
        public static void ClearAll()
        {
            _Instances = new List<Item>();

        }
    }
}