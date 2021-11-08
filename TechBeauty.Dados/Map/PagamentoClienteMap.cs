using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class PagamentoClienteMap : IEntityTypeConfiguration<PagamentoCliente>
    {
        public void Configure(EntityTypeBuilder<PagamentoCliente> builder)
        {
            builder.ToTable("PagamentoCliente");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.DiaPagamento)
                .HasColumnType("DATETIME")
                .IsRequired();

            builder.Property(x => x.Pagamento)
                .HasColumnType("DECIMAL(6, 2)")
                .IsRequired();

            builder.Property(x => x.StatusPagamento)
                .HasColumnType("INT")
                .IsRequired();

            builder.HasMany<PagamentoClienteFormasPagamento>
                (pcfp => pcfp.PagamentoClienteFormasPagamento)
                .WithOne(pc => pc.PagamentoCliente)
                .HasForeignKey(pc => pc.PagamentoClienteID);

            builder.HasMany<PagamentoClienteFechamentoDiario>
                (pcfd => pcfd.PagamentoClienteFechamentoDiario)
                .WithOne(pc => pc.PagamentoCliente)
                .HasForeignKey(pc => pc.PagamentoClienteID);

            builder.HasMany<Agendamento>
                (a => a.Agendamentos)
                .WithOne(pc => pc.PagamentoCliente)
                .HasForeignKey(pc => pc.PagamentoClienteID);

            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
