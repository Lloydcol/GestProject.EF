using Microsoft.EntityFrameworkCore.Migrations;

namespace GestProject.EF.Migrations
{
    public partial class MajComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comment_GestProject.Tickets_TicketId",
                table: "Comment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comment",
                table: "Comment");

            migrationBuilder.RenameTable(
                name: "Comment",
                newName: "GestProject.Comments");

            migrationBuilder.RenameIndex(
                name: "IX_Comment_TicketId",
                table: "GestProject.Comments",
                newName: "IX_GestProject.Comments_TicketId");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "GestProject.Comments",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GestProject.Comments",
                table: "GestProject.Comments",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GestProject.Comments_GestProject.Tickets_TicketId",
                table: "GestProject.Comments",
                column: "TicketId",
                principalTable: "GestProject.Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GestProject.Comments_GestProject.Tickets_TicketId",
                table: "GestProject.Comments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GestProject.Comments",
                table: "GestProject.Comments");

            migrationBuilder.RenameTable(
                name: "GestProject.Comments",
                newName: "Comment");

            migrationBuilder.RenameIndex(
                name: "IX_GestProject.Comments_TicketId",
                table: "Comment",
                newName: "IX_Comment_TicketId");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Comment",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comment",
                table: "Comment",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Comment_GestProject.Tickets_TicketId",
                table: "Comment",
                column: "TicketId",
                principalTable: "GestProject.Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
