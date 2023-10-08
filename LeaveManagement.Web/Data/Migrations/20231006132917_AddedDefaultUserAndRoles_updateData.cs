using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUserAndRoles_updateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd431ccbbf",
                column: "ConcurrencyStamp",
                value: "ccbf2cb8-eb71-4a46-a8ce-7107e7f61d29");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-labb431eabbe",
                column: "ConcurrencyStamp",
                value: "23f7310f-ee42-44cd-8458-aafaeb99c10b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33deb6cf-62f7-4884-9546-04518095f7aa",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "dbf07750-8934-46f0-80a2-0737df36b784", true, "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAELJ/8fP5di7LmkBYgXQiJ8lUWUk8svjylpmHN9ZKILWnhoHA0e8xsdJPgNJgc3WwMQ==", "4af51a17-5656-4dbd-8dcd-e8a592bb4475", "admin@test.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33deb6cf-62f7-4884-9546-04518095f7ab",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "da1f155b-73f1-404e-9941-55a964dc9beb", true, "USER@TEST.COM", "AQAAAAEAACcQAAAAENhzc5nKrimSl6P4DQ5omQKwkY1sc2RrtpeOsKHQwdBmpxAxSv+yIsFexhkgVBd3lQ==", "2c563e33-6e47-4945-87f3-56b76257d0c4", "user@test.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd431ccbbf",
                column: "ConcurrencyStamp",
                value: "e1d7c895-73b5-4fb8-84e3-9bd50ab11c8b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-labb431eabbe",
                column: "ConcurrencyStamp",
                value: "a5260015-f974-4bdd-aad0-5478ab366f41");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33deb6cf-62f7-4884-9546-04518095f7aa",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "fbe979f5-c638-44c7-9d6d-12440866e200", false, null, "AQAAAAEAACcQAAAAEIW2lhDuU7LlzeoR4HrBBP9WY+xzfzEAJgt4u6rHWf1lIFQ/2QD1qymIcpgTaUkHjQ==", "9ca07b0d-7002-4dd2-bbec-8c2f3cab81ec", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33deb6cf-62f7-4884-9546-04518095f7ab",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5b9cc8bc-fbf7-44d3-bb7b-e959edf623cc", false, null, "AQAAAAEAACcQAAAAEOh5pwP6150AMl3PaG4n2ZpqwWFUzvB5gG81GmkU0xm0nddCgBa4UcQfCQDIAM7XzA==", "fdda5598-2921-4add-9aaa-9e22b5fe6153", null });
        }
    }
}
