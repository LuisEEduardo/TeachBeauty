using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.CEP)
                .HasColumnType("VARCHAR(8)")
                .IsRequired();

            builder.Property(x => x.Logradouro)
                .HasColumnType("VARCHAR(150)")
                .IsRequired();

            builder.Property(x => x.Numero)
                .HasColumnType("VARCHAR(15)")
                .IsRequired();

            builder.Property(x => x.Complemento)
                .HasColumnType("VARCHAR(100)");

            builder.Property(x => x.Bairro)
                .HasColumnType("VARCHAR(50)")
                .IsRequired();

            builder.Property(x => x.Cidade)
                .HasColumnType("VARCHAR(50)")
                .IsRequired();

            builder.Property(x => x.UF)
                .HasColumnType("CHAR(2)")
                .IsRequired();

            builder.HasMany<Colaborador>
                (c => c.Colaboradores)
                .WithOne(e => e.Endereco)
                .HasForeignKey(e => e.EnderecoID);

            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
