using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Map
{
    class AgendamentoMap : IEntityTypeConfiguration<Agendamento>
    {
        public void Configure(EntityTypeBuilder<Agendamento> builder)
        {
            builder.ToTable("Agendamento");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.PessoaAtendia)
                .HasColumnType("VARCHAR(30)");

            builder.Property(x => x.DataHoraInicio)
                .HasColumnType("SMALLDATETIME");

            builder.Property(x => x.DataHoraTermino)
                .HasColumnType("SMALLDATETIME");

            builder.Property(x => x.DataHoraCriacao)
                .HasColumnType("SMALLDATETIME");

            builder.HasMany<LogAgendamento>
                (lg => lg.LogsAgendamento)
                .WithOne(a => a.Agendamento)
                .HasForeignKey(a => a.AgendamentoID);

        }
    }
}
