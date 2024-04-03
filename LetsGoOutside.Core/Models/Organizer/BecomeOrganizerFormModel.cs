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

        
        [Display(Name = "Кратко представяне")]
        public string? BriefPresentation { get; set; } = string.Empty;

        [Display(Name="Уебсайт")]
        //[RegularExpression(@"^((https?|ftp|smtp):\/\/)?(www.)?[a-z0-9]+\.[a-z]+(\/[a-zA-Z0-9#]+\/?)*$", ErrorMessage=WebsiteNotOK)]
        public string? UrlWebsite { get; set; } = string.Empty;
    }
}
