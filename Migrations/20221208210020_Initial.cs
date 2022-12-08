using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DesafioVendasClientes.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    ClienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCliente = table.Column<string>(type: "varchar(100)", nullable: false),
                    Cidade = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.ClienteID);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    ProdutoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Desc_Produto = table.Column<string>(type: "varchar(200)", nullable: false),
                    Vlr_Unitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ProdutoID);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    VendaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteID = table.Column<int>(type: "int", nullable: true),
                    QtdProduto = table.Column<int>(type: "int", nullable: false),
                    VlrUnitarioProduto = table.Column<int>(type: "int", nullable: false),
                    DtHoraVenda = table.Column<DateTime>(type: "datetime", nullable: false),
                    VlrTotalVenda = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.VendaID);
                    table.ForeignKey(
                        name: "FK_Vendas_Clientes_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Clientes",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ClienteProduto",
                columns: table => new
                {
                    ClientesClienteID = table.Column<int>(type: "int", nullable: false),
                    ProdutosProdutoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteProduto", x => new { x.ClientesClienteID, x.ProdutosProdutoID });
                    table.ForeignKey(
                        name: "FK_ClienteProduto_Clientes_ClientesClienteID",
                        column: x => x.ClientesClienteID,
                        principalTable: "Clientes",
                        principalColumn: "ClienteID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClienteProduto_Produtos_ProdutosProdutoID",
                        column: x => x.ProdutosProdutoID,
                        principalTable: "Produtos",
                        principalColumn: "ProdutoID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoVenda",
                columns: table => new
                {
                    ProdutoID = table.Column<int>(type: "int", nullable: false),
                    VendasVendaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoVenda", x => new { x.ProdutoID, x.VendasVendaID });
                    table.ForeignKey(
                        name: "FK_ProdutoVenda_Produtos_ProdutoID",
                        column: x => x.ProdutoID,
                        principalTable: "Produtos",
                        principalColumn: "ProdutoID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoVenda_Vendas_VendasVendaID",
                        column: x => x.VendasVendaID,
                        principalTable: "Vendas",
                        principalColumn: "VendaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClienteProduto_ProdutosProdutoID",
                table: "ClienteProduto",
                column: "ProdutosProdutoID");

            migrationBuilder.CreateIndex(
                name: "IX_ProdutoVenda_VendasVendaID",
                table: "ProdutoVenda",
                column: "VendasVendaID");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_ClienteID",
                table: "Vendas",
                column: "ClienteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClienteProduto");

            migrationBuilder.DropTable(
                name: "ProdutoVenda");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Vendas");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
