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
    class ContratoTrabalhoMap : IEntityTypeConfiguration<ContratoTrabalho>
    {
        public void Configure(EntityTypeBuilder<ContratoTrabalho> builder)
        {
            builder.ToTable("ContratoTrabalho");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.DataEntrada)
                .HasColumnType("Date")
                .IsRequired();

            builder.Property(x => x.DataDesligamento)
                .HasColumnType("Date");

            builder.Property(x => x.CnpjCTPS)
                 .HasColumnType("VARCHAR(14)")
                 .IsRequired(); 
                

        }
    }
}
