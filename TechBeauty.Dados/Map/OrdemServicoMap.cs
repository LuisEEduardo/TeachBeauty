using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class OrdemServicoMap : IEntityTypeConfiguration<OrdemServico>
    {
        public void Configure(EntityTypeBuilder<OrdemServico> builder)
        {
            builder.ToTable("OrdemServico");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.PrecoTotal)
                .HasColumnType("DECIMAL(6, 2)");

            builder.Property(x => x.DuracaoTotal)
                .HasColumnType("INT"); 
            
            builder.Property(x => x.Status)
                .HasColumnType("INT")
                .IsRequired();

            builder.HasMany<Agendamento>
                (a => a.Agendamentos)
                .WithOne(os => os.OS)
                .HasForeignKey(os => os.OrdemServicoID);

        }
    }
}
