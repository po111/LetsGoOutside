using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static LetsGoOutside.Infrastructure.Constants.DataConstants;

namespace LetsGoOutside.Infrastructure.Data.Models
{
    [Comment("Article by author")]
    public class Article
    {
        [Key]
        [Comment("Article Identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(ArticleTitleMaxLength)]
        [Comment("Article title")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(BriefIntroductionMaxLength)]
        [Comment("Article brief introduction")]
        public string BriefIntroduction { get; set; } = string.Empty;

        [Required]
        [StringLength(ArticleContentMaxLength)]
        [Comment("Article content")]
        public string Content { get; set; } = string.Empty;

        [Required]
        [Comment("Date of creation")]
        public DateTime DateCreated { get; set; }

        
        //[Comment("Date modified")]
        //public DateTime? DateModified { get; set; }

        [Comment("Article image url")]
        public string? ImageUrl { get; set; }

        [Required]
        [Comment("Author identifier")]
        public int AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public Author Author { get; set; } = null!;

        
        [Comment("List of categories")]
        public List<Category> ArticleCategories { get; set; } =  new List<Category>();

        
        [Comment("List of appropriate weather")]
        public List<Weather> ArticleWeathers { get; set; } = new List<Weather>();

        [Comment("Article source hyperlink")]
        public string HyperlinkSource { get; set; } = string.Empty;

        [Required]
        [Comment("ApprovedByAdmin")]
        public bool IsApproved { get; set; } = false;

        public ICollection<UserArticle> Likes { get; set; } = new List<UserArticle>();




    }
}