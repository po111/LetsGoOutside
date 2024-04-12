using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LetsGoOutside.Infrastructure.Data.SeedDb
{
    internal class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            var data = new SeedData();

            builder.HasData(new IdentityUser[] { data.AuthorUser1, data.AuthorUser2, data.GuestUser1, data.GuestUser2, data.OrganizerUser1, data.OrganizerUser2, data.OrganizerUser3, data.OrganizerUser4, data.AdminUser1 });
        }
    }
}
