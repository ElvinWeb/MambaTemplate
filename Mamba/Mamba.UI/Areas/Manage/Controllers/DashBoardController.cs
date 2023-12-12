using Mamba.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Mamba.UI.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class DashBoardController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public DashBoardController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public IActionResult Index()
        {
            return View();

        }

        //public async Task<IActionResult> CreateAdmin()
        //{
        //    User user = new User()
        //    {
        //        FullName = "Elvin Sarkarov",
        //        UserName = "Admin1",
        //    };

        //    var result = await _userManager.CreateAsync(user, "#Elvin2004");

        //    return Ok(result);
        //}

        //public async Task<IActionResult> CreateRole()
        //{
        //    IdentityRole role1 = new IdentityRole("SuperAdmin");
        //    IdentityRole role2 = new IdentityRole("Admin");
        //    IdentityRole role3 = new IdentityRole("Member");

        //    await _roleManager.CreateAsync(role1);
        //    await _roleManager.CreateAsync(role2);
        //    await _roleManager.CreateAsync(role3);

        //    return Ok("Rollar Yarandi");
        //}

        //public async Task<IActionResult> AddRoleAdmin()
        //{
        //    User admin = await _userManager.FindByNameAsync("Admin1");

        //    await _userManager.AddToRoleAsync(admin, "SuperAdmin");

        //    return Ok("rol elave olundu");
        //}
    }
}
