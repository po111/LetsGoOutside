using LetsGoOutside.Core.Contracts;
using LetsGoOutside.Core.Models.Home;
using LetsGoOutside.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace LetsGoOutside.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IArticleService articleService;
        private readonly IEventService eventService;

        public HomeController(
            ILogger<HomeController> logger,
            IArticleService _articleService,
            IEventService _eventService
            )
        {
            _logger = logger;
            articleService = _articleService;
            eventService = _eventService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var model1 = await articleService.LastFourArticlesAsync();

            var model2 = await eventService.LastFourEventsAsync();

            var model = new IndexViewModel()
            {
                ArticleModels = (List<IndexArticleModel>)model1,
                EventModels = (List<IndexEventModel>)model2,
            };

            return View(model);
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 400)
            {
                return View("Error400");
            }

            if (statusCode== 401)
            {
                return View("Error 401");
            }
            
            return View();
        }
    }
}
