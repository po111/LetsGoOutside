using LetsGoOutside.Core.Models.Event;
using LetsGoOutside.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;

namespace LetsGoOutside.Tests
{
    [TestFixture]
    public class EventServiceTests : UnitTestsBase
    {
        
        [Test]
        public async Task EditEvent_WorkCorrectly()
        {
            var eventToEdit = await repository.AllReadOnly<Event>().FirstOrDefaultAsync();

            var eventFormToEdit = repository.All<Event>().Where(x => x.Id == eventToEdit.Id).Select(x =>
                new EventFormModel()
                {
                    Address = x.Address,
                    Title = x.Title,
                    BriefIntroduction = x.BriefIntroduction,
                    StartDate = x.StartDate,
                    EndDate = x.EndDate,
                    EventHyperlink = x.EventHyperlink,
                    ImageUrl = x.ImageUrl
                });

            Assert.IsNotNull(eventFormToEdit);

            var eventEditedForm = new EventFormModel()
            {
                Address = "Somewhere over the rainbow way up high",
                Title = "If happy little blue birds fly then why can't I",
                BriefIntroduction =
                    "There's a land that I heard of once in a lullaby. Where trouble melt like lemon drops...",
                Description =
                    "Somewhere over the rainbow\r\nWay up high\r\nThere's a land that I heard of\r\nOnce in a lullaby\r\nSomewhere over the rainbow\r\nSkies are blue\r\nAnd the dreams that you dare to dream\r\nReally do come true\r\nSomeday I'll wish upon a star\r\nAnd wake up where the clouds are far behind me\r\nWhere troubles melt like lemon drops\r\nAway above the chimney tops\r\nThat's where you'll find me",
                StartDate = DateTime.Parse("2024-04-26 10:00:00"),
                EndDate = DateTime.Parse("2024-04-27 10:00:00"),
                ImageUrl = "https://th.bing.com/th/id/OIP.v1XsM2atl3NfHhM-cVfOCwHaHa?rs=1&pid=ImgDetMain",
                EventHyperlink = "https://www.amazon.co.uk/Somewhere-Over-Rainbow-Willie-Nelson/dp/B0012GMYYG"
            };

            await eventService.EditAsync(eventToEdit.Id, eventEditedForm);

            var editedEvent = await repository.AllReadOnly<Event>().Where(x => x.Id == eventToEdit.Id).FirstAsync();

            Assert.That(editedEvent.Title, Is.EqualTo(eventEditedForm.Title));
            Assert.That(editedEvent.BriefIntroduction, Is.EqualTo(eventEditedForm.BriefIntroduction));
            Assert.That(editedEvent.Address, Is.EqualTo(eventEditedForm.Address));
            Assert.That(editedEvent.ImageUrl, Is.EqualTo(eventEditedForm.ImageUrl));
            Assert.That(editedEvent.EventHyperlink, Is.EqualTo(eventEditedForm.EventHyperlink));
            Assert.That(editedEvent.StartDate, Is.EqualTo(eventEditedForm.StartDate), "StartDateDiffers");
            Assert.That(editedEvent.EndDate, Is.EqualTo(eventEditedForm.EndDate), "EndDateDiffers");
            Assert.That(editedEvent.Description, Is.EqualTo(eventEditedForm.Description));

        }

        [Test]
        public async Task ExistAsync_WorksCorrectly()
        {
            var eventToFind = await repository.AllReadOnly<Event>().FirstOrDefaultAsync();

            Assert.That(eventToFind, Is.Not.Null);

            var result = await eventService.ExistsAsync((eventToFind.Id));

            Assert.That(result, Is.True);
        }

    }
}
