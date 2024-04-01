using LetsGoOutside.Core.Models.Home;

namespace LetsGoOutside.Core.Contracts
{
    public interface IArticleService
    {
        Task<IEnumerable<IndexArticleModel>> LastFourArticlesAsync();

    }
}
