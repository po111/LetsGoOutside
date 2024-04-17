using LetsGoOutside.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LetsGoOutside.Tests
{
    [TestFixture]
    public class OrganizerServiceTests : UnitTestsBase
    {
        [Test]
        public async Task CreateOrganizer_ShouldWorkCorrect()
        {
            var organizersCount = repository.All<Organizer>().Count();

            var organizerUserId = "1b81cec0-4bce-490c-a858-75d8c8dc2019";

            var newUserTobeOrganizer = new IdentityUser()
            {
                Id = organizerUserId,
                UserName = "newUserOrg@mail.com",
                NormalizedUserName = "newUserOrg@mail.com",
                Email = "newUserOrg@mail.com",
                NormalizedEmail = "newUserOrg@mail.com",
                PasswordHash = "BQAAAAEAACcQAAAAEP49N8OuwrpFXA33eK8Ml+pfXMsKckHRGam+SI5M9loUoxBaEzCb7Vnc/96AseaQGw==",
                ConcurrencyStamp = "46e4cae2-747d-498d-909a-aee20def5225",
                SecurityStamp = "6c9d9ca3-1963-4a96-b2b0-dcd37e29c167"
            };
            await repository.AddAsync(newUserTobeOrganizer);
            await repository.SaveChangesAsync();

            var organizer = new Organizer()
            {
                UserId = organizerUserId,
                Name = "Иван Димитров",
                PhoneNumber = "0888 888 889",
                //DateCreated = DateTime.Now,
                UrlWebsite = "www.google.com",
                BriefPresentation = "Предлагаме игри, веселие и забавни опити, които ще се харесат на малки и големи"
            };

            await organizerService.CreateAsync(organizer.UserId, organizer.PhoneNumber, organizer.Name,
                organizer.UrlWebsite, organizer.BriefPresentation);

            await repository.SaveChangesAsync();

            var organizersCountAfter = repository.All<Organizer>().Count();

            Assert.That(organizersCountAfter, Is.EqualTo(organizersCount + 1), "Organizer Count not bigger");

            var newOrganizerId = await organizerService.GetOrganizerIdAsync(organizerUserId);
            var newlyCreatedOrganizerInDatabase =
                await repository.All<Organizer>().FirstOrDefaultAsync(o => o.Id == newOrganizerId);


            Assert.IsNotNull(newlyCreatedOrganizerInDatabase, "Not create organizer in db");
            Assert.That(newlyCreatedOrganizerInDatabase.UserId, Is.EqualTo(organizer.UserId),
                "CreatedOrganizerUserId different");
            Assert.That(newlyCreatedOrganizerInDatabase.PhoneNumber, Is.EqualTo(organizer.PhoneNumber),
                "Phone number not created");
            Assert.That(newlyCreatedOrganizerInDatabase.Name, Is.EqualTo(organizer.Name), "wrong organizer name");
            Assert.That(newlyCreatedOrganizerInDatabase.UrlWebsite, Is.EqualTo(organizer.UrlWebsite),
                "wrong organizer URL");
            Assert.That(newlyCreatedOrganizerInDatabase.BriefPresentation, Is.EqualTo(organizer.BriefPresentation),
                "wrong organizer presentation");
            Assert.IsNotNull(newlyCreatedOrganizerInDatabase.DateCreated, "null date of creation");

        }

        [Test]
        public async Task OrganizerWithPhoneNumberExistsAsync_ShouldReturnTrueWithValidData()
        {
            var phoneForCheck =
                await repository.AllReadOnly<Organizer>().Select(x => x.PhoneNumber).FirstOrDefaultAsync();

            var result = await organizerService.OrganizerWithPhoneNumberExistsAsync(phoneForCheck);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task ExistById_ShouldReturnTrueWithValidData()
        {
            var UserIdForCheck = await repository.AllReadOnly<Organizer>().Select(x => x.UserId).FirstOrDefaultAsync();

            var result = await organizerService.ExistsByIdAsync(UserIdForCheck);

            Assert.IsTrue(result);
        }

        [Test]
        public async Task OrganizerWithSameNameExist_WorksCorrectly()
        {
            var anyOrganizerName = await repository.AllReadOnly<Organizer>().Select(x => x.Name).FirstOrDefaultAsync();

            var result = await organizerService.OrganizerWithSameNameExistsAsync(anyOrganizerName);

            Assert.IsTrue(result);

        }
    }
}

