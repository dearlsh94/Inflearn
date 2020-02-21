using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectNC02.Models;

using ProjectNC02.ViewModels;

namespace ProjectNC02.Controllers
{
    public class MembershipController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginInfoViewModel model)
        {
            string message = string.Empty;

            if (ModelState.IsValid)
            {
                string userId = "admin";
                string password = "1";

                if (model.UserId.Equals(userId) &&
                    model.Password.Equals(password))
                {
                    TempData["Message"] = "Login Successed";    
                }

                return RedirectToAction("Index", "Membership");
            }
            else
            {
                message = "Invalid input data";
            }
            
            ModelState.AddModelError(string.Empty, message);
            return View();
        }
    }
}