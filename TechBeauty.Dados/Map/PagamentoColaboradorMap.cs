using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class PagamentoColaboradorMap : IEntityTypeConfiguration<PagamentoColaborador>
    {
        public void Configure(EntityTypeBuilder<PagamentoColaborador> builder)
        {
            builder.ToTable("PagamentoColaborador");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.StatusPagamento)
                .HasColumnType("INT")
                .IsRequired();

            builder.Property(x => x.DataPagamento)
                .HasColumnType("DATETIME")
                .IsRequired();

            builder.Property(x => x.Tipo)
                .HasColumnType("INT")
                .IsRequired();

            builder.Property(x => x.Valor)
                .HasColumnType("DECIMAL")
                .IsRequired();

            builder.HasMany<Colaborador>
                (c => c.Colaborador)
                .WithOne(pg => pg.PagamentoColaborador)
                .HasForeignKey(pg => pg.PagamentoColaboradorId);

            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
