using System;
using TechBeauty.Dominio.Modelo.Enumeradores;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class LogAgendamento : IEntity
    {
        public int Id { get; private set; }
        public int AgendamentoID { get; private set; }        
        public StatusAgendamento Status { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public Agendamento Agendamento { get; set; }
      

        public static LogAgendamento Criar(DateTime dataCriacao, StatusAgendamento status)
        {
            LogAgendamento logAgendamento = new LogAgendamento();
            logAgendamento.DataCriacao = dataCriacao;
            logAgendamento.Status = status;

            return logAgendamento;
        }

        public void AlterarStatus(StatusAgendamento status)
        {
            Status = status;
        }

    }
}