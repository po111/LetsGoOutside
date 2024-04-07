using LetsGoOutside.Core.Enumerations;
using LetsGoOutside.Core.Models.Article;
using LetsGoOutside.Core.Models.Event;
using LetsGoOutside.Core.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoOutside.Core.Contracts
{
    public interface IEventService
    {
        Task<IEnumerable<IndexEventModel>> LastFourEventsAsync();
        Task<int> CreateAsync(EventFormModel model, int organizerId);

        Task<EventQueryServiceModel> AllAsync(
            string? searchTerm = null,
            EventSorting sorting = EventSorting.Newest,
            int currentPage = 1,
            int eventsPerPage = 1);
        Task<IEnumerable<EventServiceModel>> AllEventsByOrganizerIdAsync(int agentId);

        Task<IEnumerable<EventServiceModel>> AllEventsByUserIdAsync(string userId);

    }
}
