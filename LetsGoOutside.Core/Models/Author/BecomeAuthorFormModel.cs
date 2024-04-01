using System.ComponentModel.DataAnnotations;
using static LetsGoOutside.Infrastructure.Constants.DataConstants;
using static LetsGoOutside.Core.Constants.MessageConstants;

namespace LetsGoOutside.Core.Models.Author
{
    public class BecomeAuthorFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(AuthorNameMaxLength,
           MinimumLength = AuthorNameMinLength,
           ErrorMessage = LengthMessage)]
        [Display(Name = "Име")]
        public string Name { get; set; } = null!;
    }
}
