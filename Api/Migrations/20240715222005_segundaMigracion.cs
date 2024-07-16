using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Api.Migrations
{
    /// <inheritdoc />
    public partial class segundaMigracion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Poliza_Producto_SuProductoId",
                table: "Poliza");

            migrationBuilder.DropColumn(
                name: "IdProducto",
                table: "Poliza");

            migrationBuilder.RenameColumn(
                name: "SuProductoId",
                table: "Poliza",
                newName: "ProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_Poliza_SuProductoId",
                table: "Poliza",
                newName: "IX_Poliza_ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Poliza_Producto_ProductoId",
                table: "Poliza",
                column: "ProductoId",
                principalTable: "Producto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Poliza_Producto_ProductoId",
                table: "Poliza");

            migrationBuilder.RenameColumn(
                name: "ProductoId",
                table: "Poliza",
                newName: "SuProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_Poliza_ProductoId",
                table: "Poliza",
                newName: "IX_Poliza_SuProductoId");

            migrationBuilder.AddColumn<int>(
                name: "IdProducto",
                table: "Poliza",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Poliza_Producto_SuProductoId",
                table: "Poliza",
                column: "SuProductoId",
                principalTable: "Producto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
