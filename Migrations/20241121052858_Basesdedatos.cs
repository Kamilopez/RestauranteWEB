using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestauranteWEB.Migrations
{
    /// <inheritdoc />
    public partial class Basesdedatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallesPlato_Ingredientes_IngredientesId",
                table: "DetallesPlato");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallesPlato_Platos_PlatoId",
                table: "DetallesPlato");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetallesPlato",
                table: "DetallesPlato");

            migrationBuilder.RenameTable(
                name: "DetallesPlato",
                newName: "DetallesPlatos");

            migrationBuilder.RenameIndex(
                name: "IX_DetallesPlato_PlatoId",
                table: "DetallesPlatos",
                newName: "IX_DetallesPlatos_PlatoId");

            migrationBuilder.RenameIndex(
                name: "IX_DetallesPlato_IngredientesId",
                table: "DetallesPlatos",
                newName: "IX_DetallesPlatos_IngredientesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetallesPlatos",
                table: "DetallesPlatos",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Proveedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreEmpresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contacto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefono = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProveedorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Proveedores_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Pedidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdProveedor = table.Column<int>(type: "int", nullable: false),
                    ProveedorId = table.Column<int>(type: "int", nullable: true),
                    FechaPedido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pedidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pedidos_Proveedores_ProveedorId",
                        column: x => x.ProveedorId,
                        principalTable: "Proveedores",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ProveedorId",
                table: "Pedidos",
                column: "ProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_ProveedorId",
                table: "Proveedores",
                column: "ProveedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesPlatos_Ingredientes_IngredientesId",
                table: "DetallesPlatos",
                column: "IngredientesId",
                principalTable: "Ingredientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesPlatos_Platos_PlatoId",
                table: "DetallesPlatos",
                column: "PlatoId",
                principalTable: "Platos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallesPlatos_Ingredientes_IngredientesId",
                table: "DetallesPlatos");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallesPlatos_Platos_PlatoId",
                table: "DetallesPlatos");

            migrationBuilder.DropTable(
                name: "Pedidos");

            migrationBuilder.DropTable(
                name: "Proveedores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetallesPlatos",
                table: "DetallesPlatos");

            migrationBuilder.RenameTable(
                name: "DetallesPlatos",
                newName: "DetallesPlato");

            migrationBuilder.RenameIndex(
                name: "IX_DetallesPlatos_PlatoId",
                table: "DetallesPlato",
                newName: "IX_DetallesPlato_PlatoId");

            migrationBuilder.RenameIndex(
                name: "IX_DetallesPlatos_IngredientesId",
                table: "DetallesPlato",
                newName: "IX_DetallesPlato_IngredientesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetallesPlato",
                table: "DetallesPlato",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesPlato_Ingredientes_IngredientesId",
                table: "DetallesPlato",
                column: "IngredientesId",
                principalTable: "Ingredientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesPlato_Platos_PlatoId",
                table: "DetallesPlato",
                column: "PlatoId",
                principalTable: "Platos",
                principalColumn: "Id");
        }
    }
}
