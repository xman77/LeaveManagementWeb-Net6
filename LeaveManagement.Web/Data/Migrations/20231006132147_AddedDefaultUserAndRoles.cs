using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUserAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-ladd431ccbbf", "e1d7c895-73b5-4fb8-84e3-9bd50ab11c8b", "Administrator", "ADMINISTRATOR" },
                    { "cac43a7e-f7cb-4148-baaf-labb431eabbe", "a5260015-f974-4bdd-aad0-5478ab366f41", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "33deb6cf-62f7-4884-9546-04518095f7aa", 0, "fbe979f5-c638-44c7-9d6d-12440866e200", null, null, "admin@test.com", false, "System", "Admin", false, null, "ADMIN@TEST.COM", null, "AQAAAAEAACcQAAAAEIW2lhDuU7LlzeoR4HrBBP9WY+xzfzEAJgt4u6rHWf1lIFQ/2QD1qymIcpgTaUkHjQ==", null, false, "9ca07b0d-7002-4dd2-bbec-8c2f3cab81ec", null, false, null },
                    { "33deb6cf-62f7-4884-9546-04518095f7ab", 0, "5b9cc8bc-fbf7-44d3-bb7b-e959edf623cc", null, null, "user@test.com", false, "System", "User", false, null, "USER@TEST.COM", null, "AQAAAAEAACcQAAAAEOh5pwP6150AMl3PaG4n2ZpqwWFUzvB5gG81GmkU0xm0nddCgBa4UcQfCQDIAM7XzA==", null, false, "fdda5598-2921-4add-9aaa-9e22b5fe6153", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a6e-f7bb-4448-baaf-ladd431ccbbf", "33deb6cf-62f7-4884-9546-04518095f7aa" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "cac43a7e-f7cb-4148-baaf-labb431eabbe", "33deb6cf-62f7-4884-9546-04518095f7ab" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a6e-f7bb-4448-baaf-ladd431ccbbf", "33deb6cf-62f7-4884-9546-04518095f7aa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "cac43a7e-f7cb-4148-baaf-labb431eabbe", "33deb6cf-62f7-4884-9546-04518095f7ab" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd431ccbbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-labb431eabbe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33deb6cf-62f7-4884-9546-04518095f7aa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33deb6cf-62f7-4884-9546-04518095f7ab");
        }
    }
}
