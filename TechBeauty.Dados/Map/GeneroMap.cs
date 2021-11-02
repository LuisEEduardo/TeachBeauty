using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class GeneroMap : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder.ToTable("Genero");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Valor)
                .HasColumnType("VARCHAR(30)")
                .IsRequired();

            builder.HasMany<Colaborador>
                (c => c.Colaboradores)
                .WithOne(g => g.Genero)
                .HasForeignKey(g => g.GeneroID);                 

        }
    }
}
