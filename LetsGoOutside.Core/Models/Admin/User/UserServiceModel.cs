using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoOutside.Core.Models.Admin.User
{
    public class UserServiceModel
    {
        [Display(Name = "Имейл")]
        public string Email { get; set; } = string.Empty;

        [Display(Name="Име на автора")]
        public string? AuthorName { get; set; }

        [Display(Name = "Име на организатора")]
        public string? OrganizationName { get; set; }

        [Display(Name = "Телефонен номер")]
        public string? PhoneNumber { get; set; }

        [Display(Name ="Автор")]
        public bool UserIsAuthor { get; set; }

        [Display(Name ="Организатор")]
        public bool UserIsOrganizer { get; set; }

    }
}
