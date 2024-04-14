using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoOutside.Core.Models.Article
{
    public class ArticleDetailsServiceModel : ArticleServiceModel
    {

        public string [] Content { get; set; } = null!;

        public string? HyperlinkSource { get; set; }

        public string DateCreated { get; set; } = null!;

        public string? categories { get; set; } 

        public string? weathers { get; set; } 

        public bool IsApproved { get; set; } = false;
    }
}
