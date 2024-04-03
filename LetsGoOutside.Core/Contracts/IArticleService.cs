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

    }
}
