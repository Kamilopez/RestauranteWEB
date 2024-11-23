using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestauranteWEB.Migrations
{
    /// <inheritdoc />
    public partial class Proveedores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proveedores_Proveedores_ProveedorId",
                table: "Proveedores");

            migrationBuilder.DropIndex(
                name: "IX_Proveedores_ProveedorId",
                table: "Proveedores");

            migrationBuilder.DropColumn(
                name: "ProveedorId",
                table: "Proveedores");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProveedorId",
                table: "Proveedores",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Proveedores_ProveedorId",
                table: "Proveedores",
                column: "ProveedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proveedores_Proveedores_ProveedorId",
                table: "Proveedores",
                column: "ProveedorId",
                principalTable: "Proveedores",
                principalColumn: "Id");
        }
    }
}
