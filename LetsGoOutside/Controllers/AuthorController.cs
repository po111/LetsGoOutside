using LetsGoOutside.Core.Contracts;
using LetsGoOutside.Core.Models.Author;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using System.Security.Claims;

namespace LetsGoOutside.Controllers
{
    public class AuthorController : BaseController
    {
        private readonly IAuthorService authorService;

        public AuthorController(IAuthorService _authorService)
        {
                authorService = _authorService;
        }

        [HttpGet]
        public async Task<IActionResult> Become()
        {
            if (await authorService.ExistsByIdAsync(User.Id())) 
            {
                return BadRequest();
            }

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
