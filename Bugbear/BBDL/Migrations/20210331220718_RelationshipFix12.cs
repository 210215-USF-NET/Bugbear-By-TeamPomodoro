using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BBDL.Migrations
{
    [ExcludeFromCodeCoverage]
    public partial class RelationshipFix12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DizeRollValue",
                table: "Chats");

            migrationBuilder.DropColumn(
                name: "DizeSize",
                table: "Chats");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DizeRollValue",
                table: "Chats",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DizeSize",
                table: "Chats",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
