using LetsGoOutside.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                new { ArticleId = data.FirstArticle.Id, WeatherId = data.AutumnWeather.Id }
                );
        }

        
    }
}
