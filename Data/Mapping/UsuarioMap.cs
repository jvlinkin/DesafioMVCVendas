using DesafioVendasClientes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioVendasClientes.Data.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuarios");
            builder.Property(p => p.Nome)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(p => p.Data_Nascimento)
                .HasColumnType("datetime")
                .IsRequired();
            builder.Property(p => p.Email)
                .HasColumnType("varchar(35)")
                .IsRequired();
            builder.Property(p => p.Senha)
                .HasColumnType("varchar(50)")
                .IsRequired();
            builder.Property(p => p.Perfil)
                .HasColumnType("int")
                .IsRequired();

            
        }

        
    }
}
