using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Mapeamento
{
    public class TecnicoMapping : IEntityTypeConfiguration<Tecnico>
    {
        public void Configure(EntityTypeBuilder<Tecnico> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .IsRequired();

            builder.Property(e => e.Nome)
                .HasColumnName("NomeTecnico")
                .HasColumnType("varchar(40)")
                .IsRequired();

            builder.Property(e => e.Cpf)
                .HasColumnName("CpfTecnico")
                .HasColumnType("varchar(11)")
                .IsRequired();

            builder.Property(e => e.Endereco)
                .HasColumnName("EnderecoTecnico")
                .HasColumnType("varchar(60)")
                .IsRequired();

            builder.Property(e => e.Cargo)
                .HasColumnName("CargoTecnico")
                .HasColumnType("int")
                .IsRequired();


            builder.Property(e => e.CargaHoraria)
                 .HasColumnName("CargaHoraria")
                 .HasColumnType("time")
                 .IsRequired();

            builder.Property(e => e.DataAdmissao)
                 .HasColumnName("DataAdmissao")
                 .HasColumnType("dateTime")
                 .IsRequired();

            builder.Property(e => e.Situacao)
                .HasColumnName("Situacao")
                .HasColumnType("int")
                .IsRequired();
        }
    }
}