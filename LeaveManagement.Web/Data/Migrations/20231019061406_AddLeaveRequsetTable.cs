using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddLeaveRequsetTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequest",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequest_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequest_LeaveTypeId",
                table: "LeaveRequest",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequest");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-ladd431ccbbf",
                column: "ConcurrencyStamp",
                value: "99b0a6c9-1d6d-409c-a429-86753c500f75");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-labb431eabbe",
                column: "ConcurrencyStamp",
                value: "99ab341a-66be-4121-b570-602488baadfa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33deb6cf-62f7-4884-9546-04518095f7aa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7fa67dd-905c-4d89-af77-02df88e12a9e", "AQAAAAEAACcQAAAAEPkjxT+EOuXQ1/9ju3FEO5IJoLgRCaNHOUX+iWMAcCvwaXfAt1yayH8bEPAep3ncvA==", "04e1a281-249f-4eef-aec6-6e4295b553e9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33deb6cf-62f7-4884-9546-04518095f7ab",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e08282d-5c30-474f-abf9-3e3806678355", "AQAAAAEAACcQAAAAEGbUyHa2IjBMv8pVyRE8V9/J37A1mHhqNtQROFdO7aV0YQpXinMIOoA9Tw9y39rkVQ==", "0ffd406c-8b4a-46f2-8d66-535e8f3c0923" });
        }
    }
}
