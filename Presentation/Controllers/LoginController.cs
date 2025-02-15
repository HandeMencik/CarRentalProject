﻿using Entity.Concerete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Presentation.Models;

namespace Presentation.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            var result =await _signInManager.PasswordSignInAsync(model.UserName, model.Password,false,false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "CarStatus");
            }
            return View();
        }
    }
}
