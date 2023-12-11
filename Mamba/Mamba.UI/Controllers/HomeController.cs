using Mamba.Business.Services;
using Mamba.Core.Models;
using Mamba.UI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Mamba.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITeamService _teamService;
        public HomeController(ITeamService teamService)
        {
            _teamService = teamService;
        }
        public async Task<IActionResult> Index()
        {
            HomeViewModel model = new HomeViewModel()
            {
                teams = await _teamService.GetAllAsync()
            };
            return View(model);
        }
    }
}



