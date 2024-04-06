using LetsGoOutside.Attributes;
using LetsGoOutside.Core.Contracts;
using LetsGoOutside.Core.Models.Article;
using LetsGoOutside.Core.Models.Event;
using LetsGoOutside.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using static LetsGoOutside.Core.Constants.MessageConstants;

namespace LetsGoOutside.Controllers
{
    public class EventController : BaseController
    {

        private readonly IOrganizerService organizerService;
        private readonly IEventService eventService;

        public EventController(
            IOrganizerService _organizerService,
            IEventService _eventService)
        {
            organizerService = _organizerService;
            eventService = _eventService;
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> All([FromQuery] AllEventsQueryModel model)
        {
            var events = await eventService.AllAsync(
                model.SearchTerm,
                model.Sorting,
                model.EventsPerPage,
                model.CurrentPage);

            model.TotalEventsCount = events.TotalEventsCount;
            model.Events = events.Events;

            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> Mine()
        {
            var model = new AllEventsQueryModel();

            return View(model);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = new EventDetailsViewModel();

            return View(model);
        }

        [HttpGet]
        [MustBeOrganizer]
        public IActionResult Add()
        {
            var model = new EventFormModel();

            return View(model);
        }

        [HttpPost]
        [MustBeOrganizer]
        public async Task<IActionResult> Add(EventFormModel model)
        {
           
            DateTime rightStartDate = DateTime.UtcNow;

            if (DateTime.TryParse(model.StartDate.ToString(), out rightStartDate)==false)
            {
                ModelState.AddModelError(nameof(model.StartDate), DateWrong);
            }

            DateTime rightEndDate = DateTime.UtcNow;

            if (DateTime.TryParse(model.EndDate.ToString(), out rightEndDate) == false)
            {
                ModelState.AddModelError(nameof(model.EndDate), DateWrong);
            }

            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            int? organizerId = await organizerService.GetOrganizerIdAsync(User.Id());

            int newEventId = await eventService.CreateAsync(model, organizerId ?? 0);

            return RedirectToAction(nameof(Details), new { id = newEventId });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            var model = new EventFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EventFormModel model)
        {
            return RedirectToAction(nameof(Details), new { id = "1" });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var model = new EventDetailsViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(EventDetailsViewModel model)
        {
            return RedirectToAction(nameof(All));
        }
    }
}
