namespace LetsGoOutside.Core.Models.Event
{
    public class EventDetailsViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string BriefDescription { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;
    }
}

