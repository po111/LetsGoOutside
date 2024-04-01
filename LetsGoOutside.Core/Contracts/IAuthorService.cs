using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoOutside.Core.Contracts
{
    public interface IAuthorService
    {
        Task<bool> ExistsByIdAsync(string userId);

        Task<bool> AuthorWithSameNameExistsAsync(string name);

        Task CreateAsync(string userId, string name);
    }
}
