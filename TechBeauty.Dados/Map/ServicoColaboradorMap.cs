using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class ServicoColaboradorMap : IEntityTypeConfiguration<ServicoColaborador>
    {
        public void Configure(EntityTypeBuilder<ServicoColaborador> builder)
        {
            builder.ToTable("ServicoColaborador");

            builder.HasKey(x => new { x.ServicoID, x.ColaboradorID });

            builder.HasOne(s => s.Servico)
                .WithMany(sc => sc.ServicosColaborador)
                .HasForeignKey(s => s.ServicoID);

            builder.HasOne(c => c.Colaborador)
                .WithMany(sc => sc.ServicosColaborador)
                .HasForeignKey(c => c.ColaboradorID);

        }
    }
}
