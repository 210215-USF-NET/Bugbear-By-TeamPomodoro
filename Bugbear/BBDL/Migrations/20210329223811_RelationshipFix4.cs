using Microsoft.EntityFrameworkCore.Migrations;

namespace BBDL.Migrations
{
    public partial class RelationshipFix4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CampaignID",
                table: "Characters",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Stories_CampaignID",
                table: "Stories",
                column: "CampaignID");

            migrationBuilder.CreateIndex(
                name: "IX_NPCs_CampaignID",
                table: "NPCs",
                column: "CampaignID");

            migrationBuilder.CreateIndex(
                name: "IX_Maps_CampaignID",
                table: "Maps",
                column: "CampaignID");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CampaignID",
                table: "Locations",
                column: "CampaignID");

            migrationBuilder.CreateIndex(
                name: "IX_Encounters_CampaignID",
                table: "Encounters",
                column: "CampaignID");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CampaignID",
                table: "Characters",
                column: "CampaignID");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Campaigns_CampaignID",
                table: "Characters",
                column: "CampaignID",
                principalTable: "Campaigns",
                principalColumn: "CampaignID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Encounters_Campaigns_CampaignID",
                table: "Encounters",
                column: "CampaignID",
                principalTable: "Campaigns",
                principalColumn: "CampaignID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Campaigns_CampaignID",
                table: "Locations",
                column: "CampaignID",
                principalTable: "Campaigns",
                principalColumn: "CampaignID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Maps_Campaigns_CampaignID",
                table: "Maps",
                column: "CampaignID",
                principalTable: "Campaigns",
                principalColumn: "CampaignID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NPCs_Campaigns_CampaignID",
                table: "NPCs",
                column: "CampaignID",
                principalTable: "Campaigns",
                principalColumn: "CampaignID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stories_Campaigns_CampaignID",
                table: "Stories",
                column: "CampaignID",
                principalTable: "Campaigns",
                principalColumn: "CampaignID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Campaigns_CampaignID",
                table: "Characters");

            migrationBuilder.DropForeignKey(
                name: "FK_Encounters_Campaigns_CampaignID",
                table: "Encounters");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Campaigns_CampaignID",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Maps_Campaigns_CampaignID",
                table: "Maps");

            migrationBuilder.DropForeignKey(
                name: "FK_NPCs_Campaigns_CampaignID",
                table: "NPCs");

            migrationBuilder.DropForeignKey(
                name: "FK_Stories_Campaigns_CampaignID",
                table: "Stories");

            migrationBuilder.DropIndex(
                name: "IX_Stories_CampaignID",
                table: "Stories");

            migrationBuilder.DropIndex(
                name: "IX_NPCs_CampaignID",
                table: "NPCs");

            migrationBuilder.DropIndex(
                name: "IX_Maps_CampaignID",
                table: "Maps");

            migrationBuilder.DropIndex(
                name: "IX_Locations_CampaignID",
                table: "Locations");

            migrationBuilder.DropIndex(
                name: "IX_Encounters_CampaignID",
                table: "Encounters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_CampaignID",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "CampaignID",
                table: "Characters");
        }
    }
}
