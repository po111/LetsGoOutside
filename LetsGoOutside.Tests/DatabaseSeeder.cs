//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using LetsGoOutside.Infrastructure.Data;
//using LetsGoOutside.Infrastructure.Data.Models;
//using Microsoft.AspNetCore.Identity;

//namespace LetsGoOutside.Tests
//{
//    public static class DatabaseSeeder
//    {
//        public static IdentityUser AuthorUser;
//        public static IdentityUser OrganizerUser;
//        public static IdentityUser GuestUser;

//        public static Organizer Organizer;
//        public static Author Author;

//        public static Category FunCategory;
//        public static Category FoodCategory;

//        public static Weather WinterWeather;
//        public static Weather SummerWeather;

//        public static Article FirstArticle;
//        public static Article SecondArticle;

//        public static Event FirstEvent;
//        public static Event SecondEvent;


//        public static void SeedDatabase(LetsGoOutsideDbContext dbContext)
//        {
//            AuthorUser = new IdentityUser()
//            {
//                Id = "dea12856-c198-4129-b3f3-b893d8395082",
//                UserName = "author1@mail.com",
//                NormalizedUserName = "author1@mail.com",
//                Email = "author1@mail.com",
//                NormalizedEmail = "author1@mail.com",
//                PasswordHash = "AQAAAAEAACcQAAAAEP49N8OuwrpFXA33eK8Ml+pfXMsKckHRGam+SI5M9loUoxBaEzCb7Vnc/96AseaQGw==",
//                ConcurrencyStamp = "36e4cae2-747d-498d-909a-aee20def5225",
//                SecurityStamp = "5c9d9ca3-1963-4a96-b2b0-dcd37e29c167"

//            };

//            OrganizerUser = new IdentityUser()
//            {
//                Id = "d8c87a2b-70f7-4799-86c7-75e882c47894",
//                UserName = "organizer1@mail.com",
//                NormalizedUserName = "organizer1@mail.com",
//                Email = "organizer1@mail.com",
//                NormalizedEmail = "organizer1@mail.com",
//                PasswordHash = "AQAAAAEAACcQAAAAEN1ewgaaGnv+HR53wG31DkwwKl5mRH/PtkUAEjjFc5fbUcEmJSeID+/mPRPt51eUgA==",
//                ConcurrencyStamp = "cf343993-2a63-479a-ab3d-de7929d64102",
//                SecurityStamp = "f1233689-b9ff-41c3-abd7-629172a3fbb3"

//            };

//            GuestUser = new IdentityUser()
//            {
//                Id = "29ebd1a1-6a97-4e4f-bc98-4e8bf1e5825f",
//                UserName = "guest2@mail.com",
//                NormalizedUserName = "guest2@mail.com",
//                Email = "guest2@mail.com",
//                NormalizedEmail = "guest2@mail.com",
//                PasswordHash = "AQAAAAEAACcQAAAAEFl463ivh9fwPZJn1oiC7B/2zjMd5dhkwguWH34FfcNbyAGXELpzqWqoAMHxJOcj1w==",
//                ConcurrencyStamp = "1b79aabb-e315-4d25-bff9-9c06dfbba376",
//                SecurityStamp = "6effd7ec-0ab0-4ce2-91e8-620e45d3eb42"

//            };

//            //var AdminUser1 = new IdentityUser()
//            //{
//            //    Id = "c974417d-38b4-42a6-9133-708d1d7c8b0f",
//            //    UserName = "admin1@mail.com",
//            //    NormalizedUserName = "admin1@mail.com",
//            //    Email = "admin1@mail.com",
//            //    NormalizedEmail = "admin1@mail.com",
//            //    PasswordHash = "AQAAAAEAACcQAAAAEGhvzAZMdi0/t+ktRCXlZl5cGk4JKngxaU0oHN2dxZrL1VXR7vzdNcKpb+12GymAlw==",
//            //    ConcurrencyStamp = "8686c9e5-7e85-4f82-ac06-38af806b8e54",
//            //    SecurityStamp = "87014065-1077-4b85-9842-0fde38fdeb90"
//            //};

//            Author = new Author()
//            {
//                //Id = 1,
//                Name = "Евтим Добринов",
//                DateCreated = DateTime.Now.AddDays(-60),
//                UserId = AuthorUser.Id
//            };

//            Organizer = new Organizer()
//            {
//                //Id=2,
//                PhoneNumber = "+359878394090",
//                Name = "Конна База Войнеговци",
//                BriefPresentation = "Забавления за деца и възрастни. Конна езда, зоокът, стрелба с лък, детски лагери.",
//                DateCreated = DateTime.Now.AddMonths(-3),
//                UrlWebsite = "https://www.facebook.com/BulgarianHorseFriends",
//                UserId = OrganizerUser.Id
//            };

//            FunCategory = new Category()
//            {
//                Id = 1,
//                Name = "Fun"
//            };

//            FoodCategory = new Category()
//            {
//                Id = 2,
//                Name = "Food"
//            };

//            WinterWeather = new Weather()
//            {
//                Id = 1,
//                Name = "Winter"
//            };

//            SummerWeather = new Weather()
//            {
//                Id = 2,
//                Name = "Summer"
//            };

//            FirstArticle = new Article()
//            {
//                Id = 1,
//                Title = " Идея за разходка: Какви билки да си наберем на Еньов ден",
//                BriefIntroduction = "Наближава Еньов ден, казват, че тогава билките придобиват вълшебна сила. Еньовските китки и венци се правят преди изгрев, наричанията и желанията се сбъдват.",
//                Content = "Смята се, че на този ден енергията на Слънцето е най-мощна и по магичен начин се предава на водата и на лековитите треви. Затова основните ритуали тогава са посрещане на изгрева, къпане в росата или близката река, бране на билки и плетене на венци и китки. Еньовден е стар български народен празник, с който се отбелязва лятното слънцестоене. Смята се, че в нощта срещу 24 юни билките имат най-голяма сила. Затова сутринта на Еньовден се берат билки, които ще бъдат използвани през цялата година. Те трябва да са \"77 и половина\", колкото са и болестите по човека.",
//                ImageUrl = "https://www.tialoto.bg/media/files/resized/article/615x348/5fd/aabca29c4bab382f78d77180ab1635fd-sunset-5314285-1920.jpg",
//                DateCreated = DateTime.Now.AddDays(-10),
//                HyperlinkSource = "https://dariknews.bg/novini/liubopitno/lechebnite-bilki-se-berat-na-eniovden-video-2274136",
//                AuthorId = Author.Id,
//            };

//            FirstEvent = new Event()
//            {
//                Id = 1,
//                Title = "Водопад Скакля, Връх Була, Сърбеница и Скален Феномен Стола",
//                BriefIntroduction = "Живописен планински преход из малко познатия западен дял на Балкана ",
//                Description = "През град Своге се отправяме към внушителния Искърски пролом и рида Препасница на Понор планина. \r\nС Вазовата еко пътека и приказната каскада на водопада Бовска Скакля, започва разходката ни, из този малко познат дял на Балкана. \r\nСлед кратка почивка в село Заселе продължаваме нагоре, към огледния връх Була. \r\nПродължаваме към първенеца на рида - Връх Сърбеница, сред лабиринт от куполообразни върхове, „препасани“ с внушителни скални откоси от варовик и бездънните кратери на огромните понори между тях.",
//                Address = "Тръгване: от София, Централна гара",
//                ImageUrl = "https://poplaninigori.com/components/com_rseventspro/assets/images/events/thumbs/660/00a2c885491f0637c1e5d6b92ff8a709.jpg",
//                DateCreated = DateTime.Now.AddDays(-30),
//                StartDate = DateTime.Parse("2024-04-27 07:00:00"),
//                EndDate = DateTime.Parse("2024-04-27 18:00:00"),
//                EventHyperlink = "https://poplaninigori.com/index.php/excursions/98-vodopad-skakla-vr-h-bula-s-rbenica-i-skalen-fenomen-stola",
//                OrganizerId = Organizer.Id
//            };

//            dbContext.Users.Add(AuthorUser);
//            dbContext.Users.Add(OrganizerUser);
//            dbContext.Users.Add(GuestUser);

//            dbContext.Articles.Add(FirstArticle);

//            dbContext.Events.Add(FirstEvent);

//            dbContext.Weathers.Add(WinterWeather);
//            dbContext.Weathers.Add(SummerWeather);

//            dbContext.Categories.Add(FunCategory);
//            dbContext.Categories.Add(FoodCategory);

//            dbContext.SaveChanges();
//        }
//    }
//}
