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

            builder.Property(x => x.Id)
                .UseIdentityColumn();

            builder.HasMany<Colaborador>
                (c => c.Colaboradores)
                .WithOne(pg => pg.PagamentoColaborador)
                .HasForeignKey(pg => pg.PagamentoColaboradorId);

        }
    }
}
