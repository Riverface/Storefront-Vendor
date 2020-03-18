using Vendor.Models;
using Microsoft.AspNetCore.Mvc;
using System;
namespace Vendor.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index(){
            return View();
        }
    }
}