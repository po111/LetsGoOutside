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
    public class OrganizerService : IOrganizerService
    {
        private readonly IRepository repository;

        public OrganizerService(IRepository _repository)
        {
            repository = _repository;
        }

        public Task CreateAsync(string userId, string phoneNumber, string name, string website = "")
        {
            throw new NotImplementedException();
        }

        public async Task<bool> ExistsByIdAsync(string userId)
        {
            return await repository.AllReadOnly<Organizer>()
                .AnyAsync(a=>a.UserId == userId);
        }

        public Task<bool> OrganizerWithPhoneNumberExistsAsync(string phoneNumber)
        {
            throw new NotImplementedException();
        }

        public Task<bool> OrganizerWithSameNameExistsAsync(string name)
        {
            throw new NotImplementedException();
        }
    }
}
