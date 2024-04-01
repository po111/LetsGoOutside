using LetsGoOutside.Core.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LetsGoOutside.Controllers
{
    public class OrganizerController : BaseController
    {

        private readonly IOrganizerService organizerService;

        public OrganizerController(IOrganizerService _organizerService)
        {
            organizerService = _organizerService;       
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
