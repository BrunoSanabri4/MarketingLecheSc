using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Marketing_Sc.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campania",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    FechaInicio = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    FechaFin = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Estado = table.Column<string>(type: "text", nullable: false),
                    GastoAntes = table.Column<decimal>(type: "numeric", nullable: false),
                    GastoDurante = table.Column<decimal>(type: "numeric", nullable: false),
                    GastoDespues = table.Column<decimal>(type: "numeric", nullable: false),
                    CantidadProductoSolicitado = table.Column<int>(type: "integer", nullable: false),
                    ProductoSolicitado = table.Column<string>(type: "text", nullable: false),
                    ViaticosAsignados = table.Column<decimal>(type: "numeric", nullable: false),
                    CajaChica = table.Column<decimal>(type: "numeric", nullable: false),
                    CombosPromocionales = table.Column<string>(type: "text", nullable: false),
                    CantidadVendedores = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campania", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Campania");
        }
    }
}
