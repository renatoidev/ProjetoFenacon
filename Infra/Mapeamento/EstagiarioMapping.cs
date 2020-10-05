using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace Infra.Mapeamento
{
    public class EstagiarioMapping : IEntityTypeConfiguration<Estagiario>
    {
        public void Configure(EntityTypeBuilder<Estagiario> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .IsRequired();

            builder.Property(e => e.Nome)
                .HasColumnName("NomeEstagiario")
                .HasColumnType("varchar(40)")
                .IsRequired();

            builder.Property(e => e.Cpf)
                .HasColumnName("CpfEstagiario")
                .HasColumnType("varchar(11)")
                .IsRequired();

            builder.Property(e => e.Endereco)
                .HasColumnName("EnderecoEstagiario")
                .HasColumnType("varchar(60)")
                .IsRequired();

            builder.Property(e => e.Cargo)
                .HasColumnName("CargoEstagiario")
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

            builder.Property(e => e.IdSupervisor)
                .HasColumnName("Supervisor");
        }
    }
}
