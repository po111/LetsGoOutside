using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using static LetsGoOutside.Core.Constants.MessageConstants;
using static LetsGoOutside.Infrastructure.Constants.DataConstants;

namespace LetsGoOutside.Core.Models.Article
{
    public class ArticleServiceModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(ArticleTitleMaxLength,
            MinimumLength = ArticleTitleMinLength,
            ErrorMessage = LengthMessage)]
        [DisplayName("Заглавие")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(BriefIntroductionMaxLength,
            MinimumLength = BriefIntroductionMinLength,
            ErrorMessage = LengthMessage)]
        [DisplayName("Кратко представяне")]
        public string BriefDescription { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [DisplayName("Автор")]
        public string AuthorName { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(AuthorNameMaxLength, MinimumLength =AuthorNameMinLength, ErrorMessage = LengthMessage)]
        [DisplayName("Снимка")]
        public string ImageUrl { get; set; } = string.Empty;
    }
}