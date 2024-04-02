using LetsGoOutside.Infrastructure.Data.Models;
using LetsGoOutside.Infrastructure.Data.SeedDb;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static LetsGoOutside.Infrastructure.Data.SeedDb.SeedData;

namespace LetsGoOutside.Infrastructure.Data
{
    public class LetsGoOutsideDbContext : IdentityDbContext
    {
        public LetsGoOutsideDbContext(DbContextOptions<LetsGoOutsideDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            

            //builder.Entity<ArticleCategory>()
            //    .HasOne(ac => ac.Article)
            //    .WithMany(a => a.ArticleCategories)
            //    .HasForeignKey(ac => ac.ArticleId);

            //builder.Entity<ArticleCategory>()
            //    .HasOne(ac => ac.Category)
            //    .WithMany(c => c.ArticleCategories)
            //    .HasForeignKey(ac => ac.CategoryId);
                
            
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new OrganizerConfiguration());
            builder.ApplyConfiguration(new AuthorConfiguration());
            builder.ApplyConfiguration(new WeatherConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new ArticleConfiguration());
            builder.ApplyConfiguration(new ArticleCategoryConfiguration());
            builder.ApplyConfiguration(new ArticleWeatherConfiguration());
            builder.ApplyConfiguration(new EventConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Author> Authors { get; set; } = null!;
        public DbSet<Organizer> Organizers { get; set; } = null!;
        public DbSet<Event> Events { get; set; } = null!;
        public DbSet<Article> Articles { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Weather> Weathers { get; set; } = null!;

        public DbSet<ArticleCategory> ArticlesCategories { get; set; } = null!;
        public DbSet<ArticleWeather> ArticlesWeathers { get; set; } = null!;

    }
}
