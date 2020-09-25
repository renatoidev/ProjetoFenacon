using Fenacon.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Mappings
{
    public class FeriasMapping : IEntityTypeConfiguration<Ferias>
    {
        public void Configure(EntityTypeBuilder<Ferias> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(e => e.Id).IsRequired();

            builder.Property(e => e.DataInicio)
                 .HasColumnName("DataInicio")
                 .HasColumnType("dateTime")
                 .IsRequired();

            builder.Property(e => e.DataFim)
                 .HasColumnName("DataFim")
                 .HasColumnType("dateTime")
                 .IsRequired();

            builder.Property(e => e.PeriodoAquisitivo)
                 .HasColumnName("PeriodoAquisitivo")
                 .HasColumnType("dateTime")
                 .IsRequired();

            builder.HasMany(f => f.Funcionarios)
                .WithOne(f => f.Ferias)
                .HasForeignKey(f => f.IdFerias);



        }
    }
}
