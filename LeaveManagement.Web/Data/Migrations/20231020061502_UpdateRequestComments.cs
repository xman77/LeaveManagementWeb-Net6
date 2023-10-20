using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdateRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestingEmployeeId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd431ccbbf",
                column: "ConcurrencyStamp",
                value: "d7c09d4c-35a5-454c-90bb-a8660f62759c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-labb431eabbe",
                column: "ConcurrencyStamp",
                value: "faa19841-5497-4092-89c4-319a4272102b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33deb6cf-62f7-4884-9546-04518095f7aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e63377b3-125a-4251-aaeb-f2c5785b3b48", "AQAAAAEAACcQAAAAENph946dgcA2jmTygEpH7c1fxhg3OyNKcU07TtCeQRSLer9gtTk8qlLh23tNfiYe7Q==", "2d2355dc-3ba2-407a-9419-faf1095e1558" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33deb6cf-62f7-4884-9546-04518095f7ab",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29192dbe-caf8-4a52-aa27-5c4dba8e30a3", "AQAAAAEAACcQAAAAEPArb92O9ecxvzydnHN5s7IereBW+wYUwEXtKeKMch8q7mY3Qykv4DWpKGysI4qN9A==", "6667501a-4052-487d-83f0-cbce81826cc0" });
        }
    }
}
