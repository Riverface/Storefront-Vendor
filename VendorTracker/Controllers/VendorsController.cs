using VendorTracker.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace VendorTracker.Controllers
{
    public class VendorsController : Controller
    {

        [HttpGet("/Vendors/")]
        public ActionResult Index()
        {
            return View(Vendor._Instances);
        }

        [HttpGet("/Vendors/new")]
        public ActionResult NewVendor()
        {
            return View();
        }

        [HttpPost("/Vendors/")]
        public ActionResult CreateVendor(string name, string address)
        {
            Vendor tempVendor = new Vendor(name, address);
            return RedirectToAction("Index");
        }

        [HttpGet("/Vendors/{ID}")]
        public ActionResult Show(int id)
        {
            Vendor foundVendor = Vendor.GetByID(id);
            return View(foundVendor);
        }
    }
}