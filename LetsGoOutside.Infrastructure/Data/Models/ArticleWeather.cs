using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LetsGoOutside.Infrastructure.Data.Models
{
    public class ArticleWeather
    {
        public int ArticleId { get; set; }

        [Required]
        [ForeignKey(nameof(ArticleId))]
        public Article Article { get; set; } = null!;

        public int WeatherId { get; set; }

        [Required]
        [ForeignKey(nameof(WeatherId))]
        public Weather Weather { get; set; } = null!;

    }
}
