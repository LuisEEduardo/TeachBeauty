using System;
using TechBeauty.Dominio.Modelo.Enumeradores;

namespace TechBeauty.Dominio.Modelo
{
    public class LogAgendamento
    {
        public DateTime DataCriacao { get; private set; }
        public StatusAgendamento Status { get; private set; }
        public int IdAgendamento { get; private set; }

        public static LogAgendamento Criar(DateTime dataCriacao, StatusAgendamento status, int idAgendamento)
        {
            LogAgendamento logAgendamento = new LogAgendamento();
            logAgendamento.DataCriacao = dataCriacao;
            logAgendamento.Status = status;
            logAgendamento.IdAgendamento = idAgendamento;

            return logAgendamento;
        }


        public void AlterarStatus(StatusAgendamento status)
        {
            Status = status; 
        }


    }
}