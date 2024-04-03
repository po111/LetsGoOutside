using LetsGoOutside.Core.Contracts;
using LetsGoOutside.Core.Models.Article;
using LetsGoOutside.Core.Models.Home;
using LetsGoOutside.Infrastructure.Data.Common;
using LetsGoOutside.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LetsGoOutside.Core.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IRepository repository;

        public ArticleService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<ArticleCategoryServiceModel>> AllCategoriesAsync()
        {
            return await repository.AllReadOnly<Category>()
                 .Select(c => new ArticleCategoryServiceModel()
                 {
                     Id = c.Id,
                     Name = c.Name
                 })
                 .ToListAsync();
        }

        public async Task<IEnumerable<ArticleWeatherServiceModel>> AllWeathersAsync()
        {
            return await repository.AllReadOnly<Weather>()
                .Select(c => new ArticleWeatherServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToListAsync();
        }

        public async Task<bool> CategoryExistsAsync(int categoryId)
        {
            return await repository.AllReadOnly<Category>().AnyAsync(c => c.Id == categoryId);
        }

        public async Task<int> CreateAsync(ArticleFormModel model, int authorId)
        {
            var article = new Article()
            {
                Title = model.Title,
                BriefIntroduction = model.BriefIntroduction,
                Content = model.Content,
                AuthorId = authorId,
                DateCreated = DateTime.UtcNow,
                ImageUrl = model.ImageUrl,
                HyperlinkSource = model.HyperlinkSource,
            };

            if (model.CategoryIDs.Count() > 0)
            {
                foreach (var categoryIdAsString in model.CategoryIDs)
                {

                    article.ArticlesCategories.Add(new ArticleCategory { ArticleId = article.Id, CategoryId = int.Parse(categoryIdAsString) });
                }
            }

            if (model.WeatherIDs.Count() > 0)
            {
                foreach (var weatherIdAsString in model.WeatherIDs)
                {
                    article.ArticlesWeathers.Add(new ArticleWeather { ArticleId = article.Id, WeatherId = int.Parse(weatherIdAsString) });
                }
            }

            await repository.AddAsync(article);
            await repository.SaveChangesAsync();

            return article.Id;
        }

        public async Task<IEnumerable<IndexArticleModel>> LastFourArticlesAsync()
        {
            return await repository
                .AllReadOnly<Article>()
                .OrderByDescending(x => x.Id)
                .Take(4)
                .Select(x => new IndexArticleModel()
                {
                    Id = x.Id,
                    Title = x.Title,
                    ImageUrl = x.ImageUrl,
                })
                .ToListAsync();
        }

        public async Task<bool> WeatherExistsAsync(int weatherId)
        {
            return await repository.AllReadOnly<Weather>().AnyAsync(c => c.Id == weatherId);
        }
    }
}
