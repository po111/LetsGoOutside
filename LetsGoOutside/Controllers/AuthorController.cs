using LetsGoOutside.Core.Models.Author;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;

namespace LetsGoOutside.Controllers
{
    [Authorize]
    public class AuthorController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Become()
        {
            var model = new BecomeAuthorFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Become(BecomeAuthorFormModel model)
        {
            return RedirectToAction(nameof(ArticleController.All), "Article");
        }
    }
}
