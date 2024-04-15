using LetsGoOutside.Core.Models.Article;
using LetsGoOutside.Core.Models.Event;
using LetsGoOutside.Infrastructure.Data.Models;
using System.Globalization;

namespace System.Linq
{
    public static class IQueryableExtension
    {
        public static IQueryable<ArticleServiceModel> ProjectToArticleServiceModel(this IQueryable<Article> articles)
        {
            return articles
                .Select(a => new ArticleServiceModel()
                {
                    Id = a.Id,
                    AuthorName = a.Author.Name,
                    BriefDescription = a.BriefIntroduction,
                    Title = a.Title,
                    ImageUrl = a.ImageUrl

                });
        }

        public static IQueryable<EventServiceModel> ProjectToEventServiceModel(this IQueryable<Event> events)
        {
            return events
                .Select(e => new EventServiceModel()
                {
                    Id = e.Id,
                    OrganizerName = e.Organizer.Name,
                    BriefDescription = e.BriefIntroduction,
                    Title = e.Title,
                    ImageUrl = e.ImageUrl,
                    StartDate = e.StartDate.ToString("dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture),
                    EndDate = e.EndDate.ToString("dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture)

                });
        }

    }
}
