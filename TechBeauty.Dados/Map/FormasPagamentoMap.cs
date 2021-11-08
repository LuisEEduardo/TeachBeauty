using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class FormasPagamentoMap : IEntityTypeConfiguration<FormasPagamento>
    {
        public void Configure(EntityTypeBuilder<FormasPagamento> builder)
        {
            builder.ToTable("FormasPagamento");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("VARCHAR(30)")
                .IsRequired();

            builder.Property(x => x.Descricao)
                .HasColumnType("VARCHAR(80)")
                .IsRequired();

            builder.HasMany<PagamentoColaborador>
                (pc => pc.PagamentosColaborador)
                .WithOne(f => f.FormaPagamento)
                .HasForeignKey(f => f.FormasPagamentoID);

            builder.HasMany<PagamentoClienteFormasPagamento>
                (pcfp => pcfp.pagamentoClienteFormasPagamentos)
                .WithOne(f => f.FormasPagamento)
                .HasForeignKey(f => f.FormasPagamentoID);


            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
