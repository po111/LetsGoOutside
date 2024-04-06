using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoOutside.Core.Models.Home
{
    public class IndexArticleModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string BriefIntroduction { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;

        public string AuthorName { get; set; } = null!;
    }
}
