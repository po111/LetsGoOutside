using LetsGoOutside.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static LetsGoOutside.Core.Constants.MessageConstants;
using static LetsGoOutside.Infrastructure.Constants.DataConstants;

namespace LetsGoOutside.Core.Models.Article
{
    public class ArticleFormModel
    {
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(ArticleTitleMaxLength, 
            MinimumLength = ArticleTitleMinLength, 
            ErrorMessage = LengthMessage)]
        [Display(Name ="Заглавие")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(BriefIntroductionMaxLength, 
            MinimumLength = BriefIntroductionMinLength,
            ErrorMessage = LengthMessage)]
        [Display(Name = "Кратко представяне")]
        public string BriefIntroduction { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(ArticleContentMaxLength, 
            MinimumLength = ArticleContentMinLength, 
            ErrorMessage = LengthMessage)]
        [Display(Name = "Съдържание")]
        public string Content { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "URL адрес на снимката")]
        public string ImageUrl { get; set; } = null!;
       
        public string? [] CategoryIDs { get; set; } =  new string? [6];

        [Display(Name = "Категории")]
        public List<ArticleCategoryServiceModel> Categories { get; set; } = new List<ArticleCategoryServiceModel>();

        public string? [] WeatherIDs { get; set; } = new string? [10];

        [Display(Name = "Подходящо време")]
        public List<ArticleWeatherServiceModel> Weathers { get; set; } = new List<ArticleWeatherServiceModel>();

        [Display(Name ="Url адрес на източника на статията")]
        public string? HyperlinkSource { get; set; }
    }
}
