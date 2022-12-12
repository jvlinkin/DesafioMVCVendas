using DesafioVendasClientes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioVendasClientes.Data.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
     
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produtos");
            builder.Property(p => p.Descricao)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(p => p.Vlr_Unitario)
                .HasColumnType("decimal(18,2)")
                .IsRequired();

                
        }
    }
}
