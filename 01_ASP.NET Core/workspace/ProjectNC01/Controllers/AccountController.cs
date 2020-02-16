using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectNC01.Models;
using ProjectNC01.ViewModels;

namespace ProjectNC01.Controllers
{
    public class AccountController : Controller
    {
        public readonly UserManager<ApplicationUser> _userManager;
        public readonly SignInManager<ApplicationUser> _signManager;

        public AccountController(UserManager<ApplicationUser> userManager,
                                    SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signManager = signInManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { 
                    UserName = model.Email, 
                    Email = model.Email, 
                    FullName = model.FullName, 
                    Gender = model.Gender 
                };

                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                    return RedirectToAction("Login");

                ModelState.AddModelError("", "Failed");
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                /*
                 * 3rd Param : 브라우저가 닫혀도 로그인 된 쿠키가 지속되어야 하는 지
                 * 4rd Param : 유저가 로그인 실패 했을 때 계정을 잠궈야 하는 지
                 */
                var result = await _signManager.PasswordSignInAsync(model.Email, model.Password, false, false);

                if (result.Succeeded)
                    return RedirectToAction("Index", "Home");

                ModelState.AddModelError("", "Login Failed");
            }

            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await _signManager.SignOutAsync();

            return RedirectToAction("Login");
        }
    }
}
