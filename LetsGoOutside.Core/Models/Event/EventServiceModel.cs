using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static LetsGoOutside.Core.Constants.MessageConstants;
using static LetsGoOutside.Infrastructure.Constants.DataConstants;

namespace LetsGoOutside.Core.Models.Event
{
    public class EventServiceModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(EventTitleMaxLength,
            MinimumLength = EventTitleMinLength,
            ErrorMessage = LengthMessage)]
        [DisplayName("Заглавие")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(BriefIntroductionMaxLength,
            MinimumLength = BriefIntroductionMinLength,
            ErrorMessage = LengthMessage)]
        [DisplayName("Кратко представяне")]
        public string BriefDescription { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(OrganizerNameMaxLength, MinimumLength = OrganizerNameMinLength, ErrorMessage = LengthMessage)]
        [DisplayName("Организатор")]
        public string OrganizerName { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        
        [DisplayName("Снимка")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        public string StartDate { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        public string EndDate { get; set; } = string.Empty;
    }
}
