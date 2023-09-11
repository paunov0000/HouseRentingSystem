using HouseRentingSystem.Core.Models.Houses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Controllers
{
    [Authorize]
    public class HousesController : Controller
    {
        [HttpGet]
        [AllowAnonymous]
        public IActionResult All()
        {
            return View(new AllHousesQueryModel());
        }

        [HttpGet]
        public IActionResult Mine()
        {
            return View(new AllHousesQueryModel());
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Details(int id)
        {
            return View(new HouseDetailsViewModel());
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(HouseFormModel model)
        {
            return RedirectToAction(nameof(Details), new {id = "1"});
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(new HouseFormModel());
        }

        [HttpPost]
        public IActionResult Edit(int id, HouseFormModel model)
        {
            return RedirectToAction(nameof(Details), new { id = "1" });
        }

        [HttpPost]
        public IActionResult Delete(HouseDetailsViewModel model)
        {
            return RedirectToAction(nameof(All));
        }

        [HttpPost]
        public IActionResult Rent(int id)
        {
            return RedirectToAction(nameof(Mine));
        }

        [HttpPost]
        public IActionResult Leave(int id)
        {
            return RedirectToAction(nameof(Mine));
        }
    }
}
