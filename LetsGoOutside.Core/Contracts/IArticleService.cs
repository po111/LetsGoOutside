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
            int articlesPerPage = 3);

        Task<IEnumerable<string>> AllCategoriesNamesAsync();

        Task<IEnumerable<string>> AllWeatherNamesAsync();

        Task<IEnumerable<ArticleServiceModel>> AllArticlesByAuthorIdAsync(int authorId);

        //Task<IEnumerable<ArticleServiceModel>> AllArticlesByUserIdAsync(string userId);

        Task<bool> ExistsAsync(int id);

        Task<ArticleDetailsServiceModel> ArticleDetailsByIdAsync(int id);

        Task EditAsync(int articleId, ArticleEditFormModel model);

        Task<bool> HasAuthorWithIdAsync(int articleId, string userId);

        Task<ArticleFormModel?> GetArticleFormModelByIdAsync(int id);

        Task<ArticleEditFormModel?> GetArticleEditFormModelByIdAsync(int id);

        Task DeleteAsync(int articleId);

        Task<List<int>> GetArticleCategoriesIdsAsync(int articleId);

        Task<List<int>> GetArticleWeathersIdsAsync(int articleId);

        Task ApproveArticleAsync(int articleId);

        Task<IEnumerable<ArticleDetailsServiceModel>> ArticlesForApprovalAsync();
    }
}
