using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leitner_Systems.Migrations
{
    /// <inheritdoc />
    public partial class AddBoxSixAndBoxSeven : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BoxSeven",
                table: "Timers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BoxSix",
                table: "Timers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "BoxSevens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BgWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PerformanceTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoxSevens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BoxSixs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BgWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PerformanceTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoxSixs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BoxSevens");

            migrationBuilder.DropTable(
                name: "BoxSixs");

            migrationBuilder.DropColumn(
                name: "BoxSeven",
                table: "Timers");

            migrationBuilder.DropColumn(
                name: "BoxSix",
                table: "Timers");
        }
    }
}
