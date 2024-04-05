using LetsGoOutside.Core.Enumerations;
using System.ComponentModel.DataAnnotations;

namespace LetsGoOutside.Core.Models.Article
{
    public class AllArticlesQueryModel
    {
        public  int ArticlesPerPage { get; set; } = 3;

        public string Category { get; set; } = null!;

        public string Weather { get; set; } = null!;

        [Display(Name = "Търсене по текст")]
        public string SearchTerm { get; set; } = null!;

        public ArticleSorting Sorting { get; set; }

        public int TotalArticlesCount {get; set; }

        public int CurrentPage { get; set; } = 1;

        public IEnumerable<string> Categories { get; set; } = null!;

        public IEnumerable<string> Weathers { get; set; } = null!;

        public IEnumerable<ArticleServiceModel> Articles { get; set; } = new List<ArticleServiceModel>();
    }
}
