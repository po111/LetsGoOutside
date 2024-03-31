using LetsGoOutside.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LetsGoOutside.Infrastructure.Data.SeedDb
{
    internal class EventConfiguration : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder
               .HasOne(e => e.Organizer)
               .WithMany(o => o.Events)
               .HasForeignKey(e => e.OrganizerId)
               .OnDelete(DeleteBehavior.Restrict);


            var data = new SeedData();

            builder.HasData(new Event[] { data.FirstEvent, data.SecondEvent, data.ThirdEvent, data.ForthEvent, data.FifthEvent });
        }
    }
}
