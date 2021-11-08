using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class TipoContatoMap : IEntityTypeConfiguration<TipoContato>
    {
        public void Configure(EntityTypeBuilder<TipoContato> builder)
        {
            builder.ToTable("TipoContato");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Valor)
                .HasColumnType("VARCHAR(30)")
                .IsRequired();

            builder.HasMany<Contato>
                (c => c.Contatos)
                .WithOne(tp => tp.Tipo)
                .HasForeignKey(f => f.TipoContatoID);


            builder.Property(x => x.Id)
                .UseIdentityColumn();
        }
    }
}
