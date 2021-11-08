using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class CargoMap : IEntityTypeConfiguration<Cargo>
    {
        public void Configure(EntityTypeBuilder<Cargo> builder)
        {
            builder.ToTable("Cargo");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("VARCHAR(100)")
                .IsRequired();

            builder.Property(x => x.Descricao)
                .HasColumnType("VARCHAR(150)")
                .IsRequired();

            builder.HasMany<CargoContratoTrabalho>
                (cct => cct.CargoContratoTrabalhos)
                .WithOne(c => c.Cargo)
                .HasForeignKey(c => c.CargoID);

            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
