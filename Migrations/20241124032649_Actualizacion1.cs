using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestauranteWEB.Migrations
{
    /// <inheritdoc />
    public partial class Actualizacion1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Platos",
                newName: "NombreP");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Ingredientes",
                newName: "NombreI");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NombreP",
                table: "Platos",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "NombreI",
                table: "Ingredientes",
                newName: "Nombre");
        }
    }
}
