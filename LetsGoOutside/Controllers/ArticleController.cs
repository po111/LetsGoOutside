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
        public async Task<IActionResult> All([FromQuery] AllArticlesQueryModel model)
        {
            var articles = await articleService.AllAsync(
                model.Category,
                model.Weather,
                model.SearchTerm,
                model.Sorting,
                model.ArticlesPerPage,
                model.CurrentPage);

            model.TotalArticlesCount = articles.TotalArticlesCount;
            model.Articles = articles.Articles;

            model.Categories = await articleService.AllCategoriesNamesAsync();
            model.Weathers = await articleService.AllWeatherNamesAsync();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Mine()
        {
            var userId = User.Id();
            IEnumerable<ArticleServiceModel> model;

            if (await authorService.ExistsByIdAsync(userId))
            {
                int authorId = await authorService.GetAuthorIdAsync(userId) ?? 0;
                model = await articleService.AllArticlesByAuthorIdAsync(authorId);
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
            if (await articleService.ExistsAsync(id)== false)
            {
                return BadRequest();
            }
            var model = await articleService.ArticleDetailsByIdAsync(id);

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

                    if (categoryId == 0 || await articleService.CategoryExistsAsync(categoryId) == false)
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

                    if (weatherId == 0 || await articleService.WeatherExistsAsync(weatherId) == false)
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
            if(await articleService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            if (await articleService.HasAuthorWithIdAsync(id, User.Id())==false)
            {
                return Unauthorized();
            }

           

            var model = await articleService.GetArticleEditFormModelByIdAsync(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, ArticleEditFormModel model)
        {
            if (await articleService.ExistsAsync(id) == false)
            {
                return BadRequest();
            }

            if (await articleService.HasAuthorWithIdAsync(id, User.Id()) == false)
            {
                return Unauthorized();
            }

            if (model.CategoryIDs.Count() != 0)
            {
                foreach (var categoryIdAsString in model.CategoryIDs)
                {
                    int categoryId = 0;

                    int.TryParse(categoryIdAsString, out categoryId);

                    if (categoryId == 0 || await articleService.CategoryExistsAsync(categoryId) == false)
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

                    if (weatherId == 0 || await articleService.WeatherExistsAsync(weatherId) == false)
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

            await articleService.EditAsync(id, model);

            return RedirectToAction(nameof(Details), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (await articleService.ExistsAsync(id)== false)
            {
                return BadRequest();
            }

            if (await articleService.HasAuthorWithIdAsync(id, User.Id()) ==false)
            {
                return Unauthorized();
            }

            var article =  await articleService.ArticleDetailsByIdAsync(id);

            var model = new ArticleDetailsViewModel()
            {
                Id = id,
                BriefDescription = article.BriefDescription,
                ImageUrl = article.ImageUrl,
                Title = article.Title,
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(ArticleDetailsViewModel model)
        {
            if (await articleService.ExistsAsync(model.Id) == false)
            {
                return BadRequest();
            }

            if (await articleService.HasAuthorWithIdAsync(model.Id, User.Id()) == false)
            {
                return Unauthorized();
            }

            await articleService.DeleteAsync(model.Id);

            return RedirectToAction(nameof(All));
        }
    }
}
