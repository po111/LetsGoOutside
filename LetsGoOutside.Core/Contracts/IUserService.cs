using LetsGoOutside.Core.Models.Admin.User;

namespace LetsGoOutside.Core.Contracts
{
    public interface IUserService
    {
        Task<string> UserNamesAsync(string userId);

        Task<IEnumerable<UserServiceModel>> AllUsersAsync(); 
    }
}
