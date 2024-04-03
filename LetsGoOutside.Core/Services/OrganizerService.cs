using LetsGoOutside.Core.Contracts;
using LetsGoOutside.Infrastructure.Data.Common;
using LetsGoOutside.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LetsGoOutside.Core.Services
{
    public class OrganizerService : IOrganizerService
    {
        private readonly IRepository repository;

        public OrganizerService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task CreateAsync(string userId, string phoneNumber, string name, string website = "", string briefPresentation = "")
        {
            await repository.AddAsync(new Organizer()
            {
                UserId = userId,
                Name = name, 
                PhoneNumber = phoneNumber,
                DateCreated = DateTime.Now,
                UrlWebsite = website,
                BriefPresentation = briefPresentation
            });

            await repository.SaveChangesAsync();
        }

        public async Task<bool> ExistsByIdAsync(string userId)
        {
            return await repository.AllReadOnly<Organizer>()
                .AnyAsync(a=>a.UserId == userId);
        }

        public async Task<bool> OrganizerWithPhoneNumberExistsAsync(string phoneNumber)
        {
            return await repository.AllReadOnly<Organizer>()
               .AnyAsync(a => a.PhoneNumber == phoneNumber);
        }

        public async Task<bool> OrganizerWithSameNameExistsAsync(string name)
        {
            return await repository.AllReadOnly<Organizer>()
               .AnyAsync(a => a.Name == name);
        }

        public async Task<int?> GetOrganizerIdAsync(string userId)
        {
            return (await repository.AllReadOnly<Organizer>()
                .FirstOrDefaultAsync(a => a.UserId == userId))?.Id;
        }
    }
}
