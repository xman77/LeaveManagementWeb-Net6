using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdateRequestCommentsAndRequestingEmployeeId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestingEmployeeId",
                table: "LeaveRequest",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequest",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd431ccbbf",
                column: "ConcurrencyStamp",
                value: "504d6ab4-0da5-44f3-b6ff-f1a1a25cf1c4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-labb431eabbe",
                column: "ConcurrencyStamp",
                value: "5e8dc165-d895-4685-833c-809d8dab4bb7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33deb6cf-62f7-4884-9546-04518095f7aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bada2b2-eb49-4bb4-a426-544e7bdaae0a", "AQAAAAEAACcQAAAAEN7KLPkGaNUHS/ERCa38+Osbp8Ts2moM9qwZ/bJCGBiYZvdmgYInnYO9jPG8it+iDQ==", "3547bb74-dc87-4687-b46b-cc3051135fb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33deb6cf-62f7-4884-9546-04518095f7ab",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "479e7c06-b0c8-4570-b1b0-98b163d38743", "AQAAAAEAACcQAAAAEJ/RQLQ0fh6WWprNxE1+5dmASRPBVI/VjWkgvXHjI25n2qzGAlTmGgJcMwCatV3+6w==", "1f3eaa41-e951-4cfa-be07-898bb25fc5f6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestingEmployeeId",
                table: "LeaveRequest",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequest",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd431ccbbf",
                column: "ConcurrencyStamp",
                value: "02329afd-7e37-40ef-b25a-2658305a1f49");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-labb431eabbe",
                column: "ConcurrencyStamp",
                value: "58fe5e25-a8b0-4459-90b0-f8a35e9e5b9d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33deb6cf-62f7-4884-9546-04518095f7aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58b51304-6ff2-4449-8195-46b8388d3707", "AQAAAAEAACcQAAAAELjCredfsQfbb9XSFrdKt0zwgvNhO2UPqsHOZwGCy3ootrGES8hImafeA9NEik93Yg==", "c2f9a302-ce21-4abf-971a-eba8a2232668" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33deb6cf-62f7-4884-9546-04518095f7ab",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e63d3187-0563-4c05-a67d-2555358aeaa7", "AQAAAAEAACcQAAAAEGOEQxUjbHuLb8Mt+/yxz64q1pugDXDfFj9UNkN76jqTI1zd0O7SHmEbxV3exRJHHw==", "c28e196a-8b0d-43fa-93d7-e3222dfcbec4" });
        }
    }
}
