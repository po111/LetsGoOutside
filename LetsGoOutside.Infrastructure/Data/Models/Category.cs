using LetsGoOutside.Infrastructure.Constants;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public List<Article> CategoryArticles { get; set; } = new List<Article>();
    }
}
