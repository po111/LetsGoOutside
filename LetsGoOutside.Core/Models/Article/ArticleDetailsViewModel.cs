namespace LetsGoOutside.Core.Models.Article
{
    public class ArticleDetailsViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string BriefDescription { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;
    }
}
