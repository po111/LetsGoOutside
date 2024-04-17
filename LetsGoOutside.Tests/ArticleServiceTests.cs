using LetsGoOutside.Core.Models.Event;
using LetsGoOutside.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;

namespace LetsGoOutside.Tests
{
    [TestFixture]
    public class ArticleServiceTests : UnitTestsBase
    {

        [Test]
        public async Task ExistAsync_WorksCorrectly()
        {
            var articleToFind = await repository.AllReadOnly<Article>().FirstOrDefaultAsync();

            Assert.That(articleToFind, Is.Not.Null);

            var result = await articleService.ExistsAsync((articleToFind.Id));

            Assert.That(result, Is.True);
        }

        [Test]
        public async Task WeatherExistsAsync_WorksCorrectly()
        {
            var weatherToFind = await repository.AllReadOnly<Weather>().FirstOrDefaultAsync();

            var result = await articleService.WeatherExistsAsync((weatherToFind.Id));

            Assert.That(result, Is.True);

        }

        [Test]
        public async Task CategoryExistsAsync_WorksCorrectly()
        {
            var categoryToFind = await repository.AllReadOnly<Category>().FirstOrDefaultAsync();

            var result = await articleService.CategoryExistsAsync((categoryToFind.Id));

            Assert.That(result, Is.True);

        }



    }
}
