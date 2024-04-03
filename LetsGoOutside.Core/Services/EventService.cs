using LetsGoOutside.Core.Contracts;
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
                    ImageUrl = x.ImageUrl,
                    StartDate = x.StartDate.ToString("dd/MM/YYYY HH:mm"),
                    EndDate = x.EndDate.ToString("dd/MM/YYYY HH:mm")
                })
                .ToListAsync();
        }

    }
}
