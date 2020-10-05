using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Mapeamento
{
    public class AnalistaMapping : IEntityTypeConfiguration<Analista>
    {
        public void Configure(EntityTypeBuilder<Analista> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .IsRequired();

            builder.Property(e => e.Nome)
                .HasColumnName("NomeAnalista")
                .HasColumnType("varchar(40)")
                .IsRequired();

            builder.Property(e => e.Cpf)
                .HasColumnName("CpfAnalista")
                .HasColumnType("varchar(11)")
                .IsRequired();

            builder.Property(e => e.Endereco)
                .HasColumnName("EnderecoAnalista")
                .HasColumnType("varchar(60)")
                .IsRequired();

            builder.Property(e => e.Cargo)
                .HasColumnName("CargoAnalista")
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

            builder.Property(e => e.Supervisor)
                .HasColumnName("Supervisor");

            builder.HasMany(e => e.Tecnicos)
                .WithOne(e => e.Analista)
                .HasForeignKey(e => e.IdSupervisor);

            builder.HasMany(e => e.Estagiarios)
                .WithOne(e => e.Analista)
                .HasForeignKey(e => e.IdSupervisor);
        }
    }
}
