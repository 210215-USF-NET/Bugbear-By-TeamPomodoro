using Microsoft.EntityFrameworkCore.Migrations;

namespace BBDL.Migrations
{
    public partial class RelationshipFix3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CampaignID",
                table: "Users",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CampaignID",
                table: "Users",
                column: "CampaignID");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Campaigns_CampaignID",
                table: "Users",
                column: "CampaignID",
                principalTable: "Campaigns",
                principalColumn: "CampaignID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Campaigns_CampaignID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CampaignID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CampaignID",
                table: "Users");
        }
    }
}
