using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class ServicoMap : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            builder.ToTable("Servico");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("VARCHAR(50)")
                .IsRequired();

            builder.Property(x => x.Preco)
                .HasColumnType("DECIMAL(6, 2)")
                .IsRequired();

            builder.Property(x => x.Descricao)
                .HasColumnType("VARCHAR(150)")
                .IsRequired();

            builder.Property(x => x.DuracaoEmMin)
                .HasColumnType("INT")
                .IsRequired();

            builder.HasMany<Agendamento>
                (a => a.Agendamentos)
                .WithOne(s => s.Servico)
                .HasForeignKey(s => s.ServicoID);

            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
