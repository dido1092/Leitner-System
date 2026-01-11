using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leitner_Systems.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTableSetAllBoxesForFirstWord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "setAllBoxesToFirstWords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsChecked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_setAllBoxesToFirstWords", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "setAllBoxesToFirstWords");
        }
    }
}
