using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LetsGoOutside.Core.Contracts;
using LetsGoOutside.Core.Services;
using LetsGoOutside.Infrastructure.Data;
using LetsGoOutside.Infrastructure.Data.Common;
using LetsGoOutside.Infrastructure.Data.Models;
using LetsGoOutside.Tests.Mocks;
using Microsoft.AspNetCore.Identity;
using Moq;

namespace LetsGoOutside.Tests
{
    public class UnitTestsBase
    {
        protected LetsGoOutsideDbContext context;
        public IRepository repository;
        public IAuthorService authorService;
        public IOrganizerService organizerService;
        
        [OneTimeSetUp]

        public void SetUpBase()
        {
            context = DatabaseMock.Instance;
            repository = new Repository(context);
            authorService = new AuthorService(repository);
            organizerService =  new OrganizerService(repository);
            SeedDatabase();
        }


        public static IdentityUser AuthorUser;
        public static IdentityUser OrganizerUser;
        public static IdentityUser GuestUser;

        public static Organizer Organizer;
        public static Author Author;

        public static Category FunCategory;
        public static Category FoodCategory;

        public static Weather WinterWeather;
        public static Weather SummerWeather;

        public static Article FirstArticle;
        public static Article SecondArticle;

        public static Event FirstEvent;
        public static Event SecondEvent;


        private void SeedDatabase()
        {
            AuthorUser = new IdentityUser()
            {
                Id = "0b81cec0-4bce-490c-a858-75d8c8dc2019",
                UserName = "author1@mail.com",
                NormalizedUserName = "author1@mail.com",
                Email = "author1@mail.com",
                NormalizedEmail = "author1@mail.com",
                PasswordHash = "AQAAAAEAACcQAAAAEP49N8OuwrpFXA33eK8Ml+pfXMsKckHRGam+SI5M9loUoxBaEzCb7Vnc/96AseaQGw==",
                ConcurrencyStamp = "36e4cae2-747d-498d-909a-aee20def5225",
                SecurityStamp = "5c9d9ca3-1963-4a96-b2b0-dcd37e29c167"

            };

            OrganizerUser = new IdentityUser()
            {
                Id = "55151a2a-46cf-4d42-a7fb-be0b1f6f6c18",
                UserName = "organizer1@mail.com",
                NormalizedUserName = "organizer1@mail.com",
                Email = "organizer1@mail.com",
                NormalizedEmail = "organizer1@mail.com",
                PasswordHash = "AQAAAAEAACcQAAAAEN1ewgaaGnv+HR53wG31DkwwKl5mRH/PtkUAEjjFc5fbUcEmJSeID+/mPRPt51eUgA==",
                ConcurrencyStamp = "cf343993-2a63-479a-ab3d-de7929d64102",
                SecurityStamp = "f1233689-b9ff-41c3-abd7-629172a3fbb3"

            };

            GuestUser = new IdentityUser()
            {
                Id = "6eb05a7e-629a-4f30-aae8-955703bf6578",
                UserName = "guest2@mail.com",
                NormalizedUserName = "guest2@mail.com",
                Email = "guest2@mail.com",
                NormalizedEmail = "guest2@mail.com",
                PasswordHash = "AQAAAAEAACcQAAAAEFl463ivh9fwPZJn1oiC7B/2zjMd5dhkwguWH34FfcNbyAGXELpzqWqoAMHxJOcj1w==",
                ConcurrencyStamp = "1b79aabb-e315-4d25-bff9-9c06dfbba376",
                SecurityStamp = "6effd7ec-0ab0-4ce2-91e8-620e45d3eb42"

            };

            //var AdminUser1 = new IdentityUser()
            //{
            //    Id = "37be843e-27d6-4d87-a2fd-7da2ea62cf58",
            //    UserName = "admin1@mail.com",
            //    NormalizedUserName = "admin1@mail.com",
            //    Email = "admin1@mail.com",
            //    NormalizedEmail = "admin1@mail.com",
            //    PasswordHash = "AQAAAAEAACcQAAAAEGhvzAZMdi0/t+ktRCXlZl5cGk4JKngxaU0oHN2dxZrL1VXR7vzdNcKpb+12GymAlw==",
            //    ConcurrencyStamp = "8686c9e5-7e85-4f82-ac06-38af806b8e54",
            //    SecurityStamp = "87014065-1077-4b85-9842-0fde38fdeb90"
            //};

            Author = new Author()
            {
                //Id = 1,
                Name = "Евтим Добринов",
                DateCreated = DateTime.Now.AddDays(-60),
                UserId = AuthorUser.Id
            };

            Organizer = new Organizer()
            {
                //Id=2,
                PhoneNumber = "+359878394090",
                Name = "Конна База Войнеговци",
                BriefPresentation = "Забавления за деца и възрастни. Конна езда, зоокът, стрелба с лък, детски лагери.",
                DateCreated = DateTime.Now.AddMonths(-3),
                UrlWebsite = "https://www.facebook.com/BulgarianHorseFriends",
                UserId = OrganizerUser.Id
            };

            FunCategory = new Category()
            {
                Id = 1,
                Name = "Fun"
            };

            FoodCategory = new Category()
            {
                Id = 2,
                Name = "Food"
            };

            WinterWeather = new Weather()
            {
                Id = 1,
                Name = "Winter"
            };

            SummerWeather = new Weather()
            {
                Id = 2,
                Name = "Summer"
            };

            FirstArticle = new Article()
            {
                Id = 1,
                Title = " Идея за разходка: Какви билки да си наберем на Еньов ден",
                BriefIntroduction = "Наближава Еньов ден, казват, че тогава билките придобиват вълшебна сила. Еньовските китки и венци се правят преди изгрев, наричанията и желанията се сбъдват.",
                Content = "Смята се, че на този ден енергията на Слънцето е най-мощна и по магичен начин се предава на водата и на лековитите треви. Затова основните ритуали тогава са посрещане на изгрева, къпане в росата или близката река, бране на билки и плетене на венци и китки. Еньовден е стар български народен празник, с който се отбелязва лятното слънцестоене. Смята се, че в нощта срещу 24 юни билките имат най-голяма сила. Затова сутринта на Еньовден се берат билки, които ще бъдат използвани през цялата година. Те трябва да са \"77 и половина\", колкото са и болестите по човека.",
                ImageUrl = "https://www.tialoto.bg/media/files/resized/article/615x348/5fd/aabca29c4bab382f78d77180ab1635fd-sunset-5314285-1920.jpg",
                DateCreated = DateTime.Now.AddDays(-10),
                HyperlinkSource = "https://dariknews.bg/novini/liubopitno/lechebnite-bilki-se-berat-na-eniovden-video-2274136",
                AuthorId = Author.Id,
            };

            FirstEvent = new Event()
            {
                Id = 1,
                Title = "Водопад Скакля, Връх Була, Сърбеница и Скален Феномен Стола",
                BriefIntroduction = "Живописен планински преход из малко познатия западен дял на Балкана ",
                Description = "През град Своге се отправяме към внушителния Искърски пролом и рида Препасница на Понор планина. \r\nС Вазовата еко пътека и приказната каскада на водопада Бовска Скакля, започва разходката ни, из този малко познат дял на Балкана. \r\nСлед кратка почивка в село Заселе продължаваме нагоре, към огледния връх Була. \r\nПродължаваме към първенеца на рида - Връх Сърбеница, сред лабиринт от куполообразни върхове, „препасани“ с внушителни скални откоси от варовик и бездънните кратери на огромните понори между тях.",
                Address = "Тръгване: от София, Централна гара",
                ImageUrl = "https://poplaninigori.com/components/com_rseventspro/assets/images/events/thumbs/660/00a2c885491f0637c1e5d6b92ff8a709.jpg",
                DateCreated = DateTime.Now.AddDays(-30),
                StartDate = DateTime.Parse("2024-04-27 07:00:00"),
                EndDate = DateTime.Parse("2024-04-27 18:00:00"),
                EventHyperlink = "https://poplaninigori.com/index.php/excursions/98-vodopad-skakla-vr-h-bula-s-rbenica-i-skalen-fenomen-stola",
                OrganizerId = Organizer.Id
            };

            context.Users.Add(AuthorUser);
            context.Users.Add(OrganizerUser);
            context.Users.Add(GuestUser);

            context.Articles.Add(FirstArticle);

            context.Events.Add(FirstEvent);

            context.Weathers.Add(WinterWeather);
            context.Weathers.Add(SummerWeather);

            context.Categories.Add(FunCategory);
            context.Categories.Add(FoodCategory);

            context.SaveChanges();
        }

        [OneTimeTearDown]
        public void TearDownBase()
            => context.Dispose();
    }
}



