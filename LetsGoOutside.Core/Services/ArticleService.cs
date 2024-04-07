using LetsGoOutside.Core.Contracts;
using LetsGoOutside.Core.Enumerations;
using LetsGoOutside.Core.Models.Article;
using LetsGoOutside.Core.Models.Home;
using LetsGoOutside.Infrastructure.Data.Common;
using LetsGoOutside.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Xml;

namespace LetsGoOutside.Core.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IRepository repository;

        public ArticleService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<IEnumerable<ArticleServiceModel>> AllArticlesByAuthorIdAsync(int authorId)
        {
            return await repository.AllReadOnly<Article>()
                .Where(a=>a.AuthorId== authorId)
                .ProjectToArticleServiceModel()
                .ToListAsync();
        }

        public Task<IEnumerable<ArticleServiceModel>> AllArticlesByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<ArticleQueryServiceModel> AllAsync(
            string? category = null,
            string? weather = null,
            string? searchTerm = null,
            ArticleSorting sorting = ArticleSorting.Newest,
            int currentPage = 1,
            int articlesPerPage = 1)
        {

            var articlesToDisplay = repository.AllReadOnly<Article>()
                .Include(a => a.ArticlesCategories)
                     .ThenInclude(ac => ac.Category)
                     //.ThenInclude(c => c.Name)
                .Include(a => a.ArticlesWeathers)
                    .ThenInclude(aw => aw.Weather)
                    //.ThenInclude(w => w.Name)
                    .AsQueryable();
            //    .ToList();

            if (category != null)
            {
                articlesToDisplay = articlesToDisplay
                    .Where(ad => ad.ArticlesCategories
                    .Any(x=>x.Category.Name==category));
                    //.Where(ac => ac.Category)
                    //    .Where(ac => ac.Category.Name == category);
                        //.Select(articlesToDisplay=>articlesToDisplay);

                //Search by Id/Category entity found
                //var categoryToBeFound = repository.AllReadOnly<Category>()
                //       .Where(c => c.Name == category).First();

                //articlesToDisplay = articlesToDisplay
                //    .Where(a => a.ArticlesCategories.Any(ac => ac.Category.Id == categoryToBeFound.Id));
                    
            }

            if (weather != null)
            {
                articlesToDisplay = articlesToDisplay
                    .Where(ad => ad.ArticlesWeathers
                    .Any(aw => aw.Weather.Name == weather));
                    //.Where(aw => aw.Weather.Name == weather);
            }

            if (searchTerm != null)
            {
                string normalizedSearchTerm = searchTerm.ToLower();
                articlesToDisplay = articlesToDisplay
                    .Where(a => (a.Title.ToLower().Contains(normalizedSearchTerm)
                            || a.Content.ToLower().Contains(normalizedSearchTerm)));
            }

            articlesToDisplay = sorting switch
            {
                ArticleSorting.Author => articlesToDisplay
                    .OrderBy(a => a.Author.Name)
                    .ThenByDescending(a => a.Id),
                ArticleSorting.Title => articlesToDisplay
                    .OrderBy(a => a.Title)
                    .ThenByDescending(a => a.Id),
                ArticleSorting.Oldest => articlesToDisplay
                    .OrderBy(a => a.Id),
                _ => articlesToDisplay
                .OrderByDescending(a => a.Id)
            };

            var articles = await articlesToDisplay
                .Skip((currentPage - 1) * articlesPerPage)
                .Take(articlesPerPage)
                .ProjectToArticleServiceModel()
                //{
                //    Id = a.Id,
                //    Title = a.Title,
                //    BriefDescription = a.BriefIntroduction,
                //    AuthorName = a.Author.Name,
                //    ImageUrl = a.ImageUrl,

                //})
                .ToListAsync();

            int articlesCount = await articlesToDisplay.CountAsync();

            return new ArticleQueryServiceModel()
            {
                Articles = articles,
                TotalArticlesCount = articlesCount
            };
    }

    //public async Task<int> GetCategoryIdByNameAsync(string categoryName)
    //{

    //    var categoryToBeFound = await repository.AllReadOnly<Category>()
    //        .FirstOrDefaultAsync(c => c.Name == categoryName);


    //    return categoryToBeFound.Id();
    //}

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

    public async Task<IEnumerable<string>> AllCategoriesNamesAsync()
    {
            return await repository.AllReadOnly<Category>()
                .Select(c=>c.Name)
                .Distinct()
                .ToListAsync();
    }

    public async Task<IEnumerable<string>> AllWeatherNamesAsync()
    {
            return await repository.AllReadOnly<Weather>()
                    .Select(c => c.Name)
                    .Distinct()
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
                AuthorName = x.Author.Name
            })
            .ToListAsync();
    }

    public async Task<bool> WeatherExistsAsync(int weatherId)
    {
        return await repository.AllReadOnly<Weather>().AnyAsync(c => c.Id == weatherId);
    }
}
}
