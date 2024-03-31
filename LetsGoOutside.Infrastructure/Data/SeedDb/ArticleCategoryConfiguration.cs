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
                new { ArticleId = data.FirstArticle.Id, CategoryId = data.FoodCategory.Id }
                );

        }
    }
}
