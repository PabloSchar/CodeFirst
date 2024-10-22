using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Modelo2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Droguerias",
                columns: table => new
                {
                    DrogueriaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cuit = table.Column<long>(type: "bigint", nullable: false),
                    RazonSocial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Droguerias", x => x.DrogueriaId);
                });

            migrationBuilder.CreateTable(
                name: "Monodrogas",
                columns: table => new
                {
                    MonodrogaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monodrogas", x => x.MonodrogaId);
                });

            migrationBuilder.CreateTable(
                name: "Medicamentos",
                columns: table => new
                {
                    MedicamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreComercial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EsVentaLibre = table.Column<bool>(type: "bit", nullable: false),
                    PrecioVenta = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    StockMinimo = table.Column<int>(type: "int", nullable: false),
                    MonodrogaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicamentos", x => x.MedicamentoId);
                    table.ForeignKey(
                        name: "FK_Medicamentos_Monodrogas_MonodrogaId",
                        column: x => x.MonodrogaId,
                        principalTable: "Monodrogas",
                        principalColumn: "MonodrogaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DrogueriaMedicamento",
                columns: table => new
                {
                    DrogueriasDrogueriaId = table.Column<int>(type: "int", nullable: false),
                    MedicamentosMedicamentoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DrogueriaMedicamento", x => new { x.DrogueriasDrogueriaId, x.MedicamentosMedicamentoId });
                    table.ForeignKey(
                        name: "FK_DrogueriaMedicamento_Droguerias_DrogueriasDrogueriaId",
                        column: x => x.DrogueriasDrogueriaId,
                        principalTable: "Droguerias",
                        principalColumn: "DrogueriaId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DrogueriaMedicamento_Medicamentos_MedicamentosMedicamentoId",
                        column: x => x.MedicamentosMedicamentoId,
                        principalTable: "Medicamentos",
                        principalColumn: "MedicamentoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DrogueriaMedicamento_MedicamentosMedicamentoId",
                table: "DrogueriaMedicamento",
                column: "MedicamentosMedicamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicamentos_MonodrogaId",
                table: "Medicamentos",
                column: "MonodrogaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DrogueriaMedicamento");

            migrationBuilder.DropTable(
                name: "Droguerias");

            migrationBuilder.DropTable(
                name: "Medicamentos");

            migrationBuilder.DropTable(
                name: "Monodrogas");
        }
    }
}
