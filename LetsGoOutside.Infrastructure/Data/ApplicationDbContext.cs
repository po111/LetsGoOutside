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

        public DbSet<Author> Authors { get; set; } = null!;
        public DbSet<Organizer> Organizers { get; set; } = null!;
        public DbSet<Event> Events { get; set; } = null!;
        public DbSet<Article> Articles { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Weather> Weathers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
                        
            base.OnModelCreating(builder);  
        }
    }
}
