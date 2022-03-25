using Microsoft.EntityFrameworkCore.Migrations;

namespace WPF_RestfulAPI.Migrations
{
    public partial class PersonName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Positions",
                newName: "PositionName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Persons",
                newName: "FirstName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PositionName",
                table: "Positions",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Persons",
                newName: "Name");
        }
    }
}
