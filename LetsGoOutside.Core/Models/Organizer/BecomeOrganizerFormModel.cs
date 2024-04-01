using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static LetsGoOutside.Core.Constants.MessageConstants;
using static LetsGoOutside.Infrastructure.Constants.DataConstants;

namespace LetsGoOutside.Core.Models.Organizer
{
    public class BecomeOrganizerFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(OrganizerPhoneMaxLength, 
            MinimumLength = OrganizerPhoneMinLength, 
            ErrorMessage = LengthMessage)]
        [Display(Name ="Телефонен номер")]
        [Phone]
        public string PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(OrganizerNameMaxLength, 
            MinimumLength = OrganizerNameMinLength, 
            ErrorMessage = LengthMessage)]
        [Display(Name = "Име")]
        public string Name { get; set; } = null!;

        
        public string? BriefPresentation { get; set; } = string.Empty;

        public string? UrlWebsite { get; set; } = string.Empty;
    }
}
