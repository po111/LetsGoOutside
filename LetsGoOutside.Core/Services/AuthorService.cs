using LetsGoOutside.Core.Contracts;
using LetsGoOutside.Infrastructure.Data.Common;
using LetsGoOutside.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoOutside.Core.Services
{

    public class AuthorService : IAuthorService
    {
        private readonly IRepository repository;

        public AuthorService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<bool> AuthorWithSameNameExistsAsync(string name)
        {
            return await repository.AllReadOnly<Author>()
                .AnyAsync(a=>a.Name == name);
        }

        public async Task CreateAsync(string userId, string name)
        {
            await repository.AddAsync(new Author()
            {
                UserId = userId,
                Name = name,
                DateCreated = DateTime.Now
            });

            await repository.SaveChangesAsync();
        }

        public async Task<bool> ExistsByIdAsync(string userId)
        {
            return await repository.AllReadOnly<Author>()
                .AnyAsync(a => a.UserId == userId);
        }

        public async Task<int?> GetAuthorIdAsync(string userId)
        {
            return (await repository.AllReadOnly<Author>()
                .FirstOrDefaultAsync(a => a.UserId == userId))?.Id;
        }
    }
}
