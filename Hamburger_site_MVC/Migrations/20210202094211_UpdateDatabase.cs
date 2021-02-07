using Microsoft.EntityFrameworkCore.Migrations;

namespace Hamburger_site_MVC.Migrations
{
    public partial class UpdateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 1,
                column: "Price",
                value: 17.55m);

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 3,
                column: "Price",
                value: 22.5m);

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 4,
                column: "Price",
                value: 20.3m);

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 5,
                column: "Price",
                value: 10.01m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 1,
                column: "Price",
                value: 17m);

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 3,
                column: "Price",
                value: 22m);

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 4,
                column: "Price",
                value: 20m);

            migrationBuilder.UpdateData(
                table: "Burgers",
                keyColumn: "BurgerId",
                keyValue: 5,
                column: "Price",
                value: 10m);
        }
    }
}
