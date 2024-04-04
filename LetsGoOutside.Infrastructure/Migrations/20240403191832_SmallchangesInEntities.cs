using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LetsGoOutside.Infrastructure.Migrations
{
    public partial class SmallchangesInEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HyperlinkSource",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: true,
                comment: "Article source hyperlink",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "Article source hyperlink");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 24, 22, 18, 30, 870, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 4, 3, 22, 18, 30, 870, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 3, 29, 22, 18, 30, 870, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 2, 8, 22, 18, 30, 870, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 22, 18, 30, 870, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d63979-ce0b-4250-8473-5ba2251f407e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6ceb982-d4f2-4068-9775-5448d8415993", "AQAAAAEAACcQAAAAEIYKpXHDjK2DHlkYguO886ddCzIXHfguXch8QOzdMSRkZy443+qq7jS4/skfCPr9+A==", "481e0f3e-7f60-4a40-be2b-0e51cdce7d63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29ebd1a1-6a97-4e4f-bc98-4e8bf1e5825f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f4ce204-b032-4e34-b184-edf2c00eef38", "AQAAAAEAACcQAAAAEFcDJzJucAL+HB/PBAoDus7J8dpuS/55bL7zaLMZJrCbqU4NeqBqsZkfLUPZdy09tw==", "851f9caa-3d65-4734-b8b9-9dd6a2d222bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3354c365-9a55-4a7b-a766-4ea59d7cc57c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45d5dec0-d87e-4af5-8a9e-da36a27a4d69", "AQAAAAEAACcQAAAAEE6QG64BNNVLrI/giGII+uNC6Xd5OKMlI6jNg7pEptFOZLXehjIiTrJ0tlW9vwNaag==", "7403f47b-62cb-4a14-b76c-60bad895c75e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6528f9a3-a6c1-4fdc-b095-d1f074e33843",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83e876dd-a453-4d85-a59f-53d66b2aca1b", "AQAAAAEAACcQAAAAEE8eV1mR0L65q0pKzrmFb89K5lnHRBpvVbvZxUmGCBuafnyzlYSahYia4v2PBUrGKQ==", "2154e089-caf4-419c-be8f-5fa648a4f0ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b7c36ce-e31c-48a7-bd31-57a811117428", "AQAAAAEAACcQAAAAEDrRsaSZiJbY1Rp1Jrph0EpVSDRKrYaJgzpgzpAr1QcbxPOCdhC7sN6ybpeL08C/+A==", "d22b978b-d6db-4a30-828e-083257beb97f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c38970b5-010c-494b-9621-fe38e520e367",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01f3c129-0732-4dfa-944d-668e5cf58de8", "AQAAAAEAACcQAAAAELlhybqmC/Tm6pL01rLSs7eGGV8CYUI96KXQ92bozVLlR5IGoSWUotRDAilHPKVCGw==", "3ee7e119-675c-4114-8437-be2f525376fd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8c87a2b-70f7-4799-86c7-75e882c47894",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dc929ce-e20f-4d8b-8b90-91e372848e2d", "AQAAAAEAACcQAAAAELnnvqm43uFODc8D6hFC5+iI2u+NwafGZm6sERZYCbwsSYB3CKwCmtEpKY4/iRNRqA==", "d0dfa755-0811-4c46-ad7a-e10ca5a29f5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a09216bd-a780-4f90-b248-4b5e50c68a1f", "AQAAAAEAACcQAAAAEP2dHIgq5ogiK/Hl2q8C3fy+Rb3umxIXQ622XCHx6nqFQLCfNCi2faIuB9hB1pYcTw==", "4fce32f6-ece1-42cf-a892-f48afba23480" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 22, 18, 30, 602, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 3, 14, 22, 18, 30, 602, DateTimeKind.Local).AddTicks(2150));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 4, 22, 18, 31, 92, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 2, 13, 22, 18, 31, 92, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "EndDate" },
                values: new object[] { new DateTime(2024, 3, 14, 22, 18, 31, 92, DateTimeKind.Local).AddTicks(1110), new DateTime(2024, 12, 3, 22, 18, 31, 92, DateTimeKind.Local).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 3, 24, 22, 18, 31, 92, DateTimeKind.Local).AddTicks(1120));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 4, 3, 22, 18, 31, 92, DateTimeKind.Local).AddTicks(1354));

            migrationBuilder.UpdateData(
                table: "Organizers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 3, 22, 18, 30, 521, DateTimeKind.Local).AddTicks(51));

            migrationBuilder.UpdateData(
                table: "Organizers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 2, 3, 22, 18, 30, 521, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "Organizers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 1, 19, 22, 18, 30, 521, DateTimeKind.Local).AddTicks(77));

            migrationBuilder.UpdateData(
                table: "Organizers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 27, 22, 18, 30, 521, DateTimeKind.Local).AddTicks(85));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "HyperlinkSource",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "Article source hyperlink",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true,
                oldComment: "Article source hyperlink");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 23, 18, 32, 12, 507, DateTimeKind.Local).AddTicks(4252));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 4, 2, 18, 32, 12, 507, DateTimeKind.Local).AddTicks(4256));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 3, 28, 18, 32, 12, 507, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 2, 7, 18, 32, 12, 507, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 3, 13, 18, 32, 12, 507, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d63979-ce0b-4250-8473-5ba2251f407e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a22b76e-a85b-43bf-a333-a727a5274b2e", "AQAAAAEAACcQAAAAEKgkrVUXAXQCw/tI/wNQIUZdOJBI0hJLxtM/TjHd60lLAF/WNU4qjzGoDoj7x3BgGw==", "2dd39674-c421-44b5-9e97-4423a1f52b47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29ebd1a1-6a97-4e4f-bc98-4e8bf1e5825f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb3defc2-ad20-45b7-bda1-ca53e8a3482b", "AQAAAAEAACcQAAAAEFftFMeLGa7nlN0TtFn2JrHomfS+M6s4pJT6ZONKrfU5y30l1RWXoGRgYATEIX9EyQ==", "bcb60efe-1a9c-43cf-957f-69c0f8611feb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3354c365-9a55-4a7b-a766-4ea59d7cc57c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ab28e55-b704-462a-9fc1-be9433630e39", "AQAAAAEAACcQAAAAEJOdpbFPerUT/nDef1088XwxcQ3FNYTjWi89WxWPWeUESihEiOW8r0DU0Ho71u31Hw==", "127df1e3-35ea-41a1-bd8d-efc487651766" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6528f9a3-a6c1-4fdc-b095-d1f074e33843",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "129fb219-4360-43c4-aacb-304859bf4518", "AQAAAAEAACcQAAAAEO6fJxB6qZy/qwK1nh5Woe+Bc1nrLAwc8yv2u5j4e2m1DdSUsD3/kt6nfIPtKKgLnA==", "ee0ccd5d-bf3b-4794-ab19-a9d721c9d7a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c769d33b-9007-40cb-9655-9839946d9ad5", "AQAAAAEAACcQAAAAEBiWe0QwQ8GqYYeE4TqWyCnzRG/HojLFx/SdGiAyIXBcqBrTq/yauXlsa87hhlZDUQ==", "daf56beb-a1ee-4f25-b09c-6e35d0ca7035" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c38970b5-010c-494b-9621-fe38e520e367",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a272577a-0d8d-459e-9748-695eb6d0deab", "AQAAAAEAACcQAAAAEPKSS3XNipcRixpmPONIwb+ptmnjd2xFIEHHx/EZcmdcW79iWnQKRrJRauR2Zu3ArQ==", "4a6235ed-f404-4f1c-8711-5c2ebfe889cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8c87a2b-70f7-4799-86c7-75e882c47894",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d7ad4cd-9f8b-464c-822e-8568e61ef38b", "AQAAAAEAACcQAAAAEKoR1edRYqD/CoEqCsBSffbd1YfCUxTORqbMHk921yun0JUXH6t5yabh07o+bD9Jxg==", "c4232c3f-31b9-46a5-93bc-fea7e67820be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a909b91-85de-4dee-a605-127db2d83d83", "AQAAAAEAACcQAAAAECghuFu8Gv+out39haBLy7MeQpxiCxsWkBwgfsP1i/sEANoY0qxniibUb2ugL83+BA==", "5499d24d-c120-4c54-a9c5-c1c7f228d675" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 18, 32, 12, 302, DateTimeKind.Local).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 3, 13, 18, 32, 12, 302, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 3, 18, 32, 12, 692, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 2, 12, 18, 32, 12, 692, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "EndDate" },
                values: new object[] { new DateTime(2024, 3, 13, 18, 32, 12, 692, DateTimeKind.Local).AddTicks(629), new DateTime(2024, 12, 2, 18, 32, 12, 692, DateTimeKind.Local).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 3, 23, 18, 32, 12, 692, DateTimeKind.Local).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 4, 2, 18, 32, 12, 692, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "Organizers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 2, 18, 32, 12, 234, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Organizers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 2, 2, 18, 32, 12, 234, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Organizers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 1, 18, 18, 32, 12, 234, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "Organizers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 26, 18, 32, 12, 234, DateTimeKind.Local).AddTicks(8815));
        }
    }
}
