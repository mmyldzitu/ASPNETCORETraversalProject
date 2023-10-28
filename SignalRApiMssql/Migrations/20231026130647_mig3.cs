using Microsoft.EntityFrameworkCore.Migrations;

namespace SignalRApiMssql.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityVisitCount",
                table: "Visitors",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CityVisitCount",
                table: "Visitors");
        }
    }
}
