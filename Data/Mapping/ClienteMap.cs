using DesafioVendasClientes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioVendasClientes.Data.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.Property(p => p.NomeCliente)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(p => p.Cidade)
                .HasColumnType("varchar(50)")
                .IsRequired();

            
        }
    }
}
