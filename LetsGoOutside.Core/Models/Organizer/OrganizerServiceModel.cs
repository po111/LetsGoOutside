using System.ComponentModel.DataAnnotations;

namespace LetsGoOutside.Core.Models.Organizer
{
    public class OrganizerServiceModel
    {
        [Display(Name ="Уебсайт")]
        public string? UrlWebsite { get; set; }

        [Display(Name ="Телефонен номер")]
        public string PhoneNumber { get; set; } = null!;

        public string Name { get; set; } = null!;
    }
}
