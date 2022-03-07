using Microsoft.EntityFrameworkCore.Migrations;

namespace animesFilmesCRUD_APP.Migrations
{
    public partial class fixTitleColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "Films",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Titulo",
                table: "Animes",
                newName: "Title");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Films",
                newName: "Titulo");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Animes",
                newName: "Titulo");
        }
    }
}
