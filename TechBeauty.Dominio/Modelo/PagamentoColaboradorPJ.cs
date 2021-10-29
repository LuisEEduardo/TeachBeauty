﻿using System;
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
            throw new NotImplementedException();
        }
    }
}