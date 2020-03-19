using VendorTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System;
namespace VendorTracker.Controllers
{
    public class ItemController : Controller
    {

        [HttpGet("/Vendor/{Vid}/Item")]
        public ActionResult Item(int VId){
            
            return View();
        }
        [HttpGet("/Vendor/{Vid}/Item/New")]
        public ActionResult NewItem(int VId){
        
        return  View();
        }

        [HttpPost("/Vendor/{Vid}/Item/")]
        public ActionResult CreateItem(int VId){

        return RedirectToAction("Item");
        }
    }
}