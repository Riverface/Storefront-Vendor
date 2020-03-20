using VendorTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System;
namespace VendorTracker.Controllers
{
    public class ItemController : Controller
    {
        

        [HttpGet("/Vendor/{VId}/Item/New")]
        public ActionResult NewItem(int VId){
        return  View(Vendor.GetByID(VId));
        }

        [HttpPost("/Vendor/{VId}/")]
        public ActionResult CreateItem(int VId, string name, string itemDesc, float individualPrice, int quantity){
        Vendor.GetByID(VId).AddItem(new Item(name, itemDesc, individualPrice, quantity));
        return RedirectToAction("Show", "Vendor", new {id = VId});
        }
    }
}