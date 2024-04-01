using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using static LetsGoOutside.Infrastructure.Constants.DataConstants;
using System.Runtime.CompilerServices;

namespace LetsGoOutside.Infrastructure.Data.Models
{
    [Index(nameof(PhoneNumber), IsUnique = true)]
    [Index(nameof(Name), IsUnique = true)]
    [Comment("Organizer of events")]
    public class Organizer
    {
        [Key]
        [Comment("Organizer identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Organizer Name")]
        [StringLength(OrganizerNameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [StringLength(OrganizerBriefPresentationMaxLength)]
        [Comment("Organizer brief presentation")]
        public string? BriefPresentation { get; set; } = string.Empty;

        [Required]
        [StringLength(OrganizerPhoneMaxLength)]
        [Comment("Organizer's phone")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [Comment("Organizer date of creation")]
        public DateTime DateOfCreation { get; set; }

        [Comment("Organizer website")]
        public string? UrlWebsite { get; set; }

        [Required]
        [Comment("User Identifier")]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        [Comment("List of organizer's events")]
        public IEnumerable<Event> Events { get; set; } = new List<Event>();
    }
}
