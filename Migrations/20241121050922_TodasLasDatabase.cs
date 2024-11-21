using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestauranteWEB.Migrations
{
    /// <inheritdoc />
    public partial class TodasLasDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioVenta",
                table: "Platos",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioUnitario",
                table: "Ingredientes",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");

            migrationBuilder.CreateTable(
                name: "DetallesPlato",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdPlato = table.Column<int>(type: "int", nullable: false),
                    PlatoId = table.Column<int>(type: "int", nullable: true),
                    IdIngredientes = table.Column<int>(type: "int", nullable: false),
                    IngredientesId = table.Column<int>(type: "int", nullable: true),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetallesPlato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetallesPlato_Ingredientes_IngredientesId",
                        column: x => x.IngredientesId,
                        principalTable: "Ingredientes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DetallesPlato_Platos_PlatoId",
                        column: x => x.PlatoId,
                        principalTable: "Platos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetallesPlato_IngredientesId",
                table: "DetallesPlato",
                column: "IngredientesId");

            migrationBuilder.CreateIndex(
                name: "IX_DetallesPlato_PlatoId",
                table: "DetallesPlato",
                column: "PlatoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetallesPlato");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioVenta",
                table: "Platos",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "PrecioUnitario",
                table: "Ingredientes",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");
        }
    }
}
