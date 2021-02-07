using Microsoft.EntityFrameworkCore.Migrations;

namespace Hamburger_site_MVC.Migrations
{
    public partial class UpdateDatabase4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 1,
                column: "Description",
                value: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 2,
                column: "Description",
                value: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 3,
                column: "Description",
                value: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 4,
                column: "Description",
                value: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 5,
                column: "Description",
                value: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 6,
                column: "Description",
                value: "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 1,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 2,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 3,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 4,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 5,
                column: "Description",
                value: "");

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 6,
                column: "Description",
                value: "");
        }
    }
}
