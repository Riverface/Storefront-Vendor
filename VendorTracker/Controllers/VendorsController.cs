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
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/Vendors/")]
        public ActionResult Create(string name, string address)
        {
            Vendor tempVendor = new Vendor(name, address);
            return RedirectToAction("Index");
        }

        [HttpGet("/Vendors/{id}")]
        public ActionResult Show(int id)
        {
            Vendor foundVendor = Vendor.GetByID(id);
            return View(foundVendor);
        }
    }
}