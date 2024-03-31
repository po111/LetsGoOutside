using LetsGoOutside.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LetsGoOutside.Infrastructure.Data.SeedDb
{
    internal class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            var data = new SeedData();
            builder.HasData(new Author[] { data.Author1, data.Author2 });
        }
    }
}
