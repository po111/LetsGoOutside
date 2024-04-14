using LetsGoOutside.Core.Contracts;
using LetsGoOutside.Core.Models.Admin;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

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
        //public async Task <IActionResult> Mine()
        //{
        //    var userId = User.Id();
        //    int authorId = await authorService.GetAuthorIdAsync(userId) ?? 0;

        //    var myArticles = new MyArticlesViewModel()
        //    {
        //        AddedArticles = await articleService.AllArticlesByAuthorIdAsync(authorId)
        //    };

        //    return View(myArticles);
        //}
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
