using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class CargoContratoTrabalhoMap : IEntityTypeConfiguration<CargoContratoTrabalho>
    {
        public void Configure(EntityTypeBuilder<CargoContratoTrabalho> builder)
        {
            builder.ToTable("CargoContratoTrabalho");

            builder.HasKey(x => x.ID);

            builder.HasOne(c => c.Cargo)
                .WithMany(cct => cct.CargoContratoTrabalhos)
                .HasForeignKey(c => c.CargoID);

            builder.HasOne(ct => ct.ContratoTrabalho)
                .WithMany(cct => cct.CargosContratosTrabalho)
                .HasForeignKey(ct => ct.ContratoDeTrabalhoID);

            builder.Property(x => x.ID)
                .UseIdentityColumn();

        }
    }
}
