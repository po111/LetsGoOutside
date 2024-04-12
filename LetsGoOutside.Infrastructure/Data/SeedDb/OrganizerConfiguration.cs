using LetsGoOutside.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LetsGoOutside.Infrastructure.Data.SeedDb
{
    internal class OrganizerConfiguration : IEntityTypeConfiguration<Organizer>
    {
        public void Configure(EntityTypeBuilder<Organizer> builder)
        {
            var data = new SeedData();

            builder.HasData(new Organizer[] { data.Organizer1, data.Organizer2, data.Organizer3, data.Organizer4, data.AdminOrganizer1 });
        }
    }
}
