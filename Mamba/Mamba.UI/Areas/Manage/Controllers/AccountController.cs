using Mamba.Core.Models;
using Mamba.UI.Areas.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Mamba.UI.Areas.Manage.Controllers
{
    [Area("manage")]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> Login(AdminLoginViewModel adminLoginVM)
        {
            if (!ModelState.IsValid) return View();
            User admin = null;

            admin = await _userManager.FindByNameAsync(adminLoginVM.Username);

            if (admin == null)
            {
                ModelState.AddModelError("", "Username or Password is wrong!");
                return View();
            }
            var result = await _signInManager.PasswordSignInAsync(admin, adminLoginVM.Password, false, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Username or Password is wrong!");
                return View();
            }

            return RedirectToAction("Index", "DashBoard");
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login", "Account");
        }
    }
}
