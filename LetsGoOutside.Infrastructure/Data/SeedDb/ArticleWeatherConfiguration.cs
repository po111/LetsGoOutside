using LetsGoOutside.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LetsGoOutside.Infrastructure.Data.SeedDb
{
    internal class ArticleWeatherConfiguration : IEntityTypeConfiguration<ArticleWeather>
    {
        public void Configure(EntityTypeBuilder<ArticleWeather> builder)
        {

            builder
                .HasKey(aw => new { aw.WeatherId, aw.ArticleId });

            var data = new SeedData();

            builder.HasData(
                new { ArticleId = data.FirstArticle.Id, WeatherId = data.SpringWeather.Id },
                new { ArticleId = data.FirstArticle.Id, WeatherId = data.SunnyWeather.Id },
                new { ArticleId = data.FirstArticle.Id, WeatherId = data.SummerWeather.Id },
                new { ArticleId = data.FirstArticle.Id, WeatherId = data.HotWeather.Id },
                new { ArticleId = data.FirstArticle.Id, WeatherId = data.AutumnWeather.Id },

                new { ArticleId = data.SecondArticle.Id, WeatherId = data.SpringWeather.Id },
                new { ArticleId = data.SecondArticle.Id, WeatherId = data.SunnyWeather.Id },
                new { ArticleId = data.SecondArticle.Id, WeatherId = data.SummerWeather.Id },
                new { ArticleId = data.SecondArticle.Id, WeatherId = data.HotWeather.Id },
                new { ArticleId = data.SecondArticle.Id, WeatherId = data.AutumnWeather.Id },
                new { ArticleId = data.SecondArticle.Id, WeatherId = data.WinterWeather.Id },
                new { ArticleId = data.SecondArticle.Id, WeatherId = data.SnowyWeather.Id },
                new { ArticleId = data.SecondArticle.Id, WeatherId = data.WindyWeather.Id },
                new { ArticleId = data.SecondArticle.Id, WeatherId = data.ColdWeather.Id },

                new { ArticleId = data.ThirdArticle.Id, WeatherId = data.SpringWeather.Id },
                new { ArticleId = data.ThirdArticle.Id, WeatherId = data.SunnyWeather.Id },
                new { ArticleId = data.ThirdArticle.Id, WeatherId = data.SummerWeather.Id },
                new { ArticleId = data.ThirdArticle.Id, WeatherId = data.AutumnWeather.Id },

                new { ArticleId = data.ForthArticle.Id, WeatherId = data.SpringWeather.Id },
                new { ArticleId = data.ForthArticle.Id, WeatherId = data.SunnyWeather.Id },
                new { ArticleId = data.ForthArticle.Id, WeatherId = data.SummerWeather.Id },
                new { ArticleId = data.ForthArticle.Id, WeatherId = data.HotWeather.Id },
                new { ArticleId = data.ForthArticle.Id, WeatherId = data.AutumnWeather.Id },
                new { ArticleId = data.ForthArticle.Id, WeatherId = data.WinterWeather.Id },
                new { ArticleId = data.ForthArticle.Id, WeatherId = data.SnowyWeather.Id },
                new { ArticleId = data.ForthArticle.Id, WeatherId = data.ColdWeather.Id },

                new { ArticleId = data.FifthArticle.Id, WeatherId = data.SpringWeather.Id },
                new { ArticleId = data.FifthArticle.Id, WeatherId = data.SunnyWeather.Id },
                new { ArticleId = data.FifthArticle.Id, WeatherId = data.SummerWeather.Id },
                new { ArticleId = data.FifthArticle.Id, WeatherId = data.HotWeather.Id },
                new { ArticleId = data.FifthArticle.Id, WeatherId = data.AutumnWeather.Id },
                new { ArticleId = data.FifthArticle.Id, WeatherId = data.WinterWeather.Id },
                new { ArticleId = data.FifthArticle.Id, WeatherId = data.SnowyWeather.Id },
                new { ArticleId = data.FifthArticle.Id, WeatherId = data.ColdWeather.Id },
                new { ArticleId = data.FifthArticle.Id, WeatherId = data.WindyWeather.Id },
                new { ArticleId = data.FifthArticle.Id, WeatherId = data.WetWeather.Id }
                );
        }
    }
}
