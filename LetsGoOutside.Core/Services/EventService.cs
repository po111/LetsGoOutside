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
using System.Globalization;
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
                    .OrderBy(e => e.Organizer.Name),
                EventSorting.Title => eventsToDisplay
                    .OrderBy(e => e.Title),
                EventSorting.StartDate => eventsToDisplay
                    .OrderByDescending(e => e.StartDate)
                    .ThenByDescending(e => e.Id),
                EventSorting.EndDate => eventsToDisplay
                    .OrderByDescending(e => e.EndDate)
                    .ThenByDescending(e => e.Id),
                _ => eventsToDisplay
                .OrderByDescending(e => e.Id)
            };

            var events = await eventsToDisplay
                .Skip((currentPage - 1) * eventsPerPage)
                .Take(eventsPerPage)
                .Select(e => new EventServiceModel()
                {
                    Id = e.Id,
                    Title = e.Title,
                    BriefDescription = e.BriefIntroduction,
                    OrganizerName = e.Organizer.Name,
                    ImageUrl = e.ImageUrl,
                    StartDate = e.StartDate.ToString("dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture),
                    EndDate = e.EndDate.ToString("dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture)
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
                EventHyperlink = model.EventHyperlink,
                Address = model.Address
            };

            await repository.AddAsync(newEvent);
            await repository.SaveChangesAsync();

            return newEvent.Id;
        }

        public async Task<IEnumerable<IndexEventModel>> LastFourEventsAsync()
        {
            return await repository
                .AllReadOnly<Event>()
                .OrderByDescending(e => e.Id)
                .Take(4)
                .Select(e => new IndexEventModel()
                {
                    Id = e.Id,
                    Title = e.Title,
                    BriefIntroduction = e.BriefIntroduction,
                    ImageUrl = e.ImageUrl,
                    OrganizerName = e.Organizer.Name,
                    StartDate = e.StartDate.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture),
                    EndDate = e.EndDate.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture),
                    
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

        public async Task<bool> ExistsAsync(int id)
        {
            return await repository.AllReadOnly<Event>()
                .AnyAsync(e => e.Id == id);
        }

        public async Task<EventDetailsServiceModel> EventDetailsByIdAsync(int id)
        {
            var eventt = await repository.AllReadOnly<Event>()
                .Where(e => e.Id == id)
                .FirstAsync();

            string[] splitDescription = eventt.Description.Split(new string[] { "\r\n", "\n", "\r", Environment.NewLine }, StringSplitOptions.None);

             var model = await repository.AllReadOnly<Event>()
               .Where(e => e.Id == id)
               .Select(e => new EventDetailsServiceModel()
               {
                   Id = e.Id,
                   BriefDescription = e.BriefIntroduction,
                   Description = splitDescription,
                   ImageUrl = e.ImageUrl,
                   StartDate = e.StartDate.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture),
                   EndDate = e.EndDate.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture),
                   Title = e.Title,
                   Address = e.Address,
                   EventHyperlink = e.EventHyperlink,
                   Organizer =  new Models.Organizer.OrganizerServiceModel()
                   {
                       Name = e.Organizer.Name,
                       UrlWebsite = e.Organizer.UrlWebsite,
                       PhoneNumber = e.Organizer.PhoneNumber
                   },
                   OrganizerName = e.Organizer.Name
               })
               .FirstAsync();

            return model;
        }

        public async Task EditAsync(int eventId, EventFormModel model)
        {
            var eventt = await repository.GetByIdAsync<Event>(eventId);

            if (eventt != null)
            {
                eventt.Title = model.Title;
                eventt.Description = model.Description;
                eventt.BriefIntroduction = model.BriefIntroduction;
                eventt.ImageUrl = model.ImageUrl;
                eventt.EventHyperlink = model.EventHyperlink;
                eventt.Address = model.Address;
                eventt.StartDate = model.StartDate;
                eventt.EndDate = model.EndDate;
            }

            await repository.SaveChangesAsync();
        }

        public async Task<bool> HasOrganizerWithIdAsync(int eventId, string userId)
        {
            return await repository.AllReadOnly<Event>()
                .AnyAsync(e => e.Id == eventId && e.Organizer.UserId == userId);
        }

        public async Task<EventFormModel?> GetEventFormModelByIdAsync(int id)
        {
            var eventt = await repository.AllReadOnly<Event>()
                .Where(e => e.Id == id)
                .Select(e => new EventFormModel()
                {
                    Title = e.Title,
                    Description = e.Description,
                    BriefIntroduction = e.BriefIntroduction,
                    ImageUrl = e.ImageUrl,
                    EventHyperlink = e.EventHyperlink,
                    Address = e.Address,
                    StartDate = e.StartDate,
                    EndDate = e.EndDate,
                })
                .FirstOrDefaultAsync();

            return eventt;
        }

        public async Task DeleteAsync(int eventId)
        {
            await repository.DeleteAsync<Event>(eventId);

            await repository.SaveChangesAsync();
        }
    }
}
