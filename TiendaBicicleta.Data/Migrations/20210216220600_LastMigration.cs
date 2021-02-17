using Microsoft.EntityFrameworkCore.Migrations;

namespace TiendaBicicleta.Data.Migrations
{
    public partial class LastMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegistroVenta_Clientes_ClienteId",
                table: "RegistroVenta");

            migrationBuilder.DropForeignKey(
                name: "FK_RegistroVenta_InventarioBicicletas_InventarioBicicletaId",
                table: "RegistroVenta");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RegistroVenta",
                table: "RegistroVenta");

            migrationBuilder.DropColumn(
                name: "IdBicicleta",
                table: "RegistroVenta");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "RegistroVenta");

            migrationBuilder.DropColumn(
                name: "PrecioBicicleta",
                table: "RegistroVenta");

            migrationBuilder.RenameTable(
                name: "RegistroVenta",
                newName: "RegistroVentas");

            migrationBuilder.RenameIndex(
                name: "IX_RegistroVenta_InventarioBicicletaId",
                table: "RegistroVentas",
                newName: "IX_RegistroVentas_InventarioBicicletaId");

            migrationBuilder.RenameIndex(
                name: "IX_RegistroVenta_ClienteId",
                table: "RegistroVentas",
                newName: "IX_RegistroVentas_ClienteId");

            migrationBuilder.AlterColumn<int>(
                name: "InventarioBicicletaId",
                table: "RegistroVentas",
                type: "int",
                maxLength: 230,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "RegistroVentas",
                type: "int",
                maxLength: 230,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegistroVentas",
                table: "RegistroVentas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RegistroVentas_Clientes_ClienteId",
                table: "RegistroVentas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RegistroVentas_InventarioBicicletas_InventarioBicicletaId",
                table: "RegistroVentas",
                column: "InventarioBicicletaId",
                principalTable: "InventarioBicicletas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RegistroVentas_Clientes_ClienteId",
                table: "RegistroVentas");

            migrationBuilder.DropForeignKey(
                name: "FK_RegistroVentas_InventarioBicicletas_InventarioBicicletaId",
                table: "RegistroVentas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_RegistroVentas",
                table: "RegistroVentas");

            migrationBuilder.RenameTable(
                name: "RegistroVentas",
                newName: "RegistroVenta");

            migrationBuilder.RenameIndex(
                name: "IX_RegistroVentas_InventarioBicicletaId",
                table: "RegistroVenta",
                newName: "IX_RegistroVenta_InventarioBicicletaId");

            migrationBuilder.RenameIndex(
                name: "IX_RegistroVentas_ClienteId",
                table: "RegistroVenta",
                newName: "IX_RegistroVenta_ClienteId");

            migrationBuilder.AlterColumn<int>(
                name: "InventarioBicicletaId",
                table: "RegistroVenta",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 230);

            migrationBuilder.AlterColumn<int>(
                name: "ClienteId",
                table: "RegistroVenta",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 230);

            migrationBuilder.AddColumn<int>(
                name: "IdBicicleta",
                table: "RegistroVenta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "RegistroVenta",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "PrecioBicicleta",
                table: "RegistroVenta",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_RegistroVenta",
                table: "RegistroVenta",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_RegistroVenta_Clientes_ClienteId",
                table: "RegistroVenta",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RegistroVenta_InventarioBicicletas_InventarioBicicletaId",
                table: "RegistroVenta",
                column: "InventarioBicicletaId",
                principalTable: "InventarioBicicletas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
