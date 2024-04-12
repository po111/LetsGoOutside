using LetsGoOutside.Core.Contracts;
using LetsGoOutside.Core.Enumerations;
using LetsGoOutside.Core.Models.Article;
using LetsGoOutside.Core.Models.Home;
using LetsGoOutside.Infrastructure.Data.Common;
using LetsGoOutside.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Globalization;
using System.Linq.Expressions;
using System.Text;
using System.Xml;
using System.Xml.Linq;

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
                .Where(a => a.AuthorId == authorId)
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
                .Include(a => a.ArticlesWeathers)
                    .ThenInclude(aw => aw.Weather)
                    .AsQueryable();

            if (category != null)
            {
                articlesToDisplay = articlesToDisplay
                    .Where(ad => ad.ArticlesCategories
                    .Any(x => x.Category.Name == category));

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
                .Select(c => c.Name)
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

        public async Task<ArticleDetailsServiceModel> ArticleDetailsByIdAsync(int id)
        {
            var article = await repository.AllReadOnly<Article>()
                .Include(a => a.ArticlesCategories)
                .ThenInclude(ac => ac.Category)
                .Include(a => a.ArticlesWeathers)
                .ThenInclude(aw => aw.Weather)
                .Where(a => a.Id == id)
                .FirstAsync();

            var categories = new List<String>();

            foreach (var item in article.ArticlesCategories)
            {
                categories.Add(item.Category.Name);
            }

            var weathers = new List<string>();

            foreach (var item in article.ArticlesWeathers)
            {
                weathers.Add(item.Weather.Name);
            }

            string[] splitContent = article.Content.Split(new string[] { "\r\n", "\n", "\r", Environment.NewLine }, StringSplitOptions.None);

            var model = await repository.AllReadOnly<Article>()
                .Where(a => a.Id == id)
                .Select(a => new ArticleDetailsServiceModel()
                {
                    Id = a.Id,
                    BriefDescription = a.BriefIntroduction,
                    Content = splitContent,
                    ImageUrl = a.ImageUrl,
                    DateCreated = a.DateCreated.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Title = a.Title,
                    AuthorName = a.Author.Name,
                    HyperlinkSource = a.HyperlinkSource,
                    categories = String.Join(", ", categories),
                    weathers = String.Join(", ", weathers)
                })
                .FirstAsync();

            return model;
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

        public async Task DeleteAsync(int articleId)
        {
            await repository.DeleteAsync<Article>(articleId);

            await repository.SaveChangesAsync();
        }

        public async Task EditAsync(int articleId, ArticleEditFormModel model)
        {
            var article = await repository.All<Article>()
                .Where(a => a.Id == articleId)
                .Include(a => a.ArticlesCategories)
                .Include(a => a.ArticlesWeathers)
                .FirstOrDefaultAsync();
                
                //GetByIdAsync<Article>(articleId);

            if (article != null)
            {
                article.Title = model.Title;
                article.Content = model.Content;
                article.BriefIntroduction = model.BriefIntroduction;
                article.ImageUrl = model.ImageUrl;
                article.HyperlinkSource = model.HyperlinkSource;

                List<int> weathers = article.ArticlesWeathers.Select(a => a.WeatherId).ToList();
                List<int> categories = article.ArticlesCategories.Select(a => a.CategoryId).ToList();

                foreach (var categoryId in categories)
                {
                    var toDelete = article.ArticlesCategories.Where(a => a.CategoryId == categoryId).First();

                    article.ArticlesCategories.Remove(toDelete);
                }

                foreach (var weatherId in weathers)
                {
                    //article.ArticlesWeathers.Remove(new ArticleWeather { ArticleId = articleId, WeatherId = weatherId });

                    var toDelete = article.ArticlesWeathers.Where(a => a.WeatherId == weatherId).First();

                    article.ArticlesWeathers.Remove(toDelete);

                }

                await repository.SaveChangesAsync();

                if (model.CategoryIDs.Count() > 0)
                {                
                    foreach (var categoryIdAsString in model.CategoryIDs)
                    {
                        int parsedCategoryId = int.Parse(categoryIdAsString);

                       article.ArticlesCategories.Add(new ArticleCategory { ArticleId = article.Id, CategoryId = parsedCategoryId });
                    }
                }

                if (model.WeatherIDs.Count() > 0)
                {
                    foreach (var weatherId in weathers)
                    {
                        article.ArticlesWeathers.Remove( new ArticleWeather{ ArticleId = articleId, WeatherId = weatherId });
                    }

                    foreach (var weatherIdAsString in model.WeatherIDs)
                    {
                        int parsedWeatherId = int.Parse(weatherIdAsString);

                        article.ArticlesWeathers.Add(new ArticleWeather { ArticleId = article.Id, WeatherId = parsedWeatherId});
                    }
                }
                await repository.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await repository.AllReadOnly<Article>()
                .AnyAsync(a => a.Id == id);
        }

        public async Task<ArticleFormModel?> GetArticleFormModelByIdAsync(int id)
        {
            var article = await repository.AllReadOnly<Article>()
                .Where(a => a.Id == id)
                .Select(a => new ArticleFormModel()
                {
                    Title = a.Title,
                    Content = a.Content,
                    BriefIntroduction = a.BriefIntroduction,
                    //CategoryIDs = a.ArticlesCategories.Select(ac => ac.CategoryId).ToArray(),
                    //WeatherIDs = a.ArticlesWeathers.Select(aw => aw.WeatherId).ToArray(),
                    ImageUrl = a.ImageUrl,
                    HyperlinkSource = a.HyperlinkSource
                })
                .FirstOrDefaultAsync();

            //if (article !=null)
            //{
            //    article.Categories = await AllCategoriesAsync();
            //    article.Weathers = await AllWeathersAsync();
            //}

            return article;

        }

        public async Task<List<int>> GetArticleCategoriesIdsAsync(int articleId)
        {
            var article = await repository.AllReadOnly<Article>()
                .Include(a => a.ArticlesCategories)
                .ThenInclude(ac => ac.Category)
                .Where(a => a.Id == articleId)
                .FirstAsync();

            var categories = new List<int>();
            if (article.ArticlesCategories.Count>0)
            {
                foreach (var item in article.ArticlesCategories)
                {
                    categories.Add(item.CategoryId);
                }
            }
            
            return categories;
        }

        public async Task<bool> HasAuthorWithIdAsync(int articleId, string userId)
        {
            return await repository.AllReadOnly<Article>()
                .AnyAsync(a => a.Id == articleId && a.Author.UserId == userId);
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
                    AuthorName = x.Author.Name,
                    BriefIntroduction = x.BriefIntroduction
                })
                .ToListAsync();
        }

        public async Task<bool> WeatherExistsAsync(int weatherId)
        {
            return await repository.AllReadOnly<Weather>().AnyAsync(c => c.Id == weatherId);
        }

        public async Task<ArticleEditFormModel?> GetArticleEditFormModelByIdAsync(int id)
        {

            var articleCategoryListIds =  new List<int>();
            var articleWeatherListIds  =new List<int>();

            if ((await GetArticleCategoriesIdsAsync(id)).Count>0)
            {
                articleCategoryListIds = await GetArticleCategoriesIdsAsync(id);
            }

            if ((await GetArticleWeathersIdsAsync(id)).Count > 0)
            {
                articleWeatherListIds = await GetArticleWeathersIdsAsync(id);
            }

            var allCategories = await AllCategoriesAsync();
            var allWeathers = await AllWeathersAsync();

            var article = await repository.AllReadOnly<Article>()
                .Where(a => a.Id == id)
                .Select(a => new ArticleEditFormModel()
                {
                    Title = a.Title,
                    Content = a.Content,
                    BriefIntroduction = a.BriefIntroduction,
                    ImageUrl = a.ImageUrl,
                    HyperlinkSource = a.HyperlinkSource,
                    CategoryListIds = articleCategoryListIds,
                    WeatherListIds = articleWeatherListIds,
                    Categories = (List<ArticleCategoryServiceModel>)allCategories,
                    Weathers = (List<ArticleWeatherServiceModel>)allWeathers

                })
                .FirstOrDefaultAsync();

            return article;
        }

        public async Task<List<int>> GetArticleWeathersIdsAsync(int articleId)
        {
            var article = await repository.AllReadOnly<Article>()
                .Include(a => a.ArticlesWeathers)
                .ThenInclude(aw => aw.Weather)
                .Where(a => a.Id == articleId)
                .FirstAsync();

            var weathers = new List<int>();

            if (article.ArticlesWeathers.Count > 0)
            {

                foreach (var item in article.ArticlesWeathers)
                {
                    weathers.Add(item.WeatherId);
                }
            }

            return weathers;
        }
    }
}
