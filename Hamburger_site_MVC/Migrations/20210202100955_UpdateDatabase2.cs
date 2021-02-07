using Microsoft.EntityFrameworkCore.Migrations;

namespace Hamburger_site_MVC.Migrations
{
    public partial class UpdateDatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 1,
                column: "ImageUrl",
                value: "/Images/black_burger.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 1,
                column: "ImageUrl",
                value: "~/Images/black_burger.jpg");
        }
    }
}
