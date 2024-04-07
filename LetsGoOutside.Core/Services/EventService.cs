using LetsGoOutside.Core.Contracts;
using LetsGoOutside.Core.Enumerations;
using LetsGoOutside.Core.Models.Article;
using LetsGoOutside.Core.Models.Event;
using LetsGoOutside.Core.Models.Home;
using LetsGoOutside.Infrastructure.Data.Common;
using LetsGoOutside.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoOutside.Core.Services
{
    public class EventService : IEventService
    {
        private readonly IRepository repository;

        public EventService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<EventQueryServiceModel> AllAsync(string? searchTerm = null, EventSorting sorting = EventSorting.Newest, int currentPage = 1, int eventsPerPage = 1)
        {
            var eventsToDisplay = repository.AllReadOnly<Event>();

            if (searchTerm != null)
            {
                string normalizedSearchTerm = searchTerm.ToLower();
                eventsToDisplay = eventsToDisplay
                    .Where(a => (a.Title.ToLower().Contains(normalizedSearchTerm)
                            || a.Description.ToLower().Contains(normalizedSearchTerm)
                            || a.Address.ToLower().Contains(normalizedSearchTerm)));
            }

            eventsToDisplay = sorting switch
            {
                EventSorting.OrganizerName => eventsToDisplay
                    .OrderBy(a => a.Organizer.Name),
                EventSorting.Title => eventsToDisplay
                    .OrderBy(a => a.Title),
                EventSorting.StartDate => eventsToDisplay
                    .OrderByDescending(a => a.StartDate)
                    .ThenByDescending(a => a.Id),
                EventSorting.EndDate => eventsToDisplay
                    .OrderByDescending(a => a.EndDate)
                    .ThenByDescending(a => a.Id),
                _ => eventsToDisplay
                .OrderByDescending(a => a.Id)
            };

            var events = await eventsToDisplay
                .Skip((currentPage - 1) * eventsPerPage)
                .Take(eventsPerPage)
                .Select(a => new EventServiceModel()
                {
                    Id = a.Id,
                    Title = a.Title,
                    BriefDescription = a.BriefIntroduction,
                    OrganizerName = a.Organizer.Name,
                    ImageUrl = a.ImageUrl,
                    StartDate = a.StartDate.ToString("dd/MM/YYYY hh:mm"),
                    EndDate = a.EndDate.ToString("dd/MM/YYYY hh:mm")

                })
                .ToListAsync();

            int eventsCount = await eventsToDisplay.CountAsync();

            return new EventQueryServiceModel()
            {
                Events = events,
                TotalEventsCount = eventsCount
            };
        }

        public async Task<int> CreateAsync(EventFormModel model, int organizerId)
        {
            var newEvent = new Event()
            {
                Title = model.Title,
                BriefIntroduction = model.BriefIntroduction,
                Description = model.Description,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                OrganizerId = organizerId,
                DateCreated = DateTime.UtcNow,
                ImageUrl = model.ImageUrl,
                EventHyperlink = model.EventHyperlink
            };

            await repository.AddAsync(newEvent);
            await repository.SaveChangesAsync();

            return newEvent.Id;
        }

        public async Task<IEnumerable<IndexEventModel>> LastFourEventsAsync()
        {
            return await repository
                .AllReadOnly<Event>()
                .OrderByDescending(x => x.Id)
                .Take(4)
                .Select(x => new IndexEventModel()
                {
                    Id = x.Id,
                    Title = x.Title,
                    BriefIntroduction = x.BriefIntroduction,
                    ImageUrl = x.ImageUrl,
                    OrganizerName = x.Organizer.Name,
                    StartDate = x.StartDate.ToString("dd/MM/YYYY HH:mm"),
                    EndDate = x.EndDate.ToString("dd/MM/YYYY HH:mm")
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<EventServiceModel>> AllEventsByOrganizerIdAsync(int organizerId)
        {
            return await repository.AllReadOnly<Event>()
                .Where(e => e.OrganizerId == organizerId)
                .ProjectToEventServiceModel()
                .ToListAsync();
        }

        public Task<IEnumerable<EventServiceModel>> AllEventsByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

    }
}
