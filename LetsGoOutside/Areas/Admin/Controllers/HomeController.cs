using Microsoft.AspNetCore.Mvc;

namespace LetsGoOutside.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult ArticlesForReview()
        {
            return View();
        }

        public IActionResult EventsForReview()
        {
            return View();
        }
    }
}
