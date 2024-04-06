using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoOutside.Core.Models.Home
{
    public class IndexEventModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string BriefIntroduction { get; set; } = null!;
        public string OrganizerName { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public string StartDate { get; set; } = null!;
        public string EndDate { get; set; } = null!;
    }
}
