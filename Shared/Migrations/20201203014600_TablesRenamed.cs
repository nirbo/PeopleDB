using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleDB.Server.Migrations
{
    public partial class TablesRenamed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Persons_Id",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Persons_Id",
                table: "Pets");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehicles_Persons_Id",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pets",
                table: "Pets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Persons",
                table: "Persons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Vehicles",
                newName: "Vehicle");

            migrationBuilder.RenameTable(
                name: "Pets",
                newName: "Pet");

            migrationBuilder.RenameTable(
                name: "Persons",
                newName: "Person");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pet",
                table: "Pet",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Person",
                table: "Person",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vehicle",
                table: "Vehicle");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pet",
                table: "Pet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Person",
                table: "Person");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "Vehicle",
                newName: "Vehicles");

            migrationBuilder.RenameTable(
                name: "Pet",
                newName: "Pets");

            migrationBuilder.RenameTable(
                name: "Person",
                newName: "Persons");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vehicles",
                table: "Vehicles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pets",
                table: "Pets",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Persons",
                table: "Persons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Persons_Id",
                table: "Addresses",
                column: "Id",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Persons_Id",
                table: "Pets",
                column: "Id",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehicles_Persons_Id",
                table: "Vehicles",
                column: "Id",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
