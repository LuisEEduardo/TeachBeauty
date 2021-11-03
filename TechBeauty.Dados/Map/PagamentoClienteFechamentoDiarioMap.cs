using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class PagamentoClienteFechamentoDiarioMap : IEntityTypeConfiguration<PagamentoClienteFechamentoDiario>
    {
        public void Configure(EntityTypeBuilder<PagamentoClienteFechamentoDiario> builder)
        {
            builder.ToTable("PagamentoClienteFechamentoDiario");

            builder.HasKey(x => new { x.FechamentoDiarioID, x.PagamentoClienteID });

            builder.HasOne(p => p.PagamentoCliente)
                .WithMany(pcfd => pcfd.PagamentoClienteFechamentoDiario)
                .HasForeignKey(pcfd => pcfd.PagamentoClienteID);

            builder.HasOne(p => p.FechamentoDiario)
                .WithMany(pcfd => pcfd.PagamentoClienteFechamentoDiario)
                .HasForeignKey(pcfd => pcfd.FechamentoDiarioID); 
        }
    }
}
