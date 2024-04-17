using LetsGoOutside.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace LetsGoOutside.Areas.Admin.Controllers
{
    public class EventController : AdminBaseController
    {
        private readonly IEventService eventService;

        private readonly IOrganizerService organizerService;

        public EventController(
            IEventService _eventService,
            IOrganizerService _organizerService)
        {
            eventService = _eventService;
            organizerService = _organizerService;
        }

        [HttpGet]
        public async Task<IActionResult> Approve()
        {
            var model = await eventService.EventsForApprovalAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Approve(int eventId)
        {
            await eventService.ApproveEventAsync(eventId);

            return RedirectToAction(nameof(Approve));
        }
    }
}
