using Fenacon.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(e => e.Id).IsRequired();

            builder.Property(e => e.Nome)
                .HasColumnName("NomeUsuario")
                .HasColumnType("varchar(40)")
                .IsRequired();

            builder.Property(e => e.Email)
                .HasColumnName("Email")
                .HasColumnType("varchar(40)")
                .IsRequired();

            builder.Property(e => e.Senha)
                .HasColumnName("Senha")
                .HasColumnType("varchar(40)")
                .IsRequired();

            builder.Property(e => e.ConfirmaSenha)
                .HasColumnName("ConfirmaSenha")
                .HasColumnType("varchar(40)")
                .IsRequired();
        }
    }
}
