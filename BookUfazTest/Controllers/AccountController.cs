using BookUfazTest.Models;
using BookUfazTest.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookUfazTest.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<StudentUser> userManager;
        private readonly SignInManager<StudentUser> signInManager;

        public AccountController(UserManager<StudentUser> userManager,
                                 SignInManager<StudentUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new StudentUser { UserName = model.UnistraCardID,
                    UnistraCardId = model.UnistraCardID,
                    Email = model.Email,
                    FacultyId = model.FacultyId,
                    YearId = model.YearID,
                    StudentNameSurname = model.StudentNameSurname
                    };
                var result = await userManager.CreateAsync(user, model.Password);
                if(result.Succeeded)
                {
                    await signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.ID,model.Password, model.RememberMe,false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index","Home");
                }
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
               
            }
            return View(model);
        }

    }
}
