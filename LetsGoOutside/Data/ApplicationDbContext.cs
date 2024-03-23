using LetsGoOutside.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LetsGoOutside.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Weather> Weathers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Author>()
                .HasMany(a => a.Articles)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Organizer>()
                .HasMany(o=>o.Events)
                .WithOne()
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Article>()
                .HasMany(a => a.Categories)
                .WithMany(c=>c.Articles);

            builder.Entity<Article>()
                .HasMany(a => a.Weathers)
                .WithMany(w => w.Articles);
                
            
            base.OnModelCreating(builder);  
        }
    }
}
