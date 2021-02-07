using Microsoft.EntityFrameworkCore.Migrations;

namespace Hamburger_site_MVC.Migrations
{
    public partial class UpdateDatabase5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 2,
                column: "IsBurgetOfTheWeek",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 2,
                column: "IsBurgetOfTheWeek",
                value: false);
        }
    }
}
