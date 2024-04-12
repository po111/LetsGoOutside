using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LetsGoOutside.Infrastructure.Migrations
{
    public partial class AdminAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 4, 2, 20, 0, 27, 310, DateTimeKind.Local).AddTicks(6808));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 4, 12, 20, 0, 27, 310, DateTimeKind.Local).AddTicks(6813));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 4, 7, 20, 0, 27, 310, DateTimeKind.Local).AddTicks(6818));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 2, 17, 20, 0, 27, 310, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 3, 23, 20, 0, 27, 310, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d63979-ce0b-4250-8473-5ba2251f407e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d3092a6-e078-4138-9a4b-0acac0414b26", "AQAAAAEAACcQAAAAEBw9Nthhnd/JZn93vF/I024xpTw9j7N5EdSXx4WqjlQ3j3TJcNqDiD1fie6XconPiQ==", "66e7b301-b0e4-4431-b396-367ac5b6d875" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29ebd1a1-6a97-4e4f-bc98-4e8bf1e5825f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b79aabb-e315-4d25-bff9-9c06dfbba376", "AQAAAAEAACcQAAAAEFl463ivh9fwPZJn1oiC7B/2zjMd5dhkwguWH34FfcNbyAGXELpzqWqoAMHxJOcj1w==", "6effd7ec-0ab0-4ce2-91e8-620e45d3eb42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3354c365-9a55-4a7b-a766-4ea59d7cc57c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eab9a118-4b99-404b-bd7c-f2efa7cf0566", "AQAAAAEAACcQAAAAENM2GSUFcAl7vbbVzuI2njQB5MVX9N5W+hLOlFWxnUphpkSdSXgojG8ukOQFV6sKAw==", "d6701dc6-d086-4677-bb78-6c6896f7b222" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6528f9a3-a6c1-4fdc-b095-d1f074e33843",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0591bcec-c1e4-4f5a-bf52-50662cfb686a", "AQAAAAEAACcQAAAAEF6Ny7pPbcpL54UZyM+wb9a6OU273O5m0sTkbJ1bhLhjHBhHDP0xRErK1BWFMsjaPA==", "2ed354f2-b3fe-4d2e-83e7-fee6e145ff5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b9465b9-72aa-47a4-a85c-a494cc93435e", "AQAAAAEAACcQAAAAEGEzcFForGE/Ee0dg45rCXpRTSdpl6vUYrWIGZ9Zndqwuge2tIAsnzUY/Ezj6GKjQw==", "f6407ab1-1ff6-4057-b026-6ae9f9471994" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c38970b5-010c-494b-9621-fe38e520e367",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "838854cd-2c2b-4df2-819a-125ebc5339dc", "AQAAAAEAACcQAAAAEAYubjE8JcBT9k/9qiSEtsQycPZ9XS0x/6J0zjQb+JPsBbf73j3RNknj78Dj9wHa2Q==", "9ad4de9a-c07d-4626-9b32-e5eaf19cffe7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8c87a2b-70f7-4799-86c7-75e882c47894",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf343993-2a63-479a-ab3d-de7929d64102", "AQAAAAEAACcQAAAAEN1ewgaaGnv+HR53wG31DkwwKl5mRH/PtkUAEjjFc5fbUcEmJSeID+/mPRPt51eUgA==", "f1233689-b9ff-41c3-abd7-629172a3fbb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36e4cae2-747d-498d-909a-aee20def5225", "AQAAAAEAACcQAAAAEP49N8OuwrpFXA33eK8Ml+pfXMsKckHRGam+SI5M9loUoxBaEzCb7Vnc/96AseaQGw==", "5c9d9ca3-1963-4a96-b2b0-dcd37e29c167" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c974417d-38b4-42a6-9133-708d1d7c8b0f", 0, "631c2dfc-a098-4078-bf7c-f5f940e8ab68", "admin1@mail.com", false, false, null, "admin1@mail.com", "admin1@mail.com", "AQAAAAEAACcQAAAAEGhvzAZMdi0/t+ktRCXlZl5cGk4JKngxaU0oHN2dxZrL1VXR7vzdNcKpb+12GymAlw==", null, false, "87014065-1077-4b85-9842-0fde38fdeb90", false, "admin1@mail.com" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 2, 12, 20, 0, 26, 913, DateTimeKind.Local).AddTicks(9706));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 3, 23, 20, 0, 26, 913, DateTimeKind.Local).AddTicks(9739));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 13, 20, 0, 27, 629, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 2, 22, 20, 0, 27, 629, DateTimeKind.Local).AddTicks(9417));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "EndDate" },
                values: new object[] { new DateTime(2024, 3, 23, 20, 0, 27, 629, DateTimeKind.Local).AddTicks(9432), new DateTime(2024, 12, 12, 20, 0, 27, 629, DateTimeKind.Local).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 4, 2, 20, 0, 27, 629, DateTimeKind.Local).AddTicks(9445));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 4, 12, 20, 0, 27, 629, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "Organizers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 12, 20, 0, 26, 777, DateTimeKind.Local).AddTicks(6158));

            migrationBuilder.UpdateData(
                table: "Organizers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 2, 12, 20, 0, 26, 777, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "Organizers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 1, 28, 20, 0, 26, 777, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "Organizers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 1, 5, 20, 0, 26, 777, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "DateCreated", "Name", "UserId" },
                values: new object[] { 5, new DateTime(2023, 1, 12, 20, 0, 26, 913, DateTimeKind.Local).AddTicks(9750), "Администратор-автор", "c974417d-38b4-42a6-9133-708d1d7c8b0f" });

            migrationBuilder.InsertData(
                table: "Organizers",
                columns: new[] { "Id", "BriefPresentation", "DateCreated", "Name", "PhoneNumber", "UrlWebsite", "UserId" },
                values: new object[] { 7, "", new DateTime(2023, 1, 12, 20, 0, 26, 777, DateTimeKind.Local).AddTicks(6184), "Администратор-организатор", "+359777777777", "", "c974417d-38b4-42a6-9133-708d1d7c8b0f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Organizers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c974417d-38b4-42a6-9133-708d1d7c8b0f");

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 30, 15, 59, 57, 676, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 4, 9, 15, 59, 57, 676, DateTimeKind.Local).AddTicks(547));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 4, 4, 15, 59, 57, 676, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 2, 14, 15, 59, 57, 676, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 3, 20, 15, 59, 57, 676, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d63979-ce0b-4250-8473-5ba2251f407e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c100175-dc80-46c0-bba9-ae13c7cdec18", "AQAAAAEAACcQAAAAEFLc5sLPLgZUdAYbQIkJyUxmBIB5mMRvqtDWPXe6TL9HGv4WxqRk2wuP7iQv5w6HoQ==", "2255aff3-8bbe-4a88-8af9-0c118d152a3c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29ebd1a1-6a97-4e4f-bc98-4e8bf1e5825f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10a3c361-4d75-4433-a58d-6d9b97b7e0fc", "AQAAAAEAACcQAAAAECRCp79cy6Z7VcKptsZCN15wVb4/vzPTLKAbqmQ8CcS5KbHhciBVEpvGyh6hOwKgpw==", "46b81eca-f033-4ef0-a628-3feb57ef4bd4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3354c365-9a55-4a7b-a766-4ea59d7cc57c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77c48642-d7f7-40eb-b28f-c194c110dbdb", "AQAAAAEAACcQAAAAEJP/CxyFkELHEIcJbja8a/kjLkfjG5v7wtc/MenStA9iYaSr535m+c0Ct1bIToMubg==", "a4db45f7-5fd4-4b66-92f3-613f12e20d90" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6528f9a3-a6c1-4fdc-b095-d1f074e33843",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6349d1df-a5ce-46ec-a382-6ca93543595e", "AQAAAAEAACcQAAAAEKPx9ah7qFwncHGEsJVa4UKGXEAEz+m/JbvzdhnCDYb/pz7SsJGAKi7AZPvMmhYYVA==", "055673b6-5ca4-46f6-bede-05c0ebb4942f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d2b4d867-13e1-4cb4-93e8-2e5f355fd154", "AQAAAAEAACcQAAAAEBW+fL4HIUYM1Qpg9QgXVK9WULZOoI84425M2qSIxNP1JDH/2q3/rT0SfE+TQfW+xA==", "f953c42d-7f36-4d85-bb46-2bbcffc67472" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c38970b5-010c-494b-9621-fe38e520e367",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c913d39-995a-4f6b-ae74-43e2e280e783", "AQAAAAEAACcQAAAAEPXJ0o3RIYp5b3R+mq57S0eihH4ICgFp/fD9lhgJRUA+NERg2v2i/nOU1eGunAuTXQ==", "1e61e9c4-a656-4dc4-aeb1-3a640568e9c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8c87a2b-70f7-4799-86c7-75e882c47894",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ac0ffbf-0f0f-4967-b1a8-8a18a884b624", "AQAAAAEAACcQAAAAEI3jWbnV9N1VDbujQIo5RPB/z25G8R6vrlBXi8b1cZ3IPOVf7lu4tnGbEjmBUm5uEQ==", "7bc180b1-1a8a-4382-b00d-cd9d86c4cc51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40cdbb15-25e6-4891-89e6-1424ed22cc43", "AQAAAAEAACcQAAAAECFWkL0BhkvIy/I8sJeN9BSd6rzAWYl64melJMMuS6L0DNSuHk5x2+WytY0rEH0DGw==", "800fc51e-5135-4176-8bde-030535533c7c" });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 2, 9, 15, 59, 57, 525, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 3, 20, 15, 59, 57, 525, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 3, 10, 15, 59, 57, 828, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 2, 19, 15, 59, 57, 828, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "EndDate" },
                values: new object[] { new DateTime(2024, 3, 20, 15, 59, 57, 828, DateTimeKind.Local).AddTicks(516), new DateTime(2024, 12, 9, 15, 59, 57, 828, DateTimeKind.Local).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 3, 30, 15, 59, 57, 828, DateTimeKind.Local).AddTicks(523));

            migrationBuilder.UpdateData(
                table: "Events",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateCreated",
                value: new DateTime(2024, 4, 9, 15, 59, 57, 828, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "Organizers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2024, 1, 9, 15, 59, 57, 473, DateTimeKind.Local).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "Organizers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2024, 2, 9, 15, 59, 57, 473, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "Organizers",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2024, 1, 25, 15, 59, 57, 473, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "Organizers",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCreated",
                value: new DateTime(2024, 1, 2, 15, 59, 57, 473, DateTimeKind.Local).AddTicks(9874));
        }
    }
}
