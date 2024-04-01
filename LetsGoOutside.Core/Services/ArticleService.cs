using LetsGoOutside.Core.Contracts;
using LetsGoOutside.Core.Models.Home;
using LetsGoOutside.Infrastructure.Data.Common;
using LetsGoOutside.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace LetsGoOutside.Core.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IRepository repository;

        public ArticleService(IRepository _repository)
        {
            repository = _repository;     
        }

        public async Task<IEnumerable<IndexArticleModel>> LastFourArticlesAsync()
        {
            return await repository
                .AllReadOnly<Article>()
                .OrderByDescending(x => x.Id)
                .Take(4)
                .Select(x => new IndexArticleModel()
                {
                    Id = x.Id,
                    Title = x.Title,
                    ImageUrl = x.ImageUrl,
                })
                .ToListAsync();
        }
    }
}
