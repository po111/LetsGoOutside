using LetsGoOutside.Attributes;
using LetsGoOutside.Core.Contracts;
using LetsGoOutside.Core.Models.Author;
using LetsGoOutside.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using static LetsGoOutside.Core.Constants.MessageConstants;


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
        [NotAuthor]
        public IActionResult Become()
        {
            var model = new BecomeAuthorFormModel();

            return View(model);
        }

        [HttpPost]
        [NotAuthor]
        public async Task<IActionResult> Become(BecomeAuthorFormModel model)
        {
           
            if (await authorService.AuthorWithSameNameExistsAsync(model.Name))
            {
                ModelState.AddModelError(nameof(model.Name), NameExists);
            }

            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            await authorService.CreateAsync(User.Id(), model.Name);

            return RedirectToAction(nameof(ArticleController.All), "Article");
        }
    }
}
