using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LetsGoOutside.Infrastructure.Migrations
{
    public partial class VirtualICollectionsArticleWeatherAndCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Events",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                comment: "Event address",
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60,
                oldComment: "Event address");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 25, 15, 21, 33, 518, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 4, 4, 15, 21, 33, 518, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 3, 30, 15, 21, 33, 518, DateTimeKind.Local).AddTicks(6332));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 2, 9, 15, 21, 33, 518, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 15, 21, 33, 518, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d63979-ce0b-4250-8473-5ba2251f407e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f95f9ed-d3e3-490f-b265-002766727143", "AQAAAAEAACcQAAAAEOD/50kJOoatxTT22Y9GF2DY87N2lU0TzY56foWSzG9rFCEhCuutCFogWk+vXnH7VQ==", "ea62444e-6b7a-43cf-beb3-c71d4ce5af6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29ebd1a1-6a97-4e4f-bc98-4e8bf1e5825f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a94a3e2-8fc8-4f57-b273-e44c5dde6fe7", "AQAAAAEAACcQAAAAEEj+EY16YQNIihym+Y4uSsQX0UW9HaLQ8kmX27uGcHByVzjGd5FxRqoO6/MtB2tUZw==", "6a8edaf6-e373-4468-966b-7d4a2eca2dec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3354c365-9a55-4a7b-a766-4ea59d7cc57c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec2ca692-033c-4787-bbec-ce3577dcd841", "AQAAAAEAACcQAAAAEAulb2/5aP96eie6PYemQhxD+bs/MR08vvFeHJrKOrBoUam2u5b+NTZHBVpooFO56A==", "b27f8726-c849-4a90-a843-666d2bba63fe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6528f9a3-a6c1-4fdc-b095-d1f074e33843",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07b90902-591a-4332-9ff9-b4d041f6aee4", "AQAAAAEAACcQAAAAECrI5DQcvRLGmB+vKJlLYdQSTHwcus54Xwnqcw6HAvbk4iumZ+cRidFQQ8teC7KWDg==", "e42c146a-7dfb-4e57-8a0c-dfc229c6dbfa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1185323c-dd39-4fb6-b0c7-d038b234cd30", "AQAAAAEAACcQAAAAEMk3uzNLUa2PrfKzMLIha6mYr3HbzSQvTgnvPxIyw0RFd91WT152/HOO+ZeToZ6JCw==", "114e6cfa-285a-4192-9ce7-d9504c3c0667" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c38970b5-010c-494b-9621-fe38e520e367",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc380dac-f66c-43bf-bac7-1a6a529ba6b9", "AQAAAAEAACcQAAAAENDzEHZJCSp+OTEcAMPZYQlhIEoViUa0ziVYq+D1wOjR12mTJxMpOJFlA9MmmlauEw==", "6eea5e03-f884-498d-8df7-e5adcf2c976a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8c87a2b-70f7-4799-86c7-75e882c47894",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5e13ad5-32de-4a2e-b56f-41de10e5a213", "AQAAAAEAACcQAAAAEKupde+B2WnNY4YcU+tJ//E/ZGnd3zpUrpedkC0yr4iwS0IwZGU89o3qA88XqMgJiA==", "22d0313a-3265-44a8-920e-1cfe3f8aeca3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb06262c-d955-4550-8a63-cd41914463e9", "AQAAAAEAACcQAAAAEHWSm1CFEc1MtfxjLOVLoZLMshCxkt3g6Lg6QHg9XV19phhaWQQCwq/oacTzRWujTg==", "4f8b038c-2184-4f10-bba6-efe6312eab98" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 2, 4, 15, 21, 33, 295, DateTimeKind.Local).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 3, 15, 15, 21, 33, 295, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 5, 15, 21, 33, 694, DateTimeKind.Local).AddTicks(9886));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 2, 14, 15, 21, 33, 694, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "EndDate" },
                values: new object[] { new DateTime(2024, 3, 15, 15, 21, 33, 694, DateTimeKind.Local).AddTicks(9960), new DateTime(2024, 12, 4, 15, 21, 33, 694, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 3, 25, 15, 21, 33, 695, DateTimeKind.Local).AddTicks(44));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 4, 4, 15, 21, 33, 695, DateTimeKind.Local).AddTicks(55));

            migrationBuilder.UpdateData(
                table: "Organizers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 4, 15, 21, 33, 218, DateTimeKind.Local).AddTicks(1196));

            migrationBuilder.UpdateData(
                table: "Organizers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 2, 4, 15, 21, 33, 218, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "Organizers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 1, 20, 15, 21, 33, 218, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "Organizers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2023, 12, 28, 15, 21, 33, 218, DateTimeKind.Local).AddTicks(1217));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Events",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                comment: "Event address",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldComment: "Event address");

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
    }
}
