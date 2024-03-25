using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class updatedborder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "adbd9eaa-41d3-4780-922a-b7105dedbdf4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"),
                column: "ConcurrencyStamp",
                value: "7877a67c-4450-47a6-921a-29bbb10e6121");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "7faeaa76-64a0-4ca6-b4f3-5d4622174679");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0ee3e5a7-89ed-4bd2-8729-c66311b30033"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5ff58cf-f36f-4e2d-b551-075e4c06d818", "DuctvDongDa10002", "AQAAAAEAACcQAAAAEOnsytRcNTuwTO77jOnqyiWmvYUe1J50phmO9ecN9NJQI18Q2IaYRJ8s47e6dXgRRw==", "ef67d520-584c-40bf-9a26-8d0afe9d59e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5bc33f98-d863-485d-ab47-c112ca2840ff", "AQAAAAEAACcQAAAAEFzpBnGIpKgnY/lv8qdfHTR4sQ0s9GZRD+N3H0FamTqwpzHL+Pt7nbQYLiwvK5hTDw==", "ce409c4a-8294-4b55-9afe-e49de2c011ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c85649c-2d04-4846-a5f2-212ea550291b"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16b53ae9-58b6-42df-9726-7b03a5e27915", "LamntDongDa10001", "AQAAAAEAACcQAAAAEOedJPWD9568zqOMDLeszetPBScmd8q+fzEAeFCvQ4mhFPesXX9UtrPz8Fta7C7Yvg==", "c625c28b-de5a-4ee3-8c26-fe7f4998bafd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "272e84f8-d2a5-496a-9f55-e588c89b71a4", "AQAAAAEAACcQAAAAEMmw13La8Pz8KPAlxEt5zBOd9DFnKb8PzXb/Q7/kpN9rqkDXKyCqr5cX0kTzYUNM2Q==", "7ce1e679-a3c0-46de-97ab-9bca2e043670" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b551fd08-76d9-4040-b0fa-fb2e7aacbe7d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10cb4758-54c4-4d95-8005-b4c2b1e4310b", "AQAAAAEAACcQAAAAEGUbV6LdiZF+NNRw+8vQcvvL2KefrFVB9MmlnvRsDbgLf+dUTQNvz1L7avOjxeDQbQ==", "a1e4d8a3-f623-4409-ac87-cf0e65161f6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b8ddc2e0-8b14-4c37-869e-7ca5bad4671a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "303ea5b5-2bb8-43e5-a1e2-3ed7ad1c3a73", "AQAAAAEAACcQAAAAENd1cTh0AKbAB3uXyzXkRuh0+j2WY0yoUdN4a+8p6peahH6ZMZQc86908Drv08brEQ==", "9fc16d94-e38b-4171-b2a5-e338edfe47b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c3a4a2eb-1703-4fc5-8511-f68acdb3a1d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8a26849-b327-4011-935e-2c0e7837c835", "AQAAAAEAACcQAAAAEABlyQmnMutgUTjRGY9007OhvzTPneUSTlk6PYK7pDj8TXzKs4TY8qIB4Bis+Jg2AA==", "a013f279-2e7a-489b-9ea7-233ffa074a0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e7d19c1e-a674-4d77-978a-47bbacd6910e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df64dfa3-c72d-4ebd-9391-8005400aba33", "AQAAAAEAACcQAAAAEHOkH1ICmaB1sKcBl1R1fTI0XRSOFTlc0RSYyYslCe7uwaHJAdPxWSEpjXuWplF+tA==", "0ee96c37-41bc-404e-bb07-9f74e0b59c95" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 25, 5, 4, 53, 634, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 25, 5, 4, 53, 634, DateTimeKind.Local).AddTicks(8901));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 25, 5, 4, 53, 634, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 25, 5, 4, 53, 634, DateTimeKind.Local).AddTicks(8905));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 25, 5, 4, 53, 634, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 25, 5, 4, 53, 634, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 25, 5, 4, 53, 634, DateTimeKind.Local).AddTicks(8909));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 25, 5, 4, 53, 634, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 25, 5, 4, 53, 634, DateTimeKind.Local).AddTicks(8911));

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "Quantity",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "Quantity",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "Quantity",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "Quantity",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "Quantity",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "Quantity",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "Quantity",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "Quantity",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 9,
                column: "Quantity",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 10,
                column: "Quantity",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 11,
                column: "Quantity",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 12,
                column: "Quantity",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 13,
                column: "Quantity",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 14,
                column: "Quantity",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 15,
                column: "Quantity",
                value: 30);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Order");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "fe82a30b-a05b-4267-9eef-41b250239b2b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"),
                column: "ConcurrencyStamp",
                value: "05871a9b-ccd8-4853-a5b7-d6e2425b8276");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "62e580b3-b861-47a4-94d1-add07da81a24");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0ee3e5a7-89ed-4bd2-8729-c66311b30033"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b0d8aa4-7e17-4a2c-b256-2fc7b3ff324d", "DUCTV", "AQAAAAEAACcQAAAAELJa4hvB32gY4Pk73pO5XZmkLYVob7F1EuzSwTVL15GOQplm/w/of2O4fDGNYrOOzA==", "04f2d70f-3ae2-44cd-a0be-6444b1d1e15b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dd9d2d9-207a-476b-a991-f209d331505b", "AQAAAAEAACcQAAAAEGqO/MArh+wGCTK8kb4dittRmJhfHmHB/qaRkZ8CfcEENzlXmxQ5s/hCWuUkei9UuA==", "d94cd5dc-835d-4b22-b222-ecee8d050bb2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c85649c-2d04-4846-a5f2-212ea550291b"),
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9ccfcd6-c27e-4403-b7ae-858be0d10773", "LAMNT", "AQAAAAEAACcQAAAAEJQZkl8/h/QbhMlIs3zU4oMwaRRjHYERA84JwCwv+Zi7kuJdhwx4HZ6Aq7UfvBgdKA==", "44052830-8072-4a36-a6db-8bfde9157921" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6be8c63d-1399-47e8-831d-645d3181e5e6", "AQAAAAEAACcQAAAAEFt5FF22o05CYVwkUW14mrX8anmbDm9AVdiETiqDRko4kjItEv648hJEQ9tPkPdqnw==", "9cfa20fe-283d-4ba4-bb06-d1ef67c27586" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b551fd08-76d9-4040-b0fa-fb2e7aacbe7d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d058747-f1b6-42ae-a211-5485481b3b1e", "AQAAAAEAACcQAAAAELLvjO9hFNGr4QJmK+FMmVfNxhUQu0Kh2vcCAoK9c/zUir3B3IxpAuP6CeuWZycgYA==", "4b487d0b-35d4-4a37-a671-7da66fbf5602" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b8ddc2e0-8b14-4c37-869e-7ca5bad4671a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4178115-82ca-4940-ade0-d3d5ce6890ee", "AQAAAAEAACcQAAAAEGZWRlLL+wkuaQE/QmmrjRusJD22iUOe/qFZ1JI6v1Av9ZS+FTiCJcrQ/6pErObvNQ==", "413fb1f6-58f3-4ba2-b885-c735dcf22460" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c3a4a2eb-1703-4fc5-8511-f68acdb3a1d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7141a34f-1fe8-4365-8f4f-dcb0cf454ad0", "AQAAAAEAACcQAAAAEPmUTqfFD3BzQOHwA5LcXG3vVRrUx7PCydFu9wXVb8PF8Gp+7J7jua+O0ulsAEb8rA==", "eabafbb1-f10f-4d5b-a46a-81a9a55fd4d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e7d19c1e-a674-4d77-978a-47bbacd6910e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55412da0-14f3-4824-8856-16ee6285c595", "AQAAAAEAACcQAAAAEKW1QBxBn2q0qYAhvbcHJaHQLqTai7jvCqBms4P9vFGg0Lp2VjHmiNPr+WHqvd/UqA==", "e743f75c-6d7d-4bc2-805e-8013fdd972dd" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 25, 0, 37, 16, 957, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 25, 0, 37, 16, 957, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 25, 0, 37, 16, 957, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 25, 0, 37, 16, 957, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 25, 0, 37, 16, 957, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 25, 0, 37, 16, 957, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 25, 0, 37, 16, 957, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 25, 0, 37, 16, 957, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 25, 0, 37, 16, 957, DateTimeKind.Local).AddTicks(1377));
        }
    }
}
