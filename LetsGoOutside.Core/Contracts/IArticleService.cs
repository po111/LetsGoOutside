using LetsGoOutside.Core.Enumerations;
using LetsGoOutside.Core.Models.Article;
using LetsGoOutside.Core.Models.Home;

namespace LetsGoOutside.Core.Contracts
{
    public interface IArticleService
    {
        Task<IEnumerable<IndexArticleModel>> LastFourArticlesAsync();

        Task<IEnumerable<ArticleCategoryServiceModel>> AllCategoriesAsync();

        Task<IEnumerable<ArticleWeatherServiceModel>> AllWeathersAsync();

        Task<bool> CategoryExistsAsync (int categoryId);

        Task<bool> WeatherExistsAsync(int weatherId);

        Task<int> CreateAsync(ArticleFormModel model, int authorId);

        Task<ArticleQueryServiceModel> AllAsync(
            string? category = null,
            string? weather =  null,
            string? searchTerm = null,
            ArticleSorting sorting = ArticleSorting.Newest,
            int currentPage = 1,
            int articlesPerPage = 1);

        Task<IEnumerable<string>> AllCategoriesNamesAsync();
        Task<IEnumerable<string>> AllWeatherNamesAsync();

    }
}
