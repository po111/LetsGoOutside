using LetsGoOutside.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LetsGoOutside.Infrastructure.Data.SeedDb
{
    internal class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            
            var data = new SeedData();

            builder.HasData(new Article[] { data.FirstArticle/*, data.SecondArticle, data.ThirdArticle, data.ForthArticle, data.FifthArticle */});
        }
    }
}
