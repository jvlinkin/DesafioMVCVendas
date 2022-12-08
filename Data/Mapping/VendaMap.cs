using DesafioVendasClientes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioVendasClientes.Data.Mapping
{
    public class VendaMap : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.ToTable("Vendas");
            builder.Property(p => p.QtdProduto)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.VlrTotalVenda)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

            builder.Property(p=>p.VlrUnitarioProduto)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.DtHoraVenda)
                .HasColumnType("datetime");

            

                
        }
    }
}
