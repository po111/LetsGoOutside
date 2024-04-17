using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static LetsGoOutside.Infrastructure.Constants.DataConstants;


namespace LetsGoOutside.Infrastructure.Data.Models

{
    [Comment("Article category")]
    public class Category
    {
        [Key]
        [Comment("Category Identifier")]
        public int Id { get; set; }

        [Required]
        [StringLength(CategoryNameMaxLength)]
        [Comment("Article category name")]
        public string Name { get; set; } = string.Empty;

        [Comment("List of articles with certain category")]
        public virtual ICollection<ArticleCategory> ArticlesCategories { get; set; } = new List<ArticleCategory>();
    }
}
