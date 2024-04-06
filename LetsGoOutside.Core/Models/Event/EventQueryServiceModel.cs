using LetsGoOutside.Core.Models.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoOutside.Core.Models.Event
{
    public class EventQueryServiceModel
    {
        public int TotalEventsCount { get; set; }

        public IEnumerable<EventServiceModel> Events { get; set; } = new List<EventServiceModel>();
    }
}
