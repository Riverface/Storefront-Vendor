using System;
using System.Collections.Generic;

namespace Vendor.Models
{
    public class Vendor
    {
        static List<Vendor> Instances_ = new List<Vendor>();
        static int IDQueue = 1;
        public int ID;
        public List<Item> ItemMenu;
        public Vendor()
        {
            ItemMenu = new List<Item>();
            ID = IDQueue;
            IDQueue++;
        }


        public float CountVendorTotal(bool usingCpns = false)
        {
            float workingTotal = 0;
            foreach (Item thing in ItemMenu)
            {
                workingTotal += thing.Total;
            }
            return workingTotal;
        }
        public void AddItem(string name, string itemDesc, float individualPrice, string Plural = null)
        {
            ItemMenu.Add(new Item(name, itemDesc, individualPrice, 1));
        }
    }
    public class Item
    {
        static int IDQueue = 1;
        public int ID;
        public string Tag;
        public float PricePer;
        public int Amount;
        public float Total;
        public string ItemDesc;
        public string Plural;

        public Item(string name, string itemDesc, float individualPrice, int quantity = 1)
        {
            Tag = name;
            PricePer = individualPrice;
            Amount = quantity;
            Total = PricePer * quantity;
            ItemDesc = itemDesc;
            ID = IDQueue;
            IDQueue++;
        }

        public Item(string name, string itemDesc, float individualPrice, int quantity = 1, string plural = "")
        {
            Tag = name;
            PricePer = individualPrice;
            Amount = quantity;
            Total = PricePer * quantity;
            ItemDesc = itemDesc;
            Plural = plural;
        }

        public float CountItemTotal()
        {
            return PricePer * Amount;
        }
    }
}

