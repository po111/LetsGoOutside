using LetsGoOutside.Infrastructure.Data.Models;
using LetsGoOutside.Infrastructure.Data.SeedDb;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static LetsGoOutside.Infrastructure.Data.SeedDb.SeedData;

namespace LetsGoOutside.Infrastructure.Data
{
    public class LetsGoOutsideDbContext : IdentityDbContext
    {
        private bool _seedDb;
        public LetsGoOutsideDbContext(DbContextOptions<LetsGoOutsideDbContext> options, bool seedDb=true)
            : base(options)
        {
            if (!Database.IsRelational())
            {
                Database.EnsureCreated();
            }
            _seedDb = seedDb;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<ArticleCategory>()
                .HasKey(ac => new { ac.ArticleId, ac.CategoryId });

            builder
                .Entity<ArticleWeather>()
                .HasKey(aw => new { aw.WeatherId, aw.ArticleId });

            if (_seedDb)
            {
                builder.ApplyConfiguration(new UserConfiguration());
                builder.ApplyConfiguration(new OrganizerConfiguration());
                builder.ApplyConfiguration(new AuthorConfiguration());
                builder.ApplyConfiguration(new WeatherConfiguration());
                builder.ApplyConfiguration(new CategoryConfiguration());
                builder.ApplyConfiguration(new ArticleConfiguration());
                builder.ApplyConfiguration(new ArticleCategoryConfiguration());
                builder.ApplyConfiguration(new ArticleWeatherConfiguration());
                builder.ApplyConfiguration(new EventConfiguration());
            }
            
            
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
