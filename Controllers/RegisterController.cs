using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CafeLab.Models;
using Microsoft.AspNetCore.Mvc;

namespace CafeLab.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TakeInfo(RegInfo info)
        {
            ViewData["Name"] = info.Name;
            ViewData["Email"] = info.Email;

            return View("~/Register/Done.cshtml");
        }
    }
}