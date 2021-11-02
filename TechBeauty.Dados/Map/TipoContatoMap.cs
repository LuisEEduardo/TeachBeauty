using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                .HasColumnType("VARCHAR(30)");

            builder.HasMany<Contato>
                (c => c.Contatos)
                .WithOne(tp => tp.Tipo)
                .HasForeignKey(f => f.TipoContatoID);

        }
    }
}
