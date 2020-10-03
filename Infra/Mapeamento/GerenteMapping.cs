﻿using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Mapeamento
{
    public class GerenteMapping : IEntityTypeConfiguration<Gerente>
    {
        public void Configure(EntityTypeBuilder<Gerente> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id)
                .IsRequired();

            builder.Property(e => e.Nome)
                .HasColumnName("NomeGerente")
                .HasColumnType("varchar(40)")
                .IsRequired();

            builder.Property(e => e.Cpf)
                .HasColumnName("CpfGerente")
                .HasColumnType("varchar(11)")
                .IsRequired();

            builder.Property(e => e.Endereco)
                .HasColumnName("EnderecoGerente")
                .HasColumnType("varchar(60)")
                .IsRequired();

            builder.Property(e => e.Cargo)
                .HasColumnName("CargoGerente")
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

            builder.HasMany(e => e.Analistas);
        }
    }
}