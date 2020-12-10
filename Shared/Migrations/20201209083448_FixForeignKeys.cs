using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleDB.Server.Migrations
{
    public partial class FixForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Person_Id",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Pet_Person_Id",
                table: "Pet");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Person_Id",
                table: "Vehicle");

            migrationBuilder.AlterColumn<uint>(
                name: "Id",
                table: "Vehicle",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<uint>(
                name: "PersonId",
                table: "Vehicle",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AlterColumn<uint>(
                name: "Id",
                table: "Pet",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<uint>(
                name: "PersonId",
                table: "Pet",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AddColumn<uint>(
                name: "AddressId",
                table: "Person",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.AlterColumn<uint>(
                name: "Id",
                table: "Address",
                nullable: false,
                oldClrType: typeof(uint),
                oldType: "int unsigned")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<uint>(
                name: "PersonId",
                table: "Address",
                nullable: false,
                defaultValue: 0u);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_PersonId",
                table: "Vehicle",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Pet_PersonId",
                table: "Pet",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_PersonId",
                table: "Address",
                column: "PersonId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Person_PersonId",
                table: "Address",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_Person_PersonId",
                table: "Pet",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Person_PersonId",
                table: "Vehicle",
                column: "PersonId",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Person_PersonId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Pet_Person_PersonId",
                table: "Pet");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicle_Person_PersonId",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_Vehicle_PersonId",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_Pet_PersonId",
                table: "Pet");

            migrationBuilder.DropIndex(
                name: "IX_Address_PersonId",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Vehicle");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Pet");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Address");

            migrationBuilder.AlterColumn<uint>(
                name: "Id",
                table: "Vehicle",
                type: "int unsigned",
                nullable: false,
                oldClrType: typeof(uint))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "Id",
                table: "Pet",
                type: "int unsigned",
                nullable: false,
                oldClrType: typeof(uint))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<uint>(
                name: "Id",
                table: "Address",
                type: "int unsigned",
                nullable: false,
                oldClrType: typeof(uint))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Person_Id",
                table: "Address",
                column: "Id",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pet_Person_Id",
                table: "Pet",
                column: "Id",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicle_Person_Id",
                table: "Vehicle",
                column: "Id",
                principalTable: "Person",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
