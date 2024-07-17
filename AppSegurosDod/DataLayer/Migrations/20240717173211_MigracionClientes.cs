using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class MigracionClientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Asegurados",
                columns: new[] { "Id", "DNI", "Estado", "FechaNacimiento", "Nombre", "PolizaId" },
                values: new object[,]
                {
                    { new Guid("2dba3b28-1f2f-4bdc-ab27-becd83313f53"), 165528, "ACTIVO", new DateTime(1964, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jimena", 1 },
                    { new Guid("32360d57-cbf0-47c8-bd0e-1726d6c505ac"), 35966, "INACTIVO", new DateTime(2019, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guada", 2 },
                    { new Guid("40dddef6-8a8f-4551-839b-b7658655a70d"), 39498, "ACTIVO", new DateTime(2000, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carlos", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Asegurados",
                keyColumn: "Id",
                keyValue: new Guid("2dba3b28-1f2f-4bdc-ab27-becd83313f53"));

            migrationBuilder.DeleteData(
                table: "Asegurados",
                keyColumn: "Id",
                keyValue: new Guid("32360d57-cbf0-47c8-bd0e-1726d6c505ac"));

            migrationBuilder.DeleteData(
                table: "Asegurados",
                keyColumn: "Id",
                keyValue: new Guid("40dddef6-8a8f-4551-839b-b7658655a70d"));
        }
    }
}
