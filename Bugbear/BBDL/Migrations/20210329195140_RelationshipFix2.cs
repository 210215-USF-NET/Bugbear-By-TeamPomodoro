using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BBDL.Migrations
{
    [ExcludeFromCodeCoverage]
    public partial class RelationshipFix2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CampaignUsers",
                table: "Campaigns");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int[]>(
                name: "CampaignUsers",
                table: "Campaigns",
                type: "integer[]",
                nullable: true);
        }
    }
}
