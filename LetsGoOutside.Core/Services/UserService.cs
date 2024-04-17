using LetsGoOutside.Core.Contracts;
using LetsGoOutside.Core.Models.Admin.User;
using LetsGoOutside.Infrastructure.Data.Common;
using LetsGoOutside.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LetsGoOutside.Core.Services
{
    public class UserService : IUserService
    {

        private readonly IRepository repository;
        private readonly IAuthorService authorService;
        private readonly IOrganizerService organizerService;

        public UserService(
            IRepository _repository,
            IAuthorService _authorService,
            IOrganizerService _organizerService)
        {
            repository = _repository;
            authorService = _authorService;
            organizerService = _organizerService;

        }
        public async Task<IEnumerable<UserServiceModel>> AllUsersAsync()
        {
            List<UserServiceModel> model = new List<UserServiceModel>();

            var users = await repository.AllReadOnly<IdentityUser>().ToListAsync();

            foreach (var user in users)
            {
                string? authorName = "";
                string? organizerName = "";
                string? phoneNumber = "";

                var maybeAuthorId = await authorService.GetAuthorIdAsync(user.Id) ?? null;
                var maybeOrganizerId = await organizerService.GetOrganizerIdAsync(user.Id) ?? null;

                if (maybeAuthorId != null)
                {
                    authorName = repository.AllReadOnly<Author>().FirstOrDefault(x => x.Id == maybeAuthorId).Name;
                }

                if (maybeOrganizerId != null)
                {
                    var organizer = repository.AllReadOnly<Organizer>().FirstOrDefault(x => x.Id == maybeOrganizerId);
                    organizerName = organizer.Name;
                    phoneNumber = organizer.PhoneNumber;
                }

                UserServiceModel singlemodel = new UserServiceModel()
                {
                    Email = user.Email,
                    AuthorName = authorName,
                    OrganizationName = organizerName,
                    PhoneNumber = phoneNumber,
                    UserIsAuthor = maybeAuthorId != null,
                    UserIsOrganizer = maybeOrganizerId != null
                };

                model.Add(singlemodel);
            }
            return model;
        }

        public async Task<string> UserNamesAsync(string userId)
        {
            string result = string.Empty;
            var user = await repository.GetByIdAsync<IdentityUser>(userId);

            if (user != null)
            {
                result = $"{user.UserName}";
            }
            return result;
        }
    }
}
