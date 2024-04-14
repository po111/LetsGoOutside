using LetsGoOutside.Core.Models.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoOutside.Core.Models.Admin
{
    public class MyArticlesViewModel
    {
        public IEnumerable<ArticleServiceModel> AddedArticles { get; set; } =  new List<ArticleServiceModel>();
    }
}
