using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoOutside.Infrastructure.Data.Models
{
    internal class ArticleCategory
    {
        public int ArticleId { get; set; }

        [Required]
        [ForeignKey(nameof(ArticleId))]
        public Article Article { get; set; } = null!;

        public int CategoryId { get; set; }

        [Required]
        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;
    }
}
