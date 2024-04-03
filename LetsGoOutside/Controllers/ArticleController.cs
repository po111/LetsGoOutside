using LetsGoOutside.Attributes;
using LetsGoOutside.Core.Contracts;
using LetsGoOutside.Core.Models.Article;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using static LetsGoOutside.Core.Constants.MessageConstants;

namespace LetsGoOutside.Controllers
{
    public class ArticleController : BaseController
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
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = new AllArticlesQueryModel();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Mine()
        {
            var model = new AllArticlesQueryModel();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = new ArticleDetailsViewModel();

            return View(model);
        }

        [HttpGet]
        [MustBeAuthor]
        public async Task<ActionResult> Add()
        {
            var model = new ArticleFormModel()
            {
                Categories = (List<ArticleCategoryServiceModel>)await articleService.AllCategoriesAsync(),
                Weathers = (List<ArticleWeatherServiceModel>)await articleService.AllWeathersAsync()
            };

            return View(model);
        }

        [HttpPost]
        [MustBeAuthor]
        public async Task<IActionResult> Add(ArticleFormModel model)
        {
            if (model.CategoryIDs.Count() != 0)
            {
                foreach (var categoryIdAsString in model.CategoryIDs)
                {
                    int categoryId = 0;

                    int.TryParse(categoryIdAsString, out categoryId);
                
                if (categoryId==0 ||await articleService.CategoryExistsAsync(categoryId)==false)
                    {
                        ModelState.AddModelError(nameof(model.CategoryIDs), CategoryDoesNotExist);
                    }
                }
            }

            if (model.WeatherIDs.Count() != 0)
            {
                foreach (var weatherIdAsString in model.WeatherIDs)
                {
                    int weatherId = 0;

                    int.TryParse(weatherIdAsString, out weatherId);

                    if (weatherId == 0 || await articleService.WeatherExistsAsync(weatherId)==false)
                    {
                        ModelState.AddModelError(nameof(model.WeatherIDs), WeatherDoesNotExist);
                    }
                }
            }

            if (ModelState.IsValid == false)
            {
                model.Categories = (List<ArticleCategoryServiceModel>)await articleService.AllCategoriesAsync();
                model.Weathers = (List<ArticleWeatherServiceModel>)await articleService.AllWeathersAsync();

                return View(model);
            }

            int? authorId = await authorService.GetAuthorIdAsync(User.Id());

            int newArticleId = await articleService.CreateAsync(model, authorId ?? 0);

            return RedirectToAction(nameof(Details), new { id = newArticleId });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            var model = new ArticleFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, ArticleFormModel model)
        {
            return RedirectToAction(nameof(Details), new { id = "1" });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var model = new ArticleDetailsViewModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ArticleDetailsViewModel model)
        {
            return RedirectToAction(nameof(All));
        }
    }
}
