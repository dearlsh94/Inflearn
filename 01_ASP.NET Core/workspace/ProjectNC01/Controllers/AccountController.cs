using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectNC01.Models;

namespace ProjectNC01.Controllers
{
    public class AccountController : Controller
    {
        public AccountController()
        {
            
        }

        public IActionResult Register()
        {
            return View();
        }

        
    }
}
