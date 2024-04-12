using LetsGoOutside.Core.Models.Organizer;

namespace LetsGoOutside.Core.Models.Event
{
    public class EventDetailsServiceModel : EventServiceModel
    {
        public string[] Description { get; set; } = new string[30];

        public string Address { get; set; } = null!;

        public string? EventHyperlink { get; set; }

        public OrganizerServiceModel Organizer { get; set; } = null!;



    }
}
