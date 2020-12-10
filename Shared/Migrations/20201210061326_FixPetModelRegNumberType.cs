using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleDB.Server.Migrations
{
    public partial class FixPetModelRegNumberType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PetRegistrationNumber",
                table: "Pet",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int unsigned",
                oldMaxLength: 8);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<uint>(
                name: "PetRegistrationNumber",
                table: "Pet",
                type: "int unsigned",
                maxLength: 8,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 8);
        }
    }
}
