using Microsoft.EntityFrameworkCore.Migrations;

namespace TiendaBicicleta.Data.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegistroVenta",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdCliente = table.Column<int>(type: "int", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: true),
                    IdBicicleta = table.Column<int>(type: "int", nullable: false),
                    PrecioBicicleta = table.Column<double>(type: "float", nullable: false),
                    InventarioBicicletaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistroVenta", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistroVenta_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RegistroVenta_InventarioBicicletas_InventarioBicicletaId",
                        column: x => x.InventarioBicicletaId,
                        principalTable: "InventarioBicicletas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RegistroVenta_ClienteId",
                table: "RegistroVenta",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistroVenta_InventarioBicicletaId",
                table: "RegistroVenta",
                column: "InventarioBicicletaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegistroVenta");
        }
    }
}
