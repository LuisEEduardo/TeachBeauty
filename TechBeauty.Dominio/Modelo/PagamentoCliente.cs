using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Modelo.Enumeradores;

namespace TechBeauty.Dominio.Modelo
{
    public class PagamentoCliente
    {
        public int Id { get; private set; }
        public List<Agendamento> Agendamentos { get; private set; }
        public DateTime DiaPagamento { get; private set; }
        public FormasPagamento FormasPagamento { get; private set;}
        public StatusPagamento StatusPagamento { get; private set; }
        public decimal Pagamento { get; private set; }

        public static PagamentoCliente Criar(int id, List<Agendamento> agendamentos, DateTime diaPagamento, 
            FormasPagamento formasPagamento, StatusPagamento statusAgendamento, decimal pagamento)
        {
            PagamentoCliente pagamentoCliente = new PagamentoCliente();
            pagamentoCliente.Id = id;
            pagamentoCliente.Agendamentos = agendamentos;
            pagamentoCliente.DiaPagamento = diaPagamento;
            pagamentoCliente.FormasPagamento = formasPagamento;
            pagamentoCliente.StatusPagamento = statusAgendamento;
            pagamentoCliente.Pagamento = pagamento;

            return pagamentoCliente; 
        }

        public void CalcValorPagamento()
        {
            foreach (Agendamento agendamento in Agendamentos)
            {
                Pagamento += agendamento.OS.PrecoTotal;
            }
        }

        public void AlterarStatusPagamento(StatusPagamento statusPagamento)
        {
            StatusPagamento = statusPagamento;
        }

        public void AddAgendamento(Agendamento agendamento)
        {
            Agendamentos.Add(agendamento);
        }

        public void RemoveAgendamento(Agendamento agendamento)
        {
            Agendamentos.Remove(agendamento);
        }

        public void AlterarFormaPagamento(FormasPagamento formasPagamento)
        {
            FormasPagamento = formasPagamento;
        }

    }
}
