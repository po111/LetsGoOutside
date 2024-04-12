using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LetsGoOutside.Infrastructure.Migrations
{
    public partial class MinorChangesInEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
