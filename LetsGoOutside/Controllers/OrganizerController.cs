using LetsGoOutside.Attributes;
using LetsGoOutside.Core.Contracts;
using LetsGoOutside.Core.Models.Organizer;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using static LetsGoOutside.Core.Constants.MessageConstants;

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
        [NotOrganizer]
        public IActionResult Become()
        {
            var model = new BecomeOrganizerFormModel();

            return View(model);
        }

        [HttpPost]
        [NotOrganizer]
        public async Task<IActionResult> Become(BecomeOrganizerFormModel model)
        {
            if (await organizerService.OrganizerWithPhoneNumberExistsAsync(model.PhoneNumber))
            {
                ModelState.AddModelError(nameof(model.PhoneNumber), PhoneExists);
            }

            if (await organizerService.OrganizerWithSameNameExistsAsync(model.Name))
            {
                ModelState.AddModelError(nameof(model.Name), NameExists);
            }

            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            await organizerService.CreateAsync(User.Id(), model.Name, model.PhoneNumber, model.BriefPresentation= "", model.UrlWebsite= "");

            return RedirectToAction(nameof(EventController.All), "Event");
        }
    }
}
