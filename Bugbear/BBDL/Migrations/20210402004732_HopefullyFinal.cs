using Microsoft.EntityFrameworkCore.Migrations;

namespace BBDL.Migrations
{
    public partial class HopefullyFinal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Encounters_Locations_LocationID",
                table: "Encounters");

            migrationBuilder.DropIndex(
                name: "IX_Encounters_LocationID",
                table: "Encounters");

            migrationBuilder.AlterColumn<int>(
                name: "LocationID",
                table: "Encounters",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "LocationID",
                table: "Encounters",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.CreateIndex(
                name: "IX_Encounters_LocationID",
                table: "Encounters",
                column: "LocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Encounters_Locations_LocationID",
                table: "Encounters",
                column: "LocationID",
                principalTable: "Locations",
                principalColumn: "LocationID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
