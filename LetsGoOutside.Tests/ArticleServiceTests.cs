using LetsGoOutside.Core.Contracts;
using LetsGoOutside.Core.Services;
using LetsGoOutside.Infrastructure.Data;
using LetsGoOutside.Infrastructure.Data.Common;
using LetsGoOutside.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace LetsGoOutside.Tests
{
    [TestFixture]
    public class ArticleServiceTests
    {
        private IRepository repository;
        private LetsGoOutsideDbContext dbContext;
        private IArticleService articleService;


        [SetUp]
        public void SetUp()
        {
            var configuration = new ConfigurationBuilder()
                .AddUserSecrets<AuthorServiceTests>()
                .Build();

            var connectionString = configuration.GetConnectionString("TestingConnection");

            var contextOptions = new DbContextOptionsBuilder<LetsGoOutsideDbContext>()
                .UseSqlServer(connectionString)
                .Options;

            this.dbContext = new LetsGoOutsideDbContext(contextOptions);
            repository = new Repository(dbContext);
            articleService = new ArticleService(repository);

            dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
        }

        //public string ConvertToAscii(string value)
        //{
        //    var sb = new StringBuilder();
        //    foreach (char c in value)
        //    {
        //        c.
        //    }
        //}

        [Test]

        public async Task Test_AllAuthorsByIdAsync()
        {

            var user = new IdentityUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "author1@mail.com",
                NormalizedUserName = "author1@mail.com",
                Email = "author1@mail.com",
                NormalizedEmail = "author1@mail.com",
                PasswordHash = "AQAAAAEAACcQAAAAEP49N8OuwrpFXA33eK8Ml+pfXMsKckHRGam+SI5M9loUoxBaEzCb7Vnc/96AseaQGw==",
                ConcurrencyStamp = "36e4cae2-747d-498d-909a-aee20def5225",
                SecurityStamp = "5c9d9ca3-1963-4a96-b2b0-dcd37e29c167"

            };



            //await authorService.CreateAsync("dea12856-c198-4129-b3f3-b893d8395082", "Евтим Добринов");

            //var userAuthor = await repository.AllReadOnly<Author>().Where(a => a.UserId == user.Id).FirstOrDefaultAsync();


            //Assert.That(userAuthor.Name, Is.Not.Null, "Author was not saved to DB");
            //Assert.That(userAuthor.UserId, Is.EqualTo(user.Id));
            ////Assert.That(userAuthor.Name,Is.EqualTo("Евтим Добринов"));



            // Assert.Pass();
        }
        //public void Test1()
        //{
        //    Assert.Pass();
        //}
    }
}