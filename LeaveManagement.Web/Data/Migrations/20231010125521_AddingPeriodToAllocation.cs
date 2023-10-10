using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbf07750-8934-46f0-80a2-0737df36b784", "AQAAAAEAACcQAAAAELJ/8fP5di7LmkBYgXQiJ8lUWUk8svjylpmHN9ZKILWnhoHA0e8xsdJPgNJgc3WwMQ==", "4af51a17-5656-4dbd-8dcd-e8a592bb4475" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33deb6cf-62f7-4884-9546-04518095f7ab",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da1f155b-73f1-404e-9941-55a964dc9beb", "AQAAAAEAACcQAAAAENhzc5nKrimSl6P4DQ5omQKwkY1sc2RrtpeOsKHQwdBmpxAxSv+yIsFexhkgVBd3lQ==", "2c563e33-6e47-4945-87f3-56b76257d0c4" });
        }
    }
}
