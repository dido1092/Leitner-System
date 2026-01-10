using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leitner_Systems.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTableGroupingWord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroupingWords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BoxName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupNum = table.Column<int>(type: "int", nullable: false),
                    TimeNum = table.Column<int>(type: "int", nullable: false),
                    TimeType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupingWords", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GroupingWords");
        }
    }
}
