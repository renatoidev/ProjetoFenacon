using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Mapeamento
{
    class SupervisorMapping : IEntityTypeConfiguration<Supervisor>
    {
        public void Configure(EntityTypeBuilder<Supervisor> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .IsRequired();

            builder.Property(e => e.Nome)
                .HasColumnName("NomeSupervisor")
                .HasColumnType("varchar(40)")
                .IsRequired();

            builder.Property(e => e.Cpf)
                .HasColumnName("CpfSupervisor")
                .HasColumnType("varchar(11)")
                .IsRequired();

            builder.Property(e => e.Endereco)
                .HasColumnName("EnderecoSupervisor")
                .HasColumnType("varchar(60)")
                .IsRequired();

            builder.Property(e => e.Cargo)
                .HasColumnName("CargoSupervisor")
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

            builder.HasMany(e => e.Funcionarios)
                .WithOne(e => e.Supervisor)
                .HasForeignKey(e => e.IdSupervisor);
        }
    }
}
