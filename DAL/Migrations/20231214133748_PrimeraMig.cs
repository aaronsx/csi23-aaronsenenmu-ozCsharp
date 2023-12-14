using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class PrimeraMig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "prestamos",
                columns: table => new
                {
                    idPrestamo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    fchPrestamo = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prestamos", x => x.idPrestamo);
                });

            migrationBuilder.CreateTable(
                name: "vajillas",
                columns: table => new
                {
                    idVajilla = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    codigoVajilla = table.Column<string>(type: "text", nullable: false),
                    nombreVajilla = table.Column<string>(type: "text", nullable: false),
                    descripcionVajilla = table.Column<string>(type: "text", nullable: false),
                    cantidadVajilla = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vajillas", x => x.idVajilla);
                });

            migrationBuilder.CreateTable(
                name: "rel_Vajillas_Prestamos",
                columns: table => new
                {
                    idRelVajillaPrestamo = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    idVajilla = table.Column<long>(type: "bigint", nullable: false),
                    idPrestamo = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rel_Vajillas_Prestamos", x => x.idRelVajillaPrestamo);
                    table.ForeignKey(
                        name: "FK_rel_Vajillas_Prestamos_prestamos_idPrestamo",
                        column: x => x.idPrestamo,
                        principalTable: "prestamos",
                        principalColumn: "idPrestamo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_rel_Vajillas_Prestamos_vajillas_idVajilla",
                        column: x => x.idVajilla,
                        principalTable: "vajillas",
                        principalColumn: "idVajilla",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_rel_Vajillas_Prestamos_idPrestamo",
                table: "rel_Vajillas_Prestamos",
                column: "idPrestamo");

            migrationBuilder.CreateIndex(
                name: "IX_rel_Vajillas_Prestamos_idVajilla",
                table: "rel_Vajillas_Prestamos",
                column: "idVajilla");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "rel_Vajillas_Prestamos");

            migrationBuilder.DropTable(
                name: "prestamos");

            migrationBuilder.DropTable(
                name: "vajillas");
        }
    }
}
