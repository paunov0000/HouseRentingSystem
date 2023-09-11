using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models;
using HouseRentingSystem.Core.Models.Home;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HouseRentingSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHouseService _houseService;
        public HomeController(IHouseService houseService)
        {
            this._houseService = houseService;
        }

        public async Task<IActionResult> Index()
        {
            var houses = await this._houseService.LastThreeHouses();

            return View(houses);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}