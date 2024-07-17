using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TiposDeProductos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposDeProductos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Productos_TiposDeProductos_TipoId",
                        column: x => x.TipoId,
                        principalTable: "TiposDeProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Polizas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Polizas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Polizas_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Asegurados",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DNI = table.Column<int>(type: "int", maxLength: 9, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "datetime2", maxLength: 10, nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PolizaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asegurados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asegurados_Polizas_PolizaId",
                        column: x => x.PolizaId,
                        principalTable: "Polizas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TiposDeProductos",
                columns: new[] { "Id", "Tipo" },
                values: new object[,]
                {
                    { 1, "Tipo_1" },
                    { 2, "Tipo_2" },
                    { 3, "Tipo_3" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Name", "TipoId" },
                values: new object[,]
                {
                    { 1, "Producto_1", 1 },
                    { 2, "Producto_2", 2 },
                    { 3, "Prodcuto_3", 1 }
                });

            migrationBuilder.InsertData(
                table: "Polizas",
                columns: new[] { "Id", "Estado", "ProductoId" },
                values: new object[,]
                {
                    { 1, "ACTIVO", 2 },
                    { 2, "ACTIVO", 2 },
                    { 3, "INACTIVO", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asegurados_PolizaId",
                table: "Asegurados",
                column: "PolizaId");

            migrationBuilder.CreateIndex(
                name: "IX_Polizas_ProductoId",
                table: "Polizas",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_TipoId",
                table: "Productos",
                column: "TipoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asegurados");

            migrationBuilder.DropTable(
                name: "Polizas");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "TiposDeProductos");
        }
    }
}
