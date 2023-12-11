using Humanizer.Localisation;
using Mamba.Business.CustomExceptions.common;
using Mamba.Business.Services;
using Mamba.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Mamba.UI.Areas.Manage.Controllers
{
    [Area("manage")]
    public class ProfessionController : Controller
    {
        private readonly IProfessionService _professionService;
        public ProfessionController(IProfessionService professionService)
        {
            _professionService = professionService;
        }
        public async Task<IActionResult> Index()
        {
            List<Profession> allProfessions = await _professionService.GetAllAsync();

            return View(allProfessions);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Profession profession)
        {
            if (!ModelState.IsValid) return View();
            try
            {
                await _professionService.CreateAsync(profession);
            }
            catch (InvalidAlreadyExists ex)
            {
                ModelState.AddModelError(ex.Property, ex.Message);
                return View();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            if (id == null) return NotFound();

            Profession profession = await _professionService.GetByIdAsync(id);

            if (profession == null) return NotFound();

            return View(profession);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Profession profession)

        {
            if (!ModelState.IsValid) return View();

            try
            {
                await _professionService.UpdateAsync(profession);
            }
            catch (InvalidAlreadyExists ex)
            {
                ModelState.AddModelError(ex.Property, ex.Message);
                return View();
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == null) return NotFound();

            try
            {
                await _professionService.Delete(id);
            }
            catch (NullReferenceException)
            {
                return View();

            }
            return Ok();
        }
    }
}
