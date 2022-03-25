using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WPF_RestfulAPI.Migrations
{
    public partial class SalaryAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "Persons");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreateDate",
                table: "PersonDetails",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreateDate",
                table: "PersonDetails");

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "CreateDate",
                table: "Persons",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));
        }
    }
}
