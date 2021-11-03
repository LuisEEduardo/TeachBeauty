using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class PagamentoColaboradorPJ : PagamentoColaborador
    {
        public List<Agendamento> AgendamentosDia { get; private set; } = new List<Agendamento>();
        public PagamentoColaborador PagamentoColaborador { get; set; }
        public int PagamentoColaboradorID { get; set; }

        public void AddAgendamentoRealizadosPorDia(Agendamento agendamento)
        {
            if (agendamento.DataHoraInicio == DateTime.Now)
            {
                AgendamentosDia.Add(agendamento);
            }
        }

        public void RemoveAgendamentoPorDia(Agendamento agendamento)
        {
            if (agendamento.DataHoraInicio == DateTime.Now)
            {
                AgendamentosDia.Remove(agendamento);
            }
        }

        protected override void CalcPagamento()
        {
            decimal salarioDia = 0;
            foreach (Agendamento agendamento in AgendamentosDia)
            {
                salarioDia += agendamento.Servico.Preco; 
            }
            Colaborador.ContratoTrabalho.AlterarSalario(salarioDia);
        }
    }
}
