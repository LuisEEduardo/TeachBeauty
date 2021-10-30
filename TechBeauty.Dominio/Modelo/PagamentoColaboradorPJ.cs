using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    class PagamentoColaboradorPJ : PagamentoColaborador
    {

        public List<Agendamento> AgendamentosDia { get; private set; } = new List<Agendamento>(); 


        public void AddAgendamentoRealizadosPorDia(Agendamento agendamento)
        {
            if (agendamento.DataHoraExecucao == DateTime.Now)
            {
                AgendamentosDia.Add(agendamento);
            }
        }

        public void RemoveAgendamentoPorDia(Agendamento agendamento)
        {
            if (agendamento.DataHoraExecucao == DateTime.Now)
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
            Colaborador.Contrato.AlterarSalario(salarioDia);
        }
    }
}
