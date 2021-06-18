using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GestProject.EF.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GestProject.Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GestProject.Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GestProject.Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Passwd = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Salt = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GestProject.Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GestProject.Columns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccessibleBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GestProject.Columns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GestProject.Columns_GestProject.Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "GestProject.Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GestProject.WorkOn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GestProject.WorkOn", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GestProject.WorkOn_GestProject.Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "GestProject.Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GestProject.WorkOn_GestProject.Users_UserId",
                        column: x => x.UserId,
                        principalTable: "GestProject.Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GestProject.",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<int>(type: "int", nullable: false),
                    ColumnId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GestProject.", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GestProject._GestProject.Columns_ColumnId",
                        column: x => x.ColumnId,
                        principalTable: "GestProject.Columns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GestProject._ColumnId",
                table: "GestProject.",
                column: "ColumnId");

            migrationBuilder.CreateIndex(
                name: "IX_GestProject.Columns_ProjectId",
                table: "GestProject.Columns",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_GestProject.Users_Email",
                table: "GestProject.Users",
                column: "Email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GestProject.Users_Salt",
                table: "GestProject.Users",
                column: "Salt",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_GestProject.WorkOn_ProjectId",
                table: "GestProject.WorkOn",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_GestProject.WorkOn_UserId",
                table: "GestProject.WorkOn",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GestProject.");

            migrationBuilder.DropTable(
                name: "GestProject.WorkOn");

            migrationBuilder.DropTable(
                name: "GestProject.Columns");

            migrationBuilder.DropTable(
                name: "GestProject.Users");

            migrationBuilder.DropTable(
                name: "GestProject.Projects");
        }
    }
}
