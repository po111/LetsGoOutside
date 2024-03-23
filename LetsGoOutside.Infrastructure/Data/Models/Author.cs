using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LetsGoOutside.Infrastructure.Constants.DataConstants;

namespace LetsGoOutside.Infrastructure.Data.Models
{
    [Comment("Author of content")]
    public class Author
    {
        [Key]
        [Comment("Author identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Author Name")]
        [StringLength(AuthorNameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public DateTime DateOfCreation { get; set; }

        [Required]
        [Comment("User Identifier")]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        [Comment("List of author's articles")]
        public IEnumerable<Article> Articles { get; set; } = new List<Article>();
    }
}
