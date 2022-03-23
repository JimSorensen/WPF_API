using Microsoft.EntityFrameworkCore.Migrations;

namespace WPF_RestfulAPI.Migrations
{
    public partial class updateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirtDay",
                table: "PersonDetails",
                newName: "BirthDay");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthDay",
                table: "PersonDetails",
                newName: "BirtDay");
        }
    }
}
