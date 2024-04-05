namespace LetsGoOutside.Core.Models.Article
{
    public class ArticleQueryServiceModel
    {
        public int TotalArticlesCount { get; set; }

        public IEnumerable<ArticleServiceModel> Articles { get; set; } = new List<ArticleServiceModel>();
    }
}
