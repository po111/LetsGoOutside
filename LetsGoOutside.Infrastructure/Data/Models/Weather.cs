using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static LetsGoOutside.Infrastructure.Constants.DataConstants;

namespace LetsGoOutside.Infrastructure.Data.Models
{
    [Comment("Appropriate weather")]
    public class Weather
    {

        [Key]
        [Comment("Weather Identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(WeatherNameMaxLength)]
        [Comment("Weather name")]
        public string Name { get; set; } = string.Empty;

        [Comment("List of articles with certain weather type")]
        public virtual ICollection <ArticleWeather> ArticlesWeathers { get; set; } = new List<ArticleWeather>();
    }
}
