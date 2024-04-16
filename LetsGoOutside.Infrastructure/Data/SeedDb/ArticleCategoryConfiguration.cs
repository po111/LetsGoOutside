using LetsGoOutside.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LetsGoOutside.Infrastructure.Data.SeedDb
{
    internal class ArticleCategoryConfiguration : IEntityTypeConfiguration<ArticleCategory>
    {
        public void Configure(EntityTypeBuilder<ArticleCategory> builder)
        {
            builder
                .HasKey(ac => new { ac.ArticleId, ac.CategoryId });

            var data = new SeedData();

            builder.HasData(
                new { ArticleId = data.FirstArticle.Id, CategoryId = data.KidsCategory.Id },
                new { ArticleId = data.FirstArticle.Id, CategoryId = data.ActivityCategory.Id },
                new { ArticleId = data.FirstArticle.Id, CategoryId = data.FoodCategory.Id },
                new { ArticleId = data.FirstArticle.Id, CategoryId = data.EducationCategory.Id },

                new { ArticleId = data.SecondArticle.Id, CategoryId = data.KidsCategory.Id },
                new { ArticleId = data.SecondArticle.Id, CategoryId = data.RelaxCategory.Id },

                new { ArticleId = data.ThirdArticle.Id, CategoryId = data.KidsCategory.Id },
                new { ArticleId = data.ThirdArticle.Id, CategoryId = data.FunCategory.Id },
                new { ArticleId = data.ThirdArticle.Id, CategoryId = data.ActivityCategory.Id },

                new { ArticleId = data.ForthArticle.Id, CategoryId = data.KidsCategory.Id },
                new { ArticleId = data.ForthArticle.Id, CategoryId = data.FunCategory.Id },
                new { ArticleId = data.ForthArticle.Id, CategoryId = data.RelaxCategory.Id },
                new { ArticleId = data.ForthArticle.Id, CategoryId = data.FoodCategory.Id },

                new { ArticleId = data.FifthArticle.Id, CategoryId = data.KidsCategory.Id },
                new { ArticleId = data.FifthArticle.Id, CategoryId = data.FunCategory.Id },
                new { ArticleId = data.FifthArticle.Id, CategoryId = data.RelaxCategory.Id },
                new { ArticleId = data.FifthArticle.Id, CategoryId = data.EducationCategory.Id }
                );

        }
    }
}
