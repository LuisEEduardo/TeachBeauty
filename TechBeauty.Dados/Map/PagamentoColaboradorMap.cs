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

            builder.Property(x => x.ValorComissao)
                .HasColumnType("DECIMAL(6, 2)")
                .IsRequired();

            builder.HasMany<PagamentoColaboradorPJMap>
                (pj => pj.PagamentoColaboradorPJ)
                .WithOne(pc => pc.PagamentoColaborador)
                .HasForeignKey(pc => pc.PagamentoColaboradorID);

            builder.HasMany<PagamentoColaboradorCLT>
                (clt => clt.PagamentoColaboradorCLT)
                .WithOne(pc => pc.PagamentoColaborador)
                .HasForeignKey(pc => pc.PagamentoColaboradorID);
        }
    }
}
