using Microsoft.EntityFrameworkCore.Migrations;

namespace GestProject.EF.Migrations
{
    public partial class AddColorTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "GestProject.",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "GestProject.");
        }
    }
}
