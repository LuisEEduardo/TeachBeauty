using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class CaixaMap : IEntityTypeConfiguration<Caixa>
    {
        public void Configure(EntityTypeBuilder<Caixa> builder)
        {
            builder.ToTable("Caixa");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.ValorEmCaixa)
                .HasColumnType("DECIMAL(6, 2)")
                .IsRequired();

            builder.HasMany<FechamentoDiario>
                (f => f.FechamentosDiario)
                .WithOne(c => c.Caixa)
                .HasForeignKey(c => c.CaixaID);

            builder.HasMany<PagamentoColaborador>
                (pc => pc.PagamentoColaborador)
                .WithOne(c => c.Caixa)
                .HasForeignKey(c => c.CaixaID);
            
            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
