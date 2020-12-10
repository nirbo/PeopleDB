using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleDB.Server.Migrations
{
    public partial class AddUniquesForNewModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "VehicleIdNumber",
                table: "Vehicle",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_VehicleIdNumber",
                table: "Vehicle",
                column: "VehicleIdNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pet_PetRegistrationNumber",
                table: "Pet",
                column: "PetRegistrationNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Vehicle_VehicleIdNumber",
                table: "Vehicle");

            migrationBuilder.DropIndex(
                name: "IX_Pet_PetRegistrationNumber",
                table: "Pet");

            migrationBuilder.AlterColumn<string>(
                name: "VehicleIdNumber",
                table: "Vehicle",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
