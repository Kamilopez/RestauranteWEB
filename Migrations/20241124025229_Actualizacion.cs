using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestauranteWEB.Migrations
{
    /// <inheritdoc />
    public partial class Actualizacion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallesPlatos_Ingredientes_IngredientesId",
                table: "DetallesPlatos");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallesPlatos_Platos_PlatoId",
                table: "DetallesPlatos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Proveedores_ProveedorId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "IdProveedor",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "IdIngredientes",
                table: "DetallesPlatos");

            migrationBuilder.DropColumn(
                name: "IdPlato",
                table: "DetallesPlatos");

            migrationBuilder.AlterColumn<int>(
                name: "ProveedorId",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PlatoId",
                table: "DetallesPlatos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "IngredientesId",
                table: "DetallesPlatos",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesPlatos_Ingredientes_IngredientesId",
                table: "DetallesPlatos",
                column: "IngredientesId",
                principalTable: "Ingredientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesPlatos_Platos_PlatoId",
                table: "DetallesPlatos",
                column: "PlatoId",
                principalTable: "Platos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Proveedores_ProveedorId",
                table: "Pedidos",
                column: "ProveedorId",
                principalTable: "Proveedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Proveedores_ProveedorId",
                table: "Pedidos");

            migrationBuilder.AlterColumn<int>(
                name: "ProveedorId",
                table: "Pedidos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdProveedor",
                table: "Pedidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "PlatoId",
                table: "DetallesPlatos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "IngredientesId",
                table: "DetallesPlatos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "IdIngredientes",
                table: "DetallesPlatos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdPlato",
                table: "DetallesPlatos",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Proveedores_ProveedorId",
                table: "Pedidos",
                column: "ProveedorId",
                principalTable: "Proveedores",
                principalColumn: "Id");
        }
    }
}
