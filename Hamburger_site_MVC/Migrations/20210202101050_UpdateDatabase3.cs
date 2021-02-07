using Microsoft.EntityFrameworkCore.Migrations;

namespace Hamburger_site_MVC.Migrations
{
    public partial class UpdateDatabase3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 2,
                column: "ImageUrl",
                value: "/Images/cheese_burger.jpg");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 3,
                column: "ImageUrl",
                value: "/Images/colosal_burger.jpg");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 4,
                column: "ImageUrl",
                value: "/Images/double_burger.jpg");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 5,
                column: "ImageUrl",
                value: "/Images/minimal_burger.jpg");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 6,
                column: "ImageUrl",
                value: "/Images/vega_burger.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 2,
                column: "ImageUrl",
                value: "~/Images/cheese_burger.jpg");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 3,
                column: "ImageUrl",
                value: "~/Images/colosal_burger.jpg");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 4,
                column: "ImageUrl",
                value: "~/Images/double_burger.jpg");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 5,
                column: "ImageUrl",
                value: "~/Images/minimal_burger.jpg");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 6,
                column: "ImageUrl",
                value: "~/Images/vega_burger.jpg");
        }
    }
}
