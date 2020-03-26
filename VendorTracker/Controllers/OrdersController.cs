using VendorTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace VendorTracker.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet("/Vendors/{ID}/Orders/New")]
        public ActionResult NewOrder(int ID)
        {
            return  View(Vendor.GetByID(ID));
        }

        [HttpPost("/Vendors/{ID}/")]
        public ActionResult CreateOrder(int ID, string name, string orderDesc, float indiIDualPrice, int quantity)
        {
            Vendor.GetByID(ID).AddOrder(new Order(name, orderDesc, indiIDualPrice, quantity));
            return RedirectToAction("Show", "Vendors", new {id = ID});
        }
    }
}