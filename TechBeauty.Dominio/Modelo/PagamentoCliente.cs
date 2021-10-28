using System;

namespace TechBeauty.Dominio.Modelo
{
    public class PagamentoCliente
    {

        public int Id { get; private set; }
        public Agendamento Agendamento { get; private set; }
        public DateTime DiaPagamento { get; private set; }
        public FormasPagamentoCliente FormasPagamentoCliente { get; private set;}
        public StatusPagamento StatusPagamento { get; private set; }


        public static PagamentoCliente Criar(int id, Agendamento agendamento, DateTime diaPagamento, 
            FormasPagamentoCliente formasPagamentoCliente, StatusPagamento statusPagamento)
        {
            PagamentoCliente pagamentoCliente = new PagamentoCliente();
            pagamentoCliente.Id = id;
            pagamentoCliente.Agendamento = agendamento;
            pagamentoCliente.DiaPagamento = diaPagamento;
            pagamentoCliente.FormasPagamentoCliente = formasPagamentoCliente;
            pagamentoCliente.StatusPagamento = statusPagamento;

            return pagamentoCliente;
        }

        public void Alterar(Agendamento agendamento, DateTime diaPagamento,
            FormasPagamentoCliente formasPagamentoCliente, StatusPagamento statusPagamento)
        {
            Agendamento = agendamento;
            DiaPagamento = diaPagamento;
            FormasPagamentoCliente = formasPagamentoCliente;
            StatusPagamento = statusPagamento; 
        }

    }
}
