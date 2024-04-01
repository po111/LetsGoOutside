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

        public Task<bool> AuthorWithSameNameExistsAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(string userId, string name)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsByIdAsync(string userId)
        {
            return await repository.AllReadOnly<Author>()
                .AnyAsync(a => a.UserId == userId);
        }
    }
}
