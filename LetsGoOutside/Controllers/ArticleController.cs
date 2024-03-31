using LetsGoOutside.Core.Models.Article;
using LetsGoOutside.Core.Models.Event;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Formats.Asn1;

namespace LetsGoOutside.Controllers
{
    [Authorize]
    public class ArticleController : Controller
    {
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
        public ActionResult Add() 
        { 
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ArticleFormModel model)
        {
            return RedirectToAction(nameof(Details), new { id = "1" });
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
