using LetsGoOutside.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace LetsGoOutside.Areas.Admin.Controllers
{
    public class ArticleController : AdminBaseController
    {

        private readonly IArticleService articleService;

        private readonly IAuthorService authorService;

        public ArticleController(
            IArticleService _articleService,
            IAuthorService _authorService)
        {
            articleService = _articleService;
            authorService = _authorService;
        }
      
        [HttpGet]
        public async Task<IActionResult> Approve()
        {
            var model = await articleService.ArticlesForApprovalAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Approve(int articleId)
        {
            await articleService.ApproveArticleAsync(articleId);

            return RedirectToAction(nameof(Approve));
        }
    }
}
