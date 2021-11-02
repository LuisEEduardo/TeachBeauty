using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");

            builder.HasMany<OrdemServico>
                (os => os.OrdensServico)
                .WithOne(c => c.Cliente)
                .HasForeignKey(c => c.ClienteID); 
        }
    }
}
