﻿// <auto-generated />
using System;
using DesafioVendasClientes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DesafioVendasClientes.Migrations
{
    [DbContext(typeof(BancoContext))]
    partial class BancoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DesafioVendasClientes.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<decimal>("Vlr_Unitario")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProdutoID");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("DesafioVendasClientes.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data_Nascimento")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(35)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("UsuarioID");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("DesafioVendasClientes.Models.Venda", b =>
                {
                    b.Property<int>("VendaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DtHoraVenda")
                        .HasColumnType("datetime");

                    b.Property<int>("QtdProduto")
                        .HasColumnType("int");

                    b.Property<int?>("UsuarioID")
                        .HasColumnType("int");

                    b.Property<decimal>("VlrTotalVenda")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("VlrUnitarioProduto")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("VendaID");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("ProdutoVenda", b =>
                {
                    b.Property<int>("ProdutosProdutoID")
                        .HasColumnType("int");

                    b.Property<int>("VendasVendaID")
                        .HasColumnType("int");

                    b.HasKey("ProdutosProdutoID", "VendasVendaID");

                    b.HasIndex("VendasVendaID");

                    b.ToTable("ProdutoVenda");
                });

            modelBuilder.Entity("DesafioVendasClientes.Models.Venda", b =>
                {
                    b.HasOne("DesafioVendasClientes.Models.Usuario", "Usuario")
                        .WithMany("Vendas")
                        .HasForeignKey("UsuarioID");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ProdutoVenda", b =>
                {
                    b.HasOne("DesafioVendasClientes.Models.Produto", null)
                        .WithMany()
                        .HasForeignKey("ProdutosProdutoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DesafioVendasClientes.Models.Venda", null)
                        .WithMany()
                        .HasForeignKey("VendasVendaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DesafioVendasClientes.Models.Usuario", b =>
                {
                    b.Navigation("Vendas");
                });
#pragma warning restore 612, 618
        }
    }
}
