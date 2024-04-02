﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LetsGoOutside.Infrastructure.Migrations
{
    public partial class InitialWithDomainEntitiesAndSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Category Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Article category name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                },
                comment: "Article category");

            migrationBuilder.CreateTable(
                name: "Weathers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Weather Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "Weather name")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weathers", x => x.Id);
                },
                comment: "Appropriate weather");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Author identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false, comment: "Author Name"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of creation"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Authors_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Author of content");

            migrationBuilder.CreateTable(
                name: "Organizers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Organizer identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false, comment: "Organizer Name"),
                    BriefPresentation = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Organizer brief presentation"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "Organizer's phone"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Organizer date of creation"),
                    UrlWebsite = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Organizer website"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User Identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Organizer of events");

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Article Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false, comment: "Article title"),
                    BriefIntroduction = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false, comment: "Article brief introduction"),
                    Content = table.Column<string>(type: "nvarchar(max)", maxLength: 7000, nullable: false, comment: "Article content"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of creation"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Article image url"),
                    AuthorId = table.Column<int>(type: "int", nullable: false, comment: "Author identifier"),
                    HyperlinkSource = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Article source hyperlink"),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false, comment: "ApprovedByAdmin")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Article by author");

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Event Identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false, comment: "Event title"),
                    BriefIntroduction = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false, comment: "Event brief introduction"),
                    Description = table.Column<string>(type: "nvarchar(3000)", maxLength: 3000, nullable: false, comment: "Event description"),
                    Address = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false, comment: "Event address"),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Date of creation of event"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Start date of event"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "End date of event"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Event image url"),
                    EventHyperlink = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Event hyperlink"),
                    OrganizerId = table.Column<int>(type: "int", nullable: false, comment: "Organizer identifier"),
                    IsApproved = table.Column<bool>(type: "bit", nullable: false, comment: "ApprovedByAdmin")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_Organizers_OrganizerId",
                        column: x => x.OrganizerId,
                        principalTable: "Organizers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Organizer's Event");

            migrationBuilder.CreateTable(
                name: "ArticlesCategories",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticlesCategories", x => new { x.ArticleId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_ArticlesCategories_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticlesCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ArticlesWeathers",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    WeatherId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticlesWeathers", x => new { x.WeatherId, x.ArticleId });
                    table.ForeignKey(
                        name: "FK_ArticlesWeathers_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticlesWeathers_Weathers_WeatherId",
                        column: x => x.WeatherId,
                        principalTable: "Weathers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "27d63979-ce0b-4250-8473-5ba2251f407e", 0, "7a22b76e-a85b-43bf-a333-a727a5274b2e", "author2@mail.com", false, false, null, "author2@mail.com", "author2@mail.com", "AQAAAAEAACcQAAAAEKgkrVUXAXQCw/tI/wNQIUZdOJBI0hJLxtM/TjHd60lLAF/WNU4qjzGoDoj7x3BgGw==", null, false, "2dd39674-c421-44b5-9e97-4423a1f52b47", false, "author2@mail.com" },
                    { "29ebd1a1-6a97-4e4f-bc98-4e8bf1e5825f", 0, "bb3defc2-ad20-45b7-bda1-ca53e8a3482b", "guest2@mail.com", false, false, null, "guest2@mail.com", "guest2@mail.com", "AQAAAAEAACcQAAAAEFftFMeLGa7nlN0TtFn2JrHomfS+M6s4pJT6ZONKrfU5y30l1RWXoGRgYATEIX9EyQ==", null, false, "bcb60efe-1a9c-43cf-957f-69c0f8611feb", false, "guest2@mail.com" },
                    { "3354c365-9a55-4a7b-a766-4ea59d7cc57c", 0, "2ab28e55-b704-462a-9fc1-be9433630e39", "organizer4@mail.com", false, false, null, "organizer4@mail.com", "organizer4@mail.com", "AQAAAAEAACcQAAAAEJOdpbFPerUT/nDef1088XwxcQ3FNYTjWi89WxWPWeUESihEiOW8r0DU0Ho71u31Hw==", null, false, "127df1e3-35ea-41a1-bd8d-efc487651766", false, "organizer4@mail.com" },
                    { "6528f9a3-a6c1-4fdc-b095-d1f074e33843", 0, "129fb219-4360-43c4-aacb-304859bf4518", "organizer3@mail.com", false, false, null, "organizer3@mail.com", "organizer3@mail.com", "AQAAAAEAACcQAAAAEO6fJxB6qZy/qwK1nh5Woe+Bc1nrLAwc8yv2u5j4e2m1DdSUsD3/kt6nfIPtKKgLnA==", null, false, "ee0ccd5d-bf3b-4794-ab19-a9d721c9d7a6", false, "organizer3@mail.com" },
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "c769d33b-9007-40cb-9655-9839946d9ad5", "guest1@mail.com", false, false, null, "guest1@mail.com", "guest1@mail.com", "AQAAAAEAACcQAAAAEBiWe0QwQ8GqYYeE4TqWyCnzRG/HojLFx/SdGiAyIXBcqBrTq/yauXlsa87hhlZDUQ==", null, false, "daf56beb-a1ee-4f25-b09c-6e35d0ca7035", false, "guest1@mail.com" },
                    { "c38970b5-010c-494b-9621-fe38e520e367", 0, "a272577a-0d8d-459e-9748-695eb6d0deab", "organizer2@mail.com", false, false, null, "organizer2@mail.com", "organizer2@mail.com", "AQAAAAEAACcQAAAAEPKSS3XNipcRixpmPONIwb+ptmnjd2xFIEHHx/EZcmdcW79iWnQKRrJRauR2Zu3ArQ==", null, false, "4a6235ed-f404-4f1c-8711-5c2ebfe889cb", false, "organizer2@mail.com" },
                    { "d8c87a2b-70f7-4799-86c7-75e882c47894", 0, "3d7ad4cd-9f8b-464c-822e-8568e61ef38b", "organizer1@mail.com", false, false, null, "organizer1@mail.com", "organizer1@mail.com", "AQAAAAEAACcQAAAAEKoR1edRYqD/CoEqCsBSffbd1YfCUxTORqbMHk921yun0JUXH6t5yabh07o+bD9Jxg==", null, false, "c4232c3f-31b9-46a5-93bc-fea7e67820be", false, "organizer1@mail.com" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "9a909b91-85de-4dee-a605-127db2d83d83", "author1@mail.com", false, false, null, "author1@mail.com", "author1@mail.com", "AQAAAAEAACcQAAAAECghuFu8Gv+out39haBLy7MeQpxiCxsWkBwgfsP1i/sEANoY0qxniibUb2ugL83+BA==", null, false, "5499d24d-c120-4c54-a9c5-c1c7f228d675", false, "author1@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Fun" },
                    { 2, "Food" },
                    { 3, "Activity" },
                    { 4, "Education" },
                    { 5, "Kids" },
                    { 6, "Relax" }
                });

            migrationBuilder.InsertData(
                table: "Weathers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Winter" },
                    { 2, "Summer" },
                    { 3, "Spring" },
                    { 4, "Autumn" },
                    { 5, "Hot" },
                    { 6, "Cold" },
                    { 7, "Wet" },
                    { 8, "Windy" },
                    { 9, "Sunny" },
                    { 10, "Snowy" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "DateCreated", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 2, 18, 32, 12, 302, DateTimeKind.Local).AddTicks(5643), "Евтим Добринов", "dea12856-c198-4129-b3f3-b893d8395082" },
                    { 2, new DateTime(2024, 3, 13, 18, 32, 12, 302, DateTimeKind.Local).AddTicks(5681), "Лилия Друмева", "27d63979-ce0b-4250-8473-5ba2251f407e" }
                });

            migrationBuilder.InsertData(
                table: "Organizers",
                columns: new[] { "Id", "BriefPresentation", "DateCreated", "Name", "PhoneNumber", "UrlWebsite", "UserId" },
                values: new object[,]
                {
                    { 1, "Забавления за деца и възрастни. Конна езда, зоокът, стрелба с лък, детски лагери.", new DateTime(2024, 1, 2, 18, 32, 12, 234, DateTimeKind.Local).AddTicks(8794), "Конна База Войнеговци", "+359878394090", "https://www.facebook.com/BulgarianHorseFriends", "d8c87a2b-70f7-4799-86c7-75e882c47894" },
                    { 2, "Исторически парк е туристически атракцион за културен туризъм в близост до град Варна, който предлага приключения до 10 000 години назад във времето за цялото семейство.", new DateTime(2024, 2, 2, 18, 32, 12, 234, DateTimeKind.Local).AddTicks(8807), "Исторически парк", "+359896840615", "https://ipark.bg", "c38970b5-010c-494b-9621-fe38e520e367" },
                    { 3, "Какво ще откриете тук? Планински преходи и пешеходни екскурзии за всички - пешеходни разходки в планината, по-тежички планински преходи, както и нови върхове и приключения за най-подготвените планинари.", new DateTime(2024, 1, 18, 18, 32, 12, 234, DateTimeKind.Local).AddTicks(8811), "По планини и гори", "+359889215722", "https://poplaninigori.com", "6528f9a3-a6c1-4fdc-b095-d1f074e33843" },
                    { 4, "Приключенски парк Коколандия е място с екстремно-развлекателен характер. :Въжените кръгове са подходящи за деца над 6 години. За по-малките сме приготвили други зававления съобразно възрастта им. Разполагаме с въжени съоръжения, въжеландия, трийтоп и други.", new DateTime(2023, 12, 26, 18, 32, 12, 234, DateTimeKind.Local).AddTicks(8815), "Коколандия", "+359899966970", "https://kokolandia.com", "3354c365-9a55-4a7b-a766-4ea59d7cc57c" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "AuthorId", "BriefIntroduction", "Content", "DateCreated", "HyperlinkSource", "ImageUrl", "IsApproved", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Наближава Еньов ден, казват, че тогава билките придобиват вълшебна сила. Еньовските китки и венци се правят преди изгрев, наричанията и желанията се сбъдват.", "Смята се, че на този ден енергията на Слънцето е най-мощна и по магичен начин се предава на водата и на лековитите треви. Затова основните ритуали тогава са посрещане на изгрева, къпане в росата или близката река, бране на билки и плетене на венци и китки. Еньовден е стар български народен празник, с който се отбелязва лятното слънцестоене. Смята се, че в нощта срещу 24 юни билките имат най-голяма сила. Затова сутринта на Еньовден се берат билки, които ще бъдат използвани през цялата година. Те трябва да са \"77 и половина\", колкото са и болестите по човека. От набраните билки, между които на първо място е еньовчето, жените правят еньовски китки и венци, вързани с червен конец. Ето и някои лечебни билки, които можем да съберем на Еньовден: \r\nЛайка\r\nЦветовете на лайката са изключително полезни и пълни с витамини, минерали и флавоноиди. Чаят се препоръчва при детоксикация, за пречистване на кръвта и намаляване на холесторола, както и за подобряване на стомашно-чревния тракт. Лайката има изключително успокояващо действие и е идеална за подобряване на съня.\r\nБял равнец \r\nНаричат го „бяло еньовче“, като билката има 7 разновидности и всички те са лековити. Чаят от бял равнец помага за регулиране на менструацията и хормоните при менопауза. Има кръвосъсирващ и болкоуспокояващ ефект и помага при гастрит, язва, ревматични болки и простуда. Равнецът регулира обмяната на веществата, стимулира работата на бъбреците и успокоява подуването на стомаха. \r\nЖълт кантарион \r\nБлагодарение на фитохимикала хиперицин, жълтият кантарион е често използван за успокояване на нервите, както и при леки депресивни състояния. Билката помага при гастрит, проблеми със стомаха, сърцебиене, главоболие и раздразнителност.\r\nЕньовче \r\nЖълтото растение е символ на Еньовден. Билката изчиства тялото от токсини, премахва камъни в бъбреците и помага при проблеми с простата и пикочните пътища. Компресите, направени с настойка от еньовче помагат при кожни възпаления – ожулвания, язви и изгаряния.\r\nМащерка \r\nАнтиоксидантните флавоноиди, терпинен и бета каротин в мащерката предпазват от инфекции и понижават възпаленията в тялото. Билката успокоява дихателните пътища и подобрява устната хигиена. Мащерката помага за намаляване на вредните бактерии, които са в основата на образуването на гъбичките.\r\nЛипа \r\nСъдържа голяма количество витамини, антиоксиданти, флавоноиди, клей, танини и етерични масла, които облекчават състоянието ни при грип и настинка и успокояват нервната система. Липата стимулира храносмилането, бори се с инфекциите на пикочните пътища и намалява риска от хипертония и сърдечно-съдови заболявания.", new DateTime(2024, 3, 23, 18, 32, 12, 507, DateTimeKind.Local).AddTicks(4252), "https://dariknews.bg/novini/liubopitno/lechebnite-bilki-se-berat-na-eniovden-video-2274136", "https://www.tialoto.bg/media/files/resized/article/615x348/5fd/aabca29c4bab382f78d77180ab1635fd-sunset-5314285-1920.jpg", false, " Идея за разходка: Какви билки да си наберем на Еньов ден" },
                    { 2, 2, "В София има невероятни кътчета, където лесно можем да забравим за забързаното ежедневие. Освен парковете, градините на София са сред любимите места на жителите на града и истински дар от природата. Те ни дават онзи свеж, нежен полъх, който ражда у нас прекрасни емоции и незабравими моменти.", "В София има невероятни кътчета, където лесно можем да забравим за забързаното ежедневие. Освен парковете,градините на София са сред любимите места на жителите на града и истински дар от природата. Те ни дават онзи свеж, нежен полъх, който ражда у нас прекрасни емоции и незабравими моменти.\r\nЕто ги 10-те ни любими градини в центъра на София.\r\nГрадинката на \"Кристал\"\r\nНамира се в непосредствена близост до Народното събрание, Храм \"Св. Александър Невски\", Централен военен клуб, както и до Театър Българска Армия. Градинката носи името на вече несъществуващия ресторант \"Кристал\". След като ресторантът спира да работи, градинката става сборен пункт за редица художници и антиквари.\r\nПаркът е едно от най-харизматичните места за младите хора на София. В него е разположен паметникът на Стефан Стамболов. Тук често се провеждат изложби на открито и културни събития, поради тази причина градинката е и паметник на парковото изкуство. Заради зеленото пространство и алеите си, „Кристал“ е отлично място за отдих. \r\nГрадска градина \r\nГрадската градина е най-старият парк в град София, разположен в центъра на града пред бившия царски дворец в близост до Народният театър, Народната банка, Общината и министерства. Първоначално се е наричал Александровска градина. На територията му има музикална детска площадка, фитнес уреди, ново осветление, добре поддържани градинки и за това парка никога не спи и не затваря очи. Тук се намира и популярният фонтан с бронзовата балерина пред Народния театър. Градината се слави с добрите си шахматисти и организиране на различни събития и изложения. Любимо място за столичани и гостите на града е ледената пързалка. Градината е идеална  за приятна разходка, сладки приказки или спокойствие в средата на натоварен ден.\r\n Градина „Руската църква“\r\nГрадинката се намира непосредствено до Руската църква в гр. София, на ъгъла на бул. \"Цар Освободител\" и ул. \"Г.С. Раковски\". В парка се намира Руската църква „Св. Николай”, която е една от най-забележителните сгради в София. Построена е в периода 1907 – 1914 г. по проект на руския архитект М. Преображенски по инициатива на руското посолство и върху негов парцел. Това става повод паркът да бъде посещаван от много туристи, също така е и задължителна спирка при опознаването на софийските забележителности. В градината се намира и друга забележителност - паметникът на Пушкин.\r\nКняжеска градина\r\nГрадината е с перфектна локация в центъра на града между кръстовището на Софийския университет \"Св. Климент Охридски\", булевард \"Цар Освободител\", Орлов мост, бул. \"Евлоги и Христо Георгиеви\", бул. \"Васил Левски\" и бул. \"Васил Левски\". В нея е разположен паметникът на Съветската армия от 2009г. Княжеска градина е известна с най-разнообразни заведения за хранене, красиви алеи, детски кътове и площадки за игри, фитнес на открито с 18 комбинирани ергономични уреда, които могат да се ползват от деца и възрастни едновременно и др. В парка е изградена и първата площадка за игра и свободно разхождане на домашни любимци в София. Предпочитано място за изложения и концерти.\r\nЦарската градина \r\nЦарската градина се намира зад Националната художествена галерия, която преди е била царски дворец. Царската градина е направена още по време на изграждането на двореца. Паркът около двореца е бил разположен на 18 декара площ и към него имало няколко входа. Днес е запазена малка част от градината. В последните години паркът е изключителен хит за столичани. Красотата на градината става причина за множество сватбени фотосесии. \r\nДокторската градина \r\nВ сърцето на София намира място и прекрасната Докторска градина. Разположена е между улиците \"Оборище\" и \"Шипка\", точно на гърба на Националната библиотека \"Св. св. Кирил и Методий\" и в близост до голяма част от историческите паметници на столицата и държавните институции. Името на парка произлиза от паметника, който се намира в него - Докторски паметник. Паметникът е изграден в памет на загиналите медицински работници в Руско-турската освободителна война от 1877-1878г. В Докторската градина се намират най- различни видове дървета – тришипна гледичия, внесени от Северна Америка, блатен кипарис, гинко, дъб, софора, платан и бяла акация. Също така има оставена и историческа бяла акация, която представлява символичен паметник, посветен на Даниел Неф, който е създател на първите столични паркове и градини.\r\nГрадинките при Националния дворец на културата (НДК)\r\nПаркът се намира на парковия площад „България“ в централната част на София, където е разположена и внушителната основна сграда на Националния дворец на културата. Мястото представлява голям комплекс за конференции, търговски изложения, фестивали и културни събития с известни изпълнители. Паркът се разделя на две части - градината пред НДК и градината зад НДК. Градинката пред НДК се намира точно пред Националния дворец на културата в град София, между ул. \"Фритьоф Нансен\" и бул. \"Патриарх Евтимий\". До нея е разположен Войнишкия мемориал на Първи и Шести софийски полк. В градинката има многофункционална сцена, детски кът и много зелени площи.\r\nГрадина „Библиотека св. св. Кирил и Методий“\r\nВеликолепна градина разположена точно пред Национална библиотека „Св. св. Кирил и Методий“ заобиколена с много зеленина и прелестни, пъстри цветя. Националната библиотека „Св. св. Кирил и Методий“ в София е най-старият културен институт на следосвобожденска България и най-голямата обществена библиотека в страната.  Това става повод тук да се провеждат множество културни събития. В цветната градина пред библиотеката се намира един от най-впечатляващите монументи в столицата - паметникът на св. св. Кирил и Методий. До днес паметникът е считан за едно от най-добрите постижения на българското монументално изкуство. Всяка година в София на 24-ти май пред паметника на солунските братя се отбелязва националният празник на българската писменост и култура. \r\nГрадина \"Възраждане\"\r\nИзвестна със своите големи стогодишни чинари, градината не остава празна в горещите летни дни. Всеки търси спокойните пейки под чудните чинари, за да открие малко прохлада през лятото. Създадена през далечната 1937г. до днес тя е предпочитано място за отдих. Градината е сравнително малка, но компенсира със свежест и красота.\r\nГрадина \"Св. Климент Охридски\"\r\nТова е една от най-емблематичните градини в София, разположена в сърцето на столицата в пространството между Народнo събрание и Софийски университет. Софийският университет „Св. Климент Охридски“ е най-старото и най-голямо висше училище в България. Сградата му е една от забележителностите тук в столицата. Превъзходната архитектура на сградата привлича множество туристи, които пълнят и градинките в околността. Други от най-честите посетители на парка са студентите от университета, които след натоварен ден намират спокойствие и почивка сред зеленината и цветята тук. В градинката също така е издигнат паметник на Св. Климент Охридски един от учениците на Св. Св. Кирил и Методий, смятан за създател на кирилицата. Градинката е подходяща и за приятни разходки по дългите и алеи.", new DateTime(2024, 4, 2, 18, 32, 12, 507, DateTimeKind.Local).AddTicks(4256), "https://galardo.bg/news/10-favorite-gardens-in-the-center-of-sofia", "https://galardo.bg/uploads/images/N/79/10-favorite-gardens-in-the-center-of-sofia/viber_image_2022-08-03_14-16-18-032.jpg", false, "10 любими градини в центъра на София" },
                    { 3, 1, "Българските обичаи са носители на национална идентичност, а корените им търсим в далечното минало, здраво преплетени с историята и християнската религия. През годините наследените традиции се пазят и обогатяват, като доказателството за това днес е богатият културен календар, който включва десетки международни и национални фестивали и събори.", "Българските обичаи са носители на национална идентичност, а корените им търсим в далечното минало, здраво преплетени с историята и християнската религия. През годините наследените традиции се пазят и обогатяват, като доказателството за това днес е богатият културен календар, който включва десетки международни и национални фестивали и събори. \r\nА къде, освен на традиционен събор, можеш да усетиш тръпката и атмосферата на традиционната култура и да се насладиш на истински празник. Опиянен от песни, свирни, танци и подплатен от достатъчно количество домашни вино и ракия (не е задължително), осезаемо усещаш и се насищаш с автентичен български фолклор.\r\n1. Национален събор на българското народно творчество “Копривщица”  \r\nСъборът води началото си от 1965 година и популяризира българския народен фолклор, като събира на едно място певчески и танцови ансамбли от цялата страна. Фестивалът се провежда през пет години в местността Войводенец, в събора участват още свирачи, разказвачи на народни предания, групи за народни обичаи и др. \r\n2. Национален фолклорен събор “Рожен”\r\n Съборът се провежда през август на всеки четири години, има над стогодишна традиция, а първият събор е организиран през 1898 г. Именно тук през 1961 г. Валя Балканска изпява космическата “Излел е Дельо хайдутин”. Днес символ на събора е самобитният гайдарски оркестър “Сто каба гайди”. Съборът продължава два дни. Открива се с химна на Родопите “Бела съм, бела, юначе” под съпровода на “Стоте гайди”. Кулминацията на надпяването е галаспектакълът “Звезден Рожен” във вечерта на първия ден.\r\n3. Международен фестивал на маскарадните игри “Сурва” – Перник Събитието e най-авторитетната в България и на Балканите изява на традиционни народни игри и обичаи с маски. От 2008 г. Международният фестивал на маскарадните игри се провежда ежегодно. Най-зрелищният и атрактивен елемент е двудневното състезателно дефиле на маскарадни групи от страната и чужбина. Традиционно във фестивалната надпревара участват около 5 000 души в над 90 маскарадни групи от всички етнографски райони на България и гости от Европа, Азия и Африка.\r\n4. Традиционен събор “Пирин пее” Организира се от 1962 г. и благодарение на него, през годините популярност придобиват уникалните мъжки песни от Банско, женските песни “на високо” от село Долен и Сатовча, традициите на зурната и тъпана и т.н. Концертите на фолклорните изпълнители и състави  се провеждат на всяка четна година в живописната разложка местност “Предела”. Според организаторите съборът “Пирин пее” не е фестивал, а движение за издирване, съхранение и популяризиране на изворни народни песни и традиции. На събитието се показват и могат да се видят образци на народната песен, танц, обреди, занаяти, народен инструментариум, удивителните костюми и накити, везмо и шевици, религиозно-езическите вярвания и ритуали, цялата календарно-обредна система. Организатор на Събора на народното творчество “Пирин пее” е Община Разлог и Областна администрация – Благоевград.\r\n5. Международно гайдарско надсвирване село Гела\r\nПървото гайдарско надсвирване стартира през 2002 г. на Илинденските поляни в смолянското село Гела. Целта на фестивала е да популяризира автентичния родопски фолклор. Надсвирването се провежда в три възрастови групи, като задължително условие за българските участници е изпълненията да са на каба гайда. Постепенно събитието добива достатъчно голяма популярност и прераства в международен форум. Регистрирани са чуждестранни изпълнители от Япония, Нидерлания, Унгария, Франция, Великобритания и Шотландия. Броят на участниците варира от 40 до 60 изпълнители на година. Най-малкият гайдар, участвал в надсвирването, е на 5 години, а най-възрастният – на 85 години.\r\n6. Международен фолклорен фестивал Бургас                 Фестивалът е снован през 1965 г., провежда се всяка година през август и е с международен статут. Организира се от Община Бургас под патронажа на кмета на града и под надслов “Да съхраним завещаното от нашите предци и го предадем на своите деца”. Обикновено събитието няма конкурсен характер и включва концерти на сцената на Летен театър Бургас, на открити естради (сцени), концерти в региона, празнични дефилета, научна сесия по проблемите на фолклора, изложба-базар на традиционни сувенири, демонстрация на народни занаяти.\r\n7. Национален събор “Петрова нива\" \r\nНа Петрова нива, в землището на с. Стоилово, през 1903 г. се е провело събранието, на което е решено да се вдигне въстание за присъединяване на Странджа, Одринска и Беломорска Тракия към България. Община Малко Търново е организатор на традиционния събор посветен на Илинденско-Преображенското въстание, където “Странджа пее” и почита паметта на хората, които са дали живота си, за да се обединят.\r\n8. Фестивалът на фолклорната носия Жеравна\r\nФондация “Българе” съвместно с община Котел, кметство село Жеравна, “Сдружение за Жеравна” и “Бона фиде” обединиха усилията си и организират уникален фестивал, който може да се сравни само с машина на времето. По традиция събитието се провежда в седмицата след Голямa Богородица, в парк Добромерица край Жеравна и събира хиляди хора от всички краища на България, за да се веселят, пеят, свирят и танцуват. По време на фестивала може да видите български танци представени от професионални ансамбли, дошли от всички етнографски области на България. Единственото условие за желаещите да присъстват е задължително да са облечени с фолклорна носия (автентична, сценична или стилизирана). А за тези, които не разполагат с такава, на входа на фестивала се продават и отдават носии под наем. \r\n9. Фолклорен събор “Златна гъдулка” – Русе\r\n Съборът e един от най-старите у нас форуми за традиционна култура и се организира от Община Русе. Провежда се в покрайнините на Русе, в местността около хижа “Приста” на естествена амфитеатрална тераса и представя традиционното наследство на Русенския край, а в последно време и на цялата фолклорна област Средна Северна и Североизточна България. Фестивалът е с конкурсен характер и се провежда в два раздела: обработен фолклор (танцови състави, вокални групи, оркестри) и изворен фолклор (обичаи, свързани с годишния календар и семейството, певчески и инструментални групи, танцьори, певци, свирачи, разказвачи).\r\n10. Международен фолклорен фестивал на инструменталните и танцови групи – Раднево\r\nПровежда се през септември в градския парк на Раднево. Първото издание на фестивала датира от 1998 г. под името Международен фестивал на инструменталните групи. През годините на своето съществуване, той се оформя като фестивал на инструменталното и танцово изкуство. На неговата сцена са гостували инструментални групи и танцови ансамбли от Русия, Украйна, Турция, Полша, Швеция, Франция, Сърбия, Германия, Унгария, Грузия, Румъния, Гърция, Македония и др.", new DateTime(2024, 3, 28, 18, 32, 12, 507, DateTimeKind.Local).AddTicks(4359), "https://www.10te.bg/obshtestvo/10-ot-nai-populyarnite-festivali-i-sabori-na-narodnoto-tvorchestvo-v-balgariya/", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fkimreikifoundation.com%2Fwp-content%2Fuploads%2F2015%2F07%2F11666204_867722719987867_6989792785009645148_n.jpg&f=1&nofb=1&ipt=babbeb30657ec1a4195d2386d903cea8275dad83e3d7ef151da20105a66d83d9&ipo=images", false, "10 от най-популярните фолклорни фестивали и събори у нас" },
                    { 4, 2, "Представяме ви места из цяла България с маси и пейки и изградени огнища, където е разрешено паленето на огън.", "Представяме ви места из цяла България с маси и пейки и изградени огнища, където е разрешено паленето на огън. \r\n1.Село Алдормировци, област София, Екопътека Войнишка памет \r\nТова е една много закътана екопътека. В началото ѝ, край малък паркинг с рекичка има беседка, барбекю, детска площадка, чешма. По самата пътека имаше още няколко дървени маси с пейки, както и беседка при Пирамидата в местността „Центъра“. До началото на екопътеката се стига с кола, но пътят е тесен, а местата за паркиране са малко. \r\n2.Град Айтос, парк Славеева река \r\nИма изграден район с дървени маси и пейки, няколко зидани огнища. В парка, но не при местата за пикник, има детски площадки, зоологическа градина, тенис маси, волейболни игрища и още много забавления. С кола се стига до началото на парка. \r\n3.Град Бургас, парк минерални бани Ветрен\r\nПодходящ за много компании, с деца или без. Паркира се удобно и близо. Има добро количество дървени маси и пейки, огнищата са над 20. В непосредствена близост има детска площадка, волейболни игрища, маси за тенис, занаятчийска бирария.\r\n4. Село Врабча, Врабчански водопад\r\nДолу при водопада има шест-седем дървени маси с пейки и няколко обособени огнища. Приятно ромоли рекичката на водопада.Има химическа тоалетна. Паркира се горе на пътя и се върви десетина минути, за да се слезе в котловината.\r\n5. Град Дупница, парк Рила \r\nИма иззидани навеси с огнища, дървени маси и пейки. Ползването им се заплаща (през 2016 година – 6 лева). В парка, но не край местата за угощения има детски зони, плувен комплекс, езеро. С кола се стига до началото на парка.\r\n6. Град Луковит, Екопътека Геопарк Искър-Панега\r\nМестата за пикник са по цялата дължина на пътеката: беседки, дървени маси с пейки, огнища, заслони със зидани огнища и маси. Паркира се в началото на екопътеката. Имайте предвид, че последните зони с огнища са на над три километра от паркинга. Обаче там е толкова спокойно и хубаво, че си заслужава.\r\n7. град Трън, Трънско ждрело \r\nКрай река Ерма има двайсетина дървени маси и пейки, десетина огнища за свободно ползване, детска площадка, тоалетна. Паркингът е на метри от мястото. Сянката за съжаление е покрай реката, а огнищата са на слънце.\r\n8. Село Чавдар, област София\r\nМалко е слънчево там. Срещу ресторанта има навес с дървени маси с пейки и едно барбекю. Не се заплаща за масите, за огнището нямаше информация. Има беседка с маса до църквата света Петка. В района имаше чешма. Паркингът е непосредствено до атракциона.\r\n9. Град София, заслон Паша бунар край Драгалевския манастир\r\nНа километър и половина от Драгалевския манастир, стига се по сравнително равна пътека. Има заслон край реката, огнище, както и маси с пейки. Много красиво място.", new DateTime(2024, 2, 7, 18, 32, 12, 507, DateTimeKind.Local).AddTicks(4362), "https://pylnoshtastie.com/%D0%BD%D0%B0%D0%BA%D1%8A%D0%B4%D0%B5-%D1%81-%D0%B4%D0%B5%D1%82%D0%B5-%D0%BC%D0%B5%D1%81%D1%82%D0%B0-%D1%81-%D0%BE%D0%B3%D0%BD%D0%B8%D1%89%D0%B0-%D0%B8-%D0%BC%D0%B0%D1%81%D0%B8-%D0%B7%D0%B0-%D0%BF/", "https://pylnoshtastie.com/wp-content/uploads/2020/10/park-rila-dupnica022.jpg", false, "Места с огнища и маси за пикник в България" },
                    { 5, 1, "Ако харесвате фотогеничните места и обичате да се прибирате от екскурзиите си с куп интересни снимки, следващите дестинации имат място в следващите ви маршрути. Някои са изпълнени с цвят целогодишно, а други - само в определен сезон или месец.", "Пътуването е радост - за очите, за душата, за всички сетива. Понякога ви привличат историите на дадено място, друг път - гледките, на които сте попаднали някъде из интернет и се чудите възможно ли е да са толкова невероятни и на живо. Ако харесвате фотогеничните места и обичате да се прибирате от екскурзиите си с куп интересни снимки, следващите дестинации имат място в следващите ви маршрути. Някои са изпълнени с цвят целогодишно, а други - само в определен сезон или месец. Вижте седем от най-цветните дестинации в България. \r\nПещера Венеца\r\nПещера Венеца придоби невероятна популярност, след като в нея беше инсталирано художествено осветление и тя беше официално отворена за посетители през 2015 г. Разноцветните светлини подчертават впечатляващо ледените кристали, сталактитите, сталагмитите и другите интересни образувания в нея. Пещерата се намира на 3 км от Белоградчик край село Орешец. Работи през цялата година всеки ден без понеделник.\r\nЦентърът на Ловеч\r\nПоредицата от исторически къщи от двете страни на Покрития мост на Колю Фичето в Ловеч се отразяват във водите на река Осъм със своите жълти, червени, лилави и зелени фасади. На заден фон се издигат възвишенията на Дунавската хълмиста равнина и предпланинските части на Стара планина. Ако дойдете тук през ранната пролет, те допълват палитрата със свежо зелено, а през есента са абстрактно изкуство в зелено, жълто, червено и оранжево. Продължете разходката си по моста към старинния квартал Вароша до Ловешката крепост и паметника на Васил Левски за спираща дъха панорама към целия град и околните възвишения.\r\nКопривщица\r\nВ историческата част на Копривщица къщите са не само пълни с история, но и греят в най-различни цветове, кой от кой по-ярък под лъчите на средногорското слънце. Сградите в наситена охра, тъмносиньо и тъмночервено се издигат достолепно една до друга от двете страни на криволичещите калдъръмени улици.\r\nКато добавите към това белите кантове по ръбовете на прозорците и потъмнялото от времето дърво по фасадите им, се получава гледка, достойна за илюстрация на книга с приказки. \r\nПолетата с лавандула в началото на лятото\r\nНаред с полетата с рози, през последните години България стана популярна и с романтичните си лавандулови насаждения. Един балкански Прованс, който обаче не е съсредоточен на едно място, а е пръснат в различни краища на страната - край Шумен, Пловдив, Казанлък. Докато някои от собствениците на лавандулови насаждения не са ентусиазирани от тълпите туристи и фотографи, които се стичат в полетата в сезона на цъфтежа на цветето от края на юни до края на юли, други дори поставят специални декори, за да направят снимките на посетителите още по-интересни (например лавандуловото поле край пътя между Калояново и Дуванлии, Пловдивско).\r\nКрушунските водопади\r\nКрасивите травертинови каскади на Крушунските водопади от години са магнит за търсачите на красиви гледки. Цветът на водата се променя през различните сезони и когато отидете, може да е зеленикава, наситеносиня, млечнобяла или пък съвсем прозрачна. В комбинация с белите ръбове на терасите и зеленината, в която са потънали водопадите, гледката на моменти е нереална.\r\nЕсен в Странджа\r\nВ която и българска планина да отидете, есента е сезонът на пъстрите черги, които горите плетат по склоновете от средата на септември до началото на октомври. Голяма част от листата окапват след първия по-силен вятър или дъжд, но краткият сезон прави преживяването още по-ценно.\r\nРилският манастир\r\nРилският манастир е най-големият в България, най-посещаваният и единственият, който е включен в световното културно наследство на ЮНЕСКО. Всеки има своята лична причина да види манастира, но цветните му стенописи създават специална атмосфера. Най-старите стенописи са в църквата на Хрельовата кула и разказват в три сцени част от живота на Иван Рилски. Автори на изображенията са най-именитите за времето си майстори - Захари Зограф, Димитър Зограф, Коста Вельов, Станислав Доспевски, Димитър Молеров, Симеон Молеров и други.", new DateTime(2024, 3, 13, 18, 32, 12, 507, DateTimeKind.Local).AddTicks(4365), "https://trip.dir.bg/patevoditel/7-ot-nay-tsvetnite-mesta-v-balgariya-snimki", "https://static.dir.bg/uploads/images/2022/06/08/2369234/1366x768.jpg?_=1654684511", false, "Посети 7 от най-цветните места на България" }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Id", "Address", "BriefIntroduction", "DateCreated", "Description", "EndDate", "EventHyperlink", "ImageUrl", "IsApproved", "OrganizerId", "StartDate", "Title" },
                values: new object[,]
                {
                    { 1, "Тръгване: от София, Централна гара", "Живописен планински преход из малко познатия западен дял на Балкана ", new DateTime(2024, 3, 3, 18, 32, 12, 692, DateTimeKind.Local).AddTicks(539), "През град Своге се отправяме към внушителния Искърски пролом и рида Препасница на Понор планина. \r\nС Вазовата еко пътека и приказната каскада на водопада Бовска Скакля, започва разходката ни, из този малко познат дял на Балкана. \r\nСлед кратка почивка в село Заселе продължаваме нагоре, към огледния връх Була. \r\nПродължаваме към първенеца на рида - Връх Сърбеница, сред лабиринт от куполообразни върхове, „препасани“ с внушителни скални откоси от варовик и бездънните кратери на огромните понори между тях. \r\nОт скалистия връх се открива невероятна панорама към Комовете , Козница, Врачанския Балкан, Голяма и Мала планина, Искърското дефиле, Витоша и Софийско равно поле със София. \r\nОт тук, подсичайки връх Крета, се отправяме към горния ръб на внушителния скален венец (препасница) , природния феномен Стола или Черния камък. \r\nС леко изкачване, подсичаме връх Лупова глава и през премката с връх Препасница поемаме надолу, към сгушената под отвесите на скалния венец, махала Топилата на село Добравица, където ни чака микробуса.", new DateTime(2024, 4, 27, 18, 0, 0, 0, DateTimeKind.Unspecified), "https://poplaninigori.com/index.php/excursions/98-vodopad-skakla-vr-h-bula-s-rbenica-i-skalen-fenomen-stola", "https://poplaninigori.com/components/com_rseventspro/assets/images/events/thumbs/660/00a2c885491f0637c1e5d6b92ff8a709.jpg", false, 3, new DateTime(2024, 4, 27, 7, 0, 0, 0, DateTimeKind.Unspecified), "Водопад Скакля, Връх Була, Сърбеница и Скален Феномен Стола" },
                    { 2, "Конна база Войнеговци, преди с.Войнеговци", "Заповядайте на Тодоровден при нас - програма с почетна обиколка, игри и работилница за децата, яздене на коне и стреляне с лък", new DateTime(2024, 2, 12, 18, 32, 12, 692, DateTimeKind.Local).AddTicks(618), "Какво да очаквате на Тодоровден - 23.03.2024 (събота)?\r\nПразникът ни ще е ориентиран към традициите и децата.\r\nОрганизацията се прави не само от нас, но и от участниците ездачи, които са любители на конете, наши клиенти и приятели. Искаме и ние да се забавляваме, така че не очаквайте да сме напълно стриктни в часовете или в самото провеждане на обичаите. Празникът е \"от приятели за приятели\".\r\nПланираме около 10:00/10:30 часа групата ездачи да тръгне на почетната обиколка на село Войнеговци и да е обратно в конната база около 11:30/12:00 часа.\r\nОт 10:00 часа до завръщането на конете, в конната база ще има игри за деца, работилничка за подкови от картон, рисуване и оцветяване.\r\n11:30/12:00 Обичай по захранване на конете и даряване на ездачите. Наричане за здраве.\r\n12:30 - 14:30 Качване на децата за обиколка на манежа с кон, безплатно и еднократно за всяко дете.\r\nНа територията на конната база ще имате възможност за хапване. Свободни сте да си носите и собствена консумация.  Още - стрелба с лък за децата (платена активност) и за закупуване на сувенири и детски книги за коне и животни, с което да подкрепите нашата дейност и особено отглеждането на животните в нашия зоокът. \r\nЩе се радваме да споделите празника с нас, да дойдете заредени с добро настроение и усмивки и да сте с нагласата, че празникът е за всички и трябва да усетим магията му!", new DateTime(2024, 3, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), "https://www.facebook.com/BulgarianHorseFriends/posts/877014877770622?ref=embed_post", "https://scontent.fsof5-1.fna.fbcdn.net/v/t39.30808-6/431521395_878842197587890_2485102450651271760_n.jpg?stp=dst-jpg_p843x403&_nc_cat=106&ccb=1-7&_nc_sid=5f2048&_nc_ohc=n8tzYR7oMGUAX-RrIRK&_nc_ht=scontent.fsof5-1.fna&oh=00_AfB3gYuBuofT8C3uLju9oZtHCVwXODqIwcDjwi3ek6S2wQ&oe=660ADF17", false, 2, new DateTime(2024, 3, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), "Тодоровден в конна база Войнеговци" },
                    { 3, "Парк Борисова градина", "Приключенски парк Коколандия е място с екстремно-развлекателен характер, изграден в гориста местност. Съоръженията са подходящи за деца над 6 години.", new DateTime(2024, 3, 13, 18, 32, 12, 692, DateTimeKind.Local).AddTicks(629), "При нас няма задължителни изисквания, няма такса „зала“, такса „човек“ и др. Вие избирате колко човека да бъдете, дали да си донесете почерпка или да използвате услугите на външен специализиран кетъринг. Можем да ви осигурим аниматор и тематично парти или вие сами да се забавлявате с децата. Решението е изцяло ваше.\r\nЕдинствено очакваме да използвате нашите съоръжения.", new DateTime(2024, 12, 2, 18, 32, 12, 692, DateTimeKind.Local).AddTicks(635), "https://kokolandia.com/", "https://kokolandia.com/wp-content/uploads/2023/04/DMK_2688-scaled.jpg", false, 4, new DateTime(2024, 3, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), "Организирайте рождения ден на своето дете при нас, в Коколандия" },
                    { 4, "Област Варна, с.Неофит Рилски", "Средновековен събор \"Ново начало\" е събитие, пресъздаващо материалната и духовна култура на старобългарската (езическа и православна) цивилизация, и държавните традиции на Първото българско царство на Балканите.", new DateTime(2024, 3, 23, 18, 32, 12, 692, DateTimeKind.Local).AddTicks(638), "Средновековен събор \"Ново начало\" е събитие, пресъздаващо материалната и духовна култура на старобългарската (езическа и православна) цивилизация, и държавните традиции на Първото българско царство на Балканите.\r\nСъборът се провежда всяка година (месец юни), на територията на Исторически парк – своеобразен \"Музей на живата история\", изграден в с. Неофит Рилски, област Варна, България.\r\nОрганизатори на събора са Исторически парк АД и Българска школа за старинни войнски изкуства \"Величие\".\r\nПрез първия съборен ден, гостите на Исторически парк от близо и далеч, ще се пренесат изцяло в света на средновековните войни, ще станат свидетели на войнската \"Тризна\" – конни и пеши надборвания с оръжие, посветени на бойната слава на предците и ще настръхнат при сблъсъка на мъже и бойни дружини в Старобългарските войнски игри \"Ристание\" . Вторият ден на събора \"Ново начало\", ще продължи с пресъздаването на бита, културата и военното дело на народите от Евразия, в периода на ранното средновековие и Старобългарските войнски игри \"Ристание\".", new DateTime(2024, 6, 23, 17, 0, 0, 0, DateTimeKind.Unspecified), "https://ipark.bg/bg-BG/Events/Details/1126", "https://ipark.bg/uploads/83169efb-72a6-45a9-ade5-5705dd064a7d.jpg", false, 3, new DateTime(2024, 6, 22, 11, 0, 0, 0, DateTimeKind.Unspecified), "Средновековен събор \"НОВО НАЧАЛО\"" },
                    { 5, "Област Варна, с.Неофит Рилски", "С идеята да съхраним и популяризираме кулинарното наследство и да представим традиционните храни на различни етнически и етнографски групи, Исторически парк става за поредна година домакин и организатор на Международния фестивал на традиционната храна.", new DateTime(2024, 4, 2, 18, 32, 12, 692, DateTimeKind.Local).AddTicks(648), "С идеята да съхраним и популяризираме кулинарното наследство и да представим традиционните храни на различни етнически и етнографски групи, Исторически парк става за поредна година домакин и организатор на Международния фестивал на традиционната храна. \r\nВ последните дни от месец август, на 24-и и 25-и, на обширните пространства на Фестивална зона ще си дадем среща с добрата и чиста храна, ще се запознаем с пазители на кулинарните традиции, ще се докоснем до забравени вкусове, ще научим много за кулинарната култура по нашите земи. \r\n Обединявайки традиции, поминък, занаяти и творчество, фестивалът на традиционната храна в Исторически парк ще спомогне да се пренесат знания от миналото към настоящето и бъдещето. \r\n Изчезващи продукти и такива, които не познаваме, ще бъдат преоткрити. Сетивата ще бъдат предизвикани със забравени вкусове. \r\nТук, сред обширните пространства на Фестивална зона, сред прекрасната природа,  ще имате възможност да посетите кулинарни работилници и множество представяния на традиционни ястия от България и съседните балкански страни. \r\n За поредна година сръчни майстори готвачи, известни сомелиери и производители на биохрани ще демонстрират своите умения за приготвяне на традиционни гозби и производство на храна, която да поддържа здравето и духа ни. \r\nИзобилието от вкусове от различни близки и далечни краища ще бъде чудесен повод да поемете на път към Исторически парк, за да останете с незабравими впечатления. \r\nОсвен с кулинарни изкушения, миналото ще се съживи чрез демонстрации от реконструкторския екип  към Исторически парк, музикални и танцови представления от местни състави и много други изненади.  \r\nЗаемете първи ред във вашето пътуване в миналото, като посетите фестивала на храните в Исторически парк.", new DateTime(2024, 8, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), "https://ipark.bg/bg-BG/Events/Details/2137", "https://ipark.bg/uploads/9167b071-827e-4743-916d-64c39bde1e66.jpg", false, 2, new DateTime(2024, 8, 24, 11, 0, 0, 0, DateTimeKind.Unspecified), "МЕЖДУНАРОДЕН ФЕСТИВАЛ НА ТРАДИЦИОННИТЕ ХРАНИ" }
                });

            migrationBuilder.InsertData(
                table: "ArticlesCategories",
                columns: new[] { "ArticleId", "CategoryId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 5 },
                    { 2, 6 },
                    { 3, 1 },
                    { 3, 3 },
                    { 3, 5 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 5 },
                    { 4, 6 },
                    { 5, 1 },
                    { 5, 4 },
                    { 5, 5 },
                    { 5, 6 }
                });

            migrationBuilder.InsertData(
                table: "ArticlesWeathers",
                columns: new[] { "ArticleId", "WeatherId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 2 },
                    { 1, 3 },
                    { 2, 3 },
                    { 3, 3 },
                    { 4, 3 },
                    { 5, 3 },
                    { 1, 4 },
                    { 2, 4 },
                    { 3, 4 },
                    { 4, 4 },
                    { 5, 4 },
                    { 1, 5 },
                    { 2, 5 },
                    { 4, 5 },
                    { 5, 5 },
                    { 2, 6 },
                    { 4, 6 },
                    { 5, 6 }
                });

            migrationBuilder.InsertData(
                table: "ArticlesWeathers",
                columns: new[] { "ArticleId", "WeatherId" },
                values: new object[,]
                {
                    { 5, 7 },
                    { 2, 8 },
                    { 5, 8 },
                    { 1, 9 },
                    { 2, 9 },
                    { 3, 9 },
                    { 4, 9 },
                    { 5, 9 },
                    { 2, 10 },
                    { 4, 10 },
                    { 5, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_AuthorId",
                table: "Articles",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticlesCategories_CategoryId",
                table: "ArticlesCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticlesWeathers_ArticleId",
                table: "ArticlesWeathers",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_Name",
                table: "Authors",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Authors_UserId",
                table: "Authors",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_OrganizerId",
                table: "Events",
                column: "OrganizerId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizers_Name",
                table: "Organizers",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Organizers_PhoneNumber",
                table: "Organizers",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Organizers_UserId",
                table: "Organizers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticlesCategories");

            migrationBuilder.DropTable(
                name: "ArticlesWeathers");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Weathers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Organizers");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
