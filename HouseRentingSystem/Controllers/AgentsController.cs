using HouseRentingSystem.Core.Models.Agents;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Controllers
{
    [Authorize]
    public class AgentsController : Controller
    {
        [HttpGet]
        public IActionResult Become()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Become(BecomeAgentFormModel model)
        {
            return RedirectToAction(nameof(HousesController.All), "Houses");
        }
    }
}
