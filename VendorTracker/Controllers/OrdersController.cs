using VendorTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace VendorTracker.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet("/Vendors/{id}/Orders/New")]
        public ActionResult New(int id)
        {
            return  View(Vendor.GetByID(id));
        }

        [HttpPost("/Vendors/{id}/")]
        public ActionResult Create(int id, string name, string orderDesc, float individualPrice, int quantity)
        {
            Vendor.GetByID(id).AddOrder(new Order(name, orderDesc, individualPrice, quantity));
            return RedirectToAction("Show", "Vendors", new {id});
        }
    }
}