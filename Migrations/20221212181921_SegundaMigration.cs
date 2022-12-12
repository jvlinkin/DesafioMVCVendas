using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DesafioVendasClientes.Migrations
{
    public partial class SegundaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Clientes_ClienteID",
                table: "Vendas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.RenameColumn(
                name: "ClienteID",
                table: "Vendas",
                newName: "UsuarioID");

            migrationBuilder.RenameIndex(
                name: "IX_Vendas_ClienteID",
                table: "Vendas",
                newName: "IX_Vendas_UsuarioID");

            migrationBuilder.RenameColumn(
                name: "Desc_Produto",
                table: "Produtos",
                newName: "Descricao");

            migrationBuilder.AlterColumn<decimal>(
                name: "VlrUnitarioProduto",
                table: "Vendas",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Data_Nascimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    Email = table.Column<string>(type: "varchar(35)", nullable: false),
                    Senha = table.Column<string>(type: "varchar(50)", nullable: false),
                    Perfil = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Usuarios_UsuarioID",
                table: "Vendas",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "UsuarioID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendas_Usuarios_UsuarioID",
                table: "Vendas");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.RenameColumn(
                name: "UsuarioID",
                table: "Vendas",
                newName: "ClienteID");

            migrationBuilder.RenameIndex(
                name: "IX_Vendas_UsuarioID",
                table: "Vendas",
                newName: "IX_Vendas_ClienteID");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "Produtos",
                newName: "Desc_Produto");

            migrationBuilder.AlterColumn<int>(
                name: "VlrUnitarioProduto",
                table: "Vendas",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cidade = table.Column<string>(type: "varchar(50)", nullable: false),
                    NomeCliente = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Vendas_Clientes_ClienteID",
                table: "Vendas",
                column: "ClienteID",
                principalTable: "Clientes",
                principalColumn: "ClienteID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
