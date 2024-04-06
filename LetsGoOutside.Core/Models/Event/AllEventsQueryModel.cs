using LetsGoOutside.Core.Enumerations;
using LetsGoOutside.Core.Models.Event;
using System.ComponentModel.DataAnnotations;

namespace LetsGoOutside.Core.Models.Event
{
    public class AllEventsQueryModel
    {
        public int EventsPerPage { get; set; } = 3;

        [Display(Name = "Търсене по текст")]
        public string SearchTerm { get; set; } = null!;

        public EventSorting Sorting { get; set; }

        public int TotalEventsCount { get; set; }

        public int CurrentPage { get; set; } = 1;

        public IEnumerable<EventServiceModel> Events { get; set; } = new List<EventServiceModel>();
    }
}
