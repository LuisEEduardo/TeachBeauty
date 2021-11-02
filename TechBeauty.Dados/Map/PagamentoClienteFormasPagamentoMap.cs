using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class PagamentoClienteFormasPagamentoMap : IEntityTypeConfiguration<PagamentoClienteFormasPagamento>
    {
        public void Configure(EntityTypeBuilder<PagamentoClienteFormasPagamento> builder)
        {
            builder.ToTable("PagamentoClienteFormasPagamento");

            builder.HasKey(x => new { x.PagamentoClienteID, x.FormasPagamentoID });

            builder.HasOne(pc => pc.PagamentoCliente)
                .WithMany(pcfp => pcfp.PagamentoClienteFormasPagamento)
                .HasForeignKey(pcfp => pcfp.PagamentoClienteID);  // PagamentoClienteID

            builder.HasOne(f => f.FormasPagamento)
                .WithMany(pcfp => pcfp.pagamentoClienteFormasPagamentos)
                .HasForeignKey(pcfp => pcfp.FormasPagamentoID);
        }
    }
}
