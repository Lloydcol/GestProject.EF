using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestProject.EF.Migrations
{
    public partial class AddComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GestProject._GestProject.Columns_ColumnId",
                table: "GestProject.");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GestProject.",
                table: "GestProject.");

            migrationBuilder.RenameTable(
                name: "GestProject.",
                newName: "GestProject.Tickets");

            migrationBuilder.RenameIndex(
                name: "IX_GestProject._ColumnId",
                table: "GestProject.Tickets",
                newName: "IX_GestProject.Tickets_ColumnId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GestProject.Tickets",
                table: "GestProject.Tickets",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TicketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comment_GestProject.Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "GestProject.Tickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comment_TicketId",
                table: "Comment",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_GestProject.Tickets_GestProject.Columns_ColumnId",
                table: "GestProject.Tickets",
                column: "ColumnId",
                principalTable: "GestProject.Columns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GestProject.Tickets_GestProject.Columns_ColumnId",
                table: "GestProject.Tickets");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GestProject.Tickets",
                table: "GestProject.Tickets");

            migrationBuilder.RenameTable(
                name: "GestProject.Tickets",
                newName: "GestProject.");

            migrationBuilder.RenameIndex(
                name: "IX_GestProject.Tickets_ColumnId",
                table: "GestProject.",
                newName: "IX_GestProject._ColumnId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GestProject.",
                table: "GestProject.",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GestProject._GestProject.Columns_ColumnId",
                table: "GestProject.",
                column: "ColumnId",
                principalTable: "GestProject.Columns",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
