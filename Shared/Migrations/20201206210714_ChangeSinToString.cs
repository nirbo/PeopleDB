using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleDB.Server.Migrations
{
    public partial class ChangeSinToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "sin",
                table: "Person",
                maxLength: 9,
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int unsigned",
                oldMaxLength: 9);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<uint>(
                name: "sin",
                table: "Person",
                type: "int unsigned",
                maxLength: 9,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 9);
        }
    }
}
