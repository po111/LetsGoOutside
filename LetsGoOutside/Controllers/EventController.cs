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
            var userId = User.Id();
            IEnumerable<EventServiceModel> model;

            if (await organizerService.ExistsByIdAsync(userId))
            {
                int organizerId = await organizerService.GetOrganizerIdAsync(userId) ?? 0;
                model = await eventService.AllEventsByOrganizerIdAsync(organizerId);
            }

            else
            {
                return RedirectToAction(nameof(All));
            }

            return View(model);
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            if (await eventService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }
            var model = await eventService.EventDetailsByIdAsync(id);

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
            if (await eventService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            if (await eventService.HasOrganizerWithIdAsync(id, User.Id()) == false)
            {
                return Unauthorized();
            }

            var model = await eventService.GetEventFormModelByIdAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EventFormModel model)
        {
            if (await eventService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            if (await eventService.HasOrganizerWithIdAsync(id, User.Id()) == false)
            {
                return Unauthorized();
            }

            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            await eventService.EditAsync(id, model);

            return RedirectToAction(nameof(Details), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (await eventService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            if (await eventService.HasOrganizerWithIdAsync(id, User.Id()) == false)
            {
                return Unauthorized();
            }

            var eventt = await eventService.EventDetailsByIdAsync(id);

            var model = new EventDetailsViewModel()
            {
                Id = id,
                BriefDescription = eventt.BriefDescription,
                ImageUrl = eventt.ImageUrl,
                Title = eventt.Title,
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(EventDetailsViewModel model)
        {
            if (await eventService.ExistsAsync(model.Id) == false)
            {
                return BadRequest();
            }

            if (await eventService.HasOrganizerWithIdAsync(model.Id, User.Id()) == false)
            {
                return Unauthorized();
            }

            await eventService.DeleteAsync(model.Id);

            return RedirectToAction(nameof(All));
        }
    }
}
