using Vendor.Models;
using Microsoft.AspNetCore.Mvc;
using System;
namespace Vendor.Controllers
{
    public class ItemController : Controller
    {

        [HttpGet("/Vendor/{ID}/Item")]
        public ActionResult Item(){
            
            return View();
        }
        [HttpGet("/Vendor/{ID}/Item/New")]
        public ActionResult NewItem(){
        return  View();
        }

        [HttpPost("/Vendor/{ID}/Item/")]
        public ActionResult CreateItem(){
        return RedirectToAction("Item");
        }
    }
}