using System;
using System.Collections.Generic;

namespace VendorTracker.Models
{
    public class Order
    {
        static int IDQueue = 1;
        public int ID;
        public static List<Order> _Instances = new List<Order>();
        public string Name;
        public float PricePer;
        public int Amount;
        public float Total;
        public string OrderDesc;
        public string Plural;

        public Order(string name, string orderDesc, float individualPrice, int quantity = 1)
        {
            Name = name;
            PricePer = individualPrice;
            Amount = quantity;
            Total = PricePer * quantity;
            OrderDesc = orderDesc;
            _Instances.Add(this);
            ID = _Instances.Count;

        }
        public float CountOrderTotal()
        {
            return PricePer * Amount;
        }
        public List<Order> GetAll()
        {
            return _Instances;
        }
        public static void ClearAll()
        {
            _Instances = new List<Order>();

        }
    }
}