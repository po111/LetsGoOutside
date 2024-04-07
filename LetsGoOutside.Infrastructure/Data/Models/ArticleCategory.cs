using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LetsGoOutside.Infrastructure.Data.Models
{
    public class ArticleCategory
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
