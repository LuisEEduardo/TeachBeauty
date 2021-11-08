using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class RegimeContratualMap : IEntityTypeConfiguration<RegimeContratual>
    {
        public void Configure(EntityTypeBuilder<RegimeContratual> builder)
        {
            // Nome da tabela 
            builder.ToTable("RegimeContratual");

            // indica pro entity framework core qual a
            // propriedade é equivalente a PK
            builder.HasKey(x => x.Id);  // define a pk 

            // A patir daqui. Comceça as Configurações das colunas
            builder.Property(x => x.Valor)
                .HasColumnType("VARCHAR(20)")
                .IsRequired();  // Restrição de nulidade

            builder.HasMany<ContratoTrabalho>
                (r => r.ContratosDeTrabalho)
                .WithOne(c => c.RegimeContratual)
                .HasForeignKey(c => c.RegimeContratualID);

            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
