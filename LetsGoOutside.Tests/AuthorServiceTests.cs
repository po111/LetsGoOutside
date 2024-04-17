using LetsGoOutside.Core.Contracts;
using LetsGoOutside.Core.Services;
using LetsGoOutside.Infrastructure.Data.Common;
using LetsGoOutside.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Moq;


namespace LetsGoOutside.Tests
{
    [TestFixture]
    public class AuthorServiceTests : UnitTestsBase
    {
        //private Mock<IRepository> mockRepository;
        //private IAuthorService authorService;


        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            //authorService = new AuthorService(context);
            //repository = new Repository(context);
        }

        [Test]
        public async Task Test_CreateAsync_And_AuthorWithSameNameExistsAsync_ShouldWorkCorrectly()
        {

            var user = new IdentityUser()
            {
                Id = "cea12856-c198-4129-b3f3-b893d8395082",
                UserName = "author5@mail.com",
                NormalizedUserName = "author5@mail.com",
                Email = "author5@mail.com",
                NormalizedEmail = "author5@mail.com",
                PasswordHash = "AUAAAAEAACcQAAAAEP49N8OuwrpFXA33eK8Ml+pfXMsKckHRGam+SI5M9loUoxBaEzCb7Vnc/96AseaQGw==",
                ConcurrencyStamp = "37e4cae2-747d-498d-909a-aee20def5225",
                SecurityStamp = "5d9d9ca3-1963-4a96-b2b0-dcd37e29c167"

            };

            await authorService.CreateAsync("cea12856-c198-4129-b3f3-b893d8395082", "????? ???????");
            string authorNameForCheck = "????? ???????";


            var userAuthor = await repository.AllReadOnly<Author>().Where(a => a.UserId == user.Id).FirstOrDefaultAsync();


            Assert.That(userAuthor.Name, Is.Not.Null, "Author was not saved to DB");
            Assert.That(userAuthor.UserId, Is.EqualTo(user.Id));
            Assert.That(userAuthor.Name,Is.EqualTo(authorNameForCheck));


            Assert.That(await authorService.AuthorWithSameNameExistsAsync("????? ???????"), Is.True);
        }

        [Test]
        public async Task Test_ExistsByIdAsync_GetAuthorIdAsync()
        {

            var user = new IdentityUser()
            {
                Id = "dea22856-c198-4129-b3f9-b893d8395082",
                UserName = "author5@mail.com",
                NormalizedUserName = "author5@mail.com",
                Email = "author5@mail.com",
                NormalizedEmail = "author5@mail.com",
                PasswordHash = "AQAAAAEAACkQAAAAEP49N8OuwrpFXA33eK8Ml+pfXMsKckHRGam+SI5M9loUoxBaEzCb7Vnc/96AseaQGw==",
                ConcurrencyStamp = "46e4cae2-747d-498d-909a-aee20def5225",
                SecurityStamp = "6c9d9ca3-1963-4a96-b2b0-dcd37e29c167"

            };

            var user2 = new IdentityUser()
            {
                Id = "0a5b107c-064e-469b-8a17-c019568a7d99",
                UserName = "pepe@kkk.kk",
                NormalizedUserName = "PEPE@KKK.KK",
                Email = "pepe@kkk.kk",
                NormalizedEmail = "PEPE@KKK.KK",
                PasswordHash = "AQAAAAEAACcQAAAAENe8EPQr4T9tlcBWAubDl1xUzf3gRb2s624ko4obxCKVjFbrCjSyjsp9Mp+dLkQYFQ==",
                ConcurrencyStamp = "869657d6-fe80-4ck2-9041-e9799b261d9a",
                SecurityStamp = "XQ7FG7YA6I44XERMODGTTI7ZGB5HF6RW"
            };

            await authorService.CreateAsync("dea22856-c198-4129-b3f9-b893d8395082", "???????? ??????");

            var author = await repository.AllReadOnly<Author>().FirstOrDefaultAsync(x => x.UserId == user.Id);
            int authorId = author.Id;

            var existsById = await authorService.ExistsByIdAsync(user.Id);

            Assert.That(existsById, Is.True);
            Assert.That(await authorService.ExistsByIdAsync(user2.Id), Is.False);
            Assert.That(await authorService.GetAuthorIdAsync(user.Id), Is.EqualTo(author.Id));


        }
    }
}