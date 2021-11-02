﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class ColaboradorMap : IEntityTypeConfiguration<Colaborador>
    {
        public void Configure(EntityTypeBuilder<Colaborador> builder)
        {

            builder.ToTable("Colaborador");

            builder.Property(x => x.NomeSocial)
                .HasColumnType("VARCHAR(100)");

            builder.HasMany<Escala>
                (e => e.Escalas)
                .WithOne(c => c.Colaborador)
                .HasForeignKey(c => c.ColaboradorID);

            builder.HasMany<Agendamento>
                (a => a.Agendamentos)
                .WithOne(c => c.Colaborador)
                .HasForeignKey(c => c.ColaboradorID);
        }
    }
}