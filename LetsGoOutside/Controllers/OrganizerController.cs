using LetsGoOutside.Core.Contracts;
using LetsGoOutside.Core.Models.Author;
using LetsGoOutside.Core.Models.Organizer;
using LetsGoOutside.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LetsGoOutside.Controllers
{
    public class OrganizerController : BaseController
    {

        private readonly IOrganizerService organizerService;

        public OrganizerController(IOrganizerService _organizerService)
        {
            organizerService = _organizerService;       
        }
        [HttpGet]
        public async Task<IActionResult> Become()
        {
            if (await organizerService.ExistsByIdAsync(User.Id()))
            {
                return BadRequest();
            }

            var model = new BecomeOrganizerFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Become(BecomeOrganizerFormModel model)
        {
            return RedirectToAction(nameof(EventController.All), "Event");
        }
    }
}
