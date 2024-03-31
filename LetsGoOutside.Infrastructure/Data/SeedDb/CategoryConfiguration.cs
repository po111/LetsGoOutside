using LetsGoOutside.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LetsGoOutside.Infrastructure.Data.SeedDb
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            var data = new SeedData();

            builder.HasData(new Category[] { data.ActivityCategory, data.FunCategory, data.EducationCategory, data.FoodCategory, data.KidsCategory, data.RelaxCategory });
        }
    }
}
