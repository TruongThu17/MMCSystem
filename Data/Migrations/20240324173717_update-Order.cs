using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class updateOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EducationId",
                table: "Order",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b0d8aa4-7e17-4a2c-b256-2fc7b3ff324d", "AQAAAAEAACcQAAAAELJa4hvB32gY4Pk73pO5XZmkLYVob7F1EuzSwTVL15GOQplm/w/of2O4fDGNYrOOzA==", "04f2d70f-3ae2-44cd-a0be-6444b1d1e15b" });

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9ccfcd6-c27e-4403-b7ae-858be0d10773", "AQAAAAEAACcQAAAAEJQZkl8/h/QbhMlIs3zU4oMwaRRjHYERA84JwCwv+Zi7kuJdhwx4HZ6Aq7UfvBgdKA==", "44052830-8072-4a36-a6db-8bfde9157921" });

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

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 9,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 10,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 11,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 12,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 13,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 14,
                column: "EducationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 15,
                column: "EducationId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Order_EducationId",
                table: "Order",
                column: "EducationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Education_EducationId",
                table: "Order",
                column: "EducationId",
                principalTable: "Education",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Education_EducationId",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_EducationId",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "EducationId",
                table: "Order");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30a990c6-33c7-4884-9dcb-718ce356eb0d"),
                column: "ConcurrencyStamp",
                value: "80ca6f71-73ae-470c-ace6-015fdfbc0d3f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("6335deda-9f1c-43d4-908f-58073ff07896"),
                column: "ConcurrencyStamp",
                value: "ebe3a524-538f-4f34-a758-ea6282aa6c25");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"),
                column: "ConcurrencyStamp",
                value: "fa23da1b-8025-4ef7-8d01-6a543bf84e1a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0ee3e5a7-89ed-4bd2-8729-c66311b30033"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4a9d198-6a5a-4fe3-8490-016ec909e6b3", "AQAAAAEAACcQAAAAEP7t26RL07yX/ifNHC2aNUYPy2dPPVu2+FSa23CZ1IVABFyABvCyzWMOSjTLgOVzVQ==", "bcf6d8a3-7e35-45dc-a5ac-581620a1c159" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("55d0cc53-0678-4604-b3fc-68bca03a3d44"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf175ac3-90a1-49f0-9f74-dbc29db29dea", "AQAAAAEAACcQAAAAENUnrY7c5TDXoJoaDjsF/TKt9tHD668Ga14QdAW9Jly5Uepr8rllFl2IXRInNO8/FA==", "5fdf7aec-bd64-442c-aefa-6b079762d899" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7c85649c-2d04-4846-a5f2-212ea550291b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3145fb3-a09e-47e2-a924-c9b4b38c778b", "AQAAAAEAACcQAAAAECtJOV3lndrDFgXGUBIC1tZWPB0T9OcM/2iUt52DbnbasNufyE3SZu1Nyu2akP6XDw==", "96edb2b9-a585-451c-9ff8-d33ba407fdbe" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("9d9d014c-af65-447a-a8c0-6475358bfff9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a01e2e72-ab7a-42ee-8a66-76cc9d48d892", "AQAAAAEAACcQAAAAEOOWu61dj/j+ASKO/V7AEpTnRPZ/7YJloA3vMttDZcBuTu4iEQY6DM3q0GAMUCHUfw==", "00be5a61-935a-449d-8fd8-4a97eab9528b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b551fd08-76d9-4040-b0fa-fb2e7aacbe7d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a83a73c2-3654-4984-9f22-fd1319041d91", "AQAAAAEAACcQAAAAEHcymCduxzffylojG6xFonGtrFi3dbWpU7xEMzu1wM7JAJifkFez04Iz6cUnZ2IJtQ==", "6521a5d4-4de3-438f-8573-cc2f56e1f36d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b8ddc2e0-8b14-4c37-869e-7ca5bad4671a"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "358e397a-2247-4870-94f3-be2a5da58660", "AQAAAAEAACcQAAAAEIM+1zuXGA5zvEQRNkxKLPZ2l5mvR1kEUNn91+Jy03J7nDHrhXOYVzxEvTvm4Ju1MQ==", "6fb3ec42-fe6d-4298-a18d-6318853736ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c3a4a2eb-1703-4fc5-8511-f68acdb3a1d9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39b65aa2-c204-447d-9523-d4bfe289dbbe", "AQAAAAEAACcQAAAAEF2JcS2HSkErtENTOobYLikrEva4EZZNwSd8oU6iiZ1ISVCkgfisk5OVt8QaaXDqfw==", "ea592679-06c1-4320-bc65-0454a3cc58f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e7d19c1e-a674-4d77-978a-47bbacd6910e"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "106646b7-a00a-45a0-9ed6-9cf4fbec7ca2", "AQAAAAEAACcQAAAAEN1B9Pl9JwxKy+TOqN8KLyOXDa/H1l/wwcwtL69w9wLB7oXqVzi569P5d3/iMBx8+A==", "cbf1f440-98b3-4abc-9ff2-05b362a6d24d" });

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 25, 0, 28, 54, 875, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 3, 25, 0, 28, 54, 875, DateTimeKind.Local).AddTicks(3767));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 3, 25, 0, 28, 54, 875, DateTimeKind.Local).AddTicks(3769));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2024, 3, 25, 0, 28, 54, 875, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2024, 3, 25, 0, 28, 54, 875, DateTimeKind.Local).AddTicks(3771));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 6,
                column: "Date",
                value: new DateTime(2024, 3, 25, 0, 28, 54, 875, DateTimeKind.Local).AddTicks(3772));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 7,
                column: "Date",
                value: new DateTime(2024, 3, 25, 0, 28, 54, 875, DateTimeKind.Local).AddTicks(3773));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 8,
                column: "Date",
                value: new DateTime(2024, 3, 25, 0, 28, 54, 875, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "Blog",
                keyColumn: "ID",
                keyValue: 9,
                column: "Date",
                value: new DateTime(2024, 3, 25, 0, 28, 54, 875, DateTimeKind.Local).AddTicks(3779));
        }
    }
}
