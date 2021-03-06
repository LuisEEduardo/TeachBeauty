using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class EscalaMap : IEntityTypeConfiguration<Escala>
    {
        public void Configure(EntityTypeBuilder<Escala> builder)
        {

            builder.ToTable("Escala");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.DataHoraEntrada)
                .HasColumnType("DATE")
                .IsRequired();

            builder.Property(x => x.DataHoraSaida)
                .HasColumnType("DATE")
                .IsRequired();

            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
