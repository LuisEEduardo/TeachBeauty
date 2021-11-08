using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class LogAgendamentoMap : IEntityTypeConfiguration<LogAgendamento>
    {
        public void Configure(EntityTypeBuilder<LogAgendamento> builder)
        {
            builder.ToTable("LogAgendamento");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.DataCriacao)
                .HasColumnType("SMALLDATETIME")
                .IsRequired();

            builder.Property(x => x.Status)
                .HasColumnType("INT")
                .IsRequired();

            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
