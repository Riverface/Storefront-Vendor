using VendorTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System;
namespace VendorTracker.Controllers
{
    public class VendorController : Controller
    {

        [HttpGet("/Vendor/list")]
        public ActionResult Entries()
        {
            return View(Vendor._Instances);
        }
        [HttpGet("/Vendor/new")]
        public ActionResult NewVendor()
        {
            return View();
        }

        [HttpPost("/Vendor/list")]
        public ActionResult CreateVendor(string name, string address)
        {
            Vendor tempVendor = new Vendor(name, address);
            return RedirectToAction("Entries");
        }
        [HttpGet("/Vendor/Show/{ID}")]
        public ActionResult ShowVendor(int id){
        Vendor foundVendor = Vendor.GetByID(id);
        return View(foundVendor);
        }
    }
}