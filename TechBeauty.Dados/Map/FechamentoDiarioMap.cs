using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class FechamentoDiarioMap : IEntityTypeConfiguration<FechamentoDiario>
    {
        public void Configure(EntityTypeBuilder<FechamentoDiario> builder)
        {
            builder.ToTable("FechamentoDiario");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.DataFechamento)
                .HasColumnType("DATE")
                .IsRequired();

            builder.Property(x => x.ValorFechamento)
                .HasColumnType("DECIMAL(6, 2)")
                .IsRequired();

            builder.HasMany<PagamentoClienteFechamentoDiario>
                (p => p.PagamentoClienteFechamentoDiario)
                .WithOne(f => f.FechamentoDiario)
                .HasForeignKey(f => f.FechamentoDiarioID);

            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
