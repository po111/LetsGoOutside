using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LetsGoOutside.Infrastructure.Constants.DataConstants;
using static LetsGoOutside.Core.Constants.MessageConstants;

namespace LetsGoOutside.Core.Models.Event
{
    public class EventFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(EventTitleMaxLength,
            MinimumLength = EventTitleMinLength,
            ErrorMessage = LengthMessage)]
        [Display(Name = "Заглавие")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(BriefIntroductionMaxLength,
            MinimumLength = BriefIntroductionMinLength,
            ErrorMessage = LengthMessage)]
        [Display(Name = "Кратко представяне")]
        public string BriefIntroduction { get; set; } = string.Empty;


        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(EventDescriptionMaxLength,
            MinimumLength = EventDescriptionMinLength,
            ErrorMessage = LengthMessage)]
        [Display(Name = "Oписание")]
        public string Description { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(EventAddressMaxLength,
            MinimumLength = EventAddressMinLength,
            ErrorMessage = LengthMessage)]
        [Display(Name = "Адрес")]
        public string Address { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Начало на събитието")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Край на събитието")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Снимка")]
        public string ImageUrl { get; set; } = null!;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Линк към събитието")]
        public string EventHyperlink { get; set; } = string.Empty;
    }
}
