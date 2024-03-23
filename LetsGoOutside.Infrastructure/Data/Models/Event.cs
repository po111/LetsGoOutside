using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static LetsGoOutside.Infrastructure.Constants.DataConstants;

namespace LetsGoOutside.Infrastructure.Data.Models
{
    [Comment("Organizer's Event")]
    public class Event
    {
        [Key]
        [Comment("Event Identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(EventTitleMaxLength)]
        [Comment("Event title")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(EventDescriptionMaxLength)]
        [Comment("Event description")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [StringLength(EventAddressMaxLength)]
        [Comment("Event address")]
        public string Address { get; set; } = string.Empty;


        [Required]
        [Comment("Date of creation of event")]
        public DateTime DateOfCreation { get; set; }

        [Required]
        [Comment("Date of event")]
        public DateTime DueDate { get; set; }

        [Comment("Event image url")]
        public string? ImageUrl { get; set; }

        [Required]
        [Comment("Organizer identifier")]
        public int OrganizerId { get; set; }

        [ForeignKey(nameof(OrganizerId))]
        public Organizer Organizer { get; set; } = null!;

        [Required]
        [Comment("ApprovedByAdmin")]
        public bool IsApproved { get; set; } = false;
    }
}