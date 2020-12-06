using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleDB.Server.Migrations
{
    public partial class UpdateModelMaxLengths : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StateOrProvince",
                table: "Address");

            migrationBuilder.AlterColumn<string>(
                name: "lastName",
                table: "Person",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "firstName",
                table: "Person",
                maxLength: 70,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Address",
                maxLength: 6,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Province",
                table: "Address",
                maxLength: 2,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Province",
                table: "Address");

            migrationBuilder.AlterColumn<string>(
                name: "lastName",
                table: "Person",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 70);

            migrationBuilder.AlterColumn<string>(
                name: "firstName",
                table: "Person",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 70);

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Address",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 6,
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StateOrProvince",
                table: "Address",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
