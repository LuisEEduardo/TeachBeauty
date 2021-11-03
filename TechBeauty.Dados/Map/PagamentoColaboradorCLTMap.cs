using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class PagamentoColaboradorCLTMap : IEntityTypeConfiguration<PagamentoColaboradorCLT>
    {
        public void Configure(EntityTypeBuilder<PagamentoColaboradorCLT> builder)
        {
            builder.ToTable("PagamentoColaboradorCLT");
        }
    }
}
