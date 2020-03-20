using VendorTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System;
namespace VendorTracker.Controllers
{
    public class OrdersController : Controller
    {
        

        [HttpGet("/Vendors/{VId}/Orders/New")]
        public ActionResult NewOrder(int VId){
        return  View(Vendor.GetByID(VId));
        }

        [HttpPost("/Vendors/{VId}/")]
        public ActionResult CreateOrder(int VId, string name, string OrderDesc, float individualPrice, int quantity){
        Vendor.GetByID(VId).AddOrder(new Order(name, OrderDesc, individualPrice, quantity));
        return RedirectToAction("Show", "Vendors", new {id = VId});
        }
    }
}