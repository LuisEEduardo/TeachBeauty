using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class PagamentoColaboradorPJMap : IEntityTypeConfiguration<PagamentoColaboradorPJ>
    {
        public void Configure(EntityTypeBuilder<PagamentoColaboradorPJ> builder)
        {
            builder.ToTable("PagamentoColaboradorPJ"); 
        }
    }
}
