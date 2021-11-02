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
    class ContatoPessoaMap : IEntityTypeConfiguration<ContatoPessoa>
    {
        public void Configure(EntityTypeBuilder<ContatoPessoa> builder)
        {
            builder.ToTable("ContatoPessoa");

            builder.HasKey(x => new { x.PessoaID, x.ContatoID });

            builder.HasOne(p => p.Pessoa)
                .WithMany(cp => cp.ContatosPessoa)
                .HasForeignKey(cp => cp.PessoaID);

            builder.HasOne(c => c.Contato)
                .WithMany(cp => cp.ContatoPessoa)
                .HasForeignKey(cp => cp.ContatoID);

            builder.Property(x => x.ID)
                .UseIdentityColumn();
        }
    }
}
