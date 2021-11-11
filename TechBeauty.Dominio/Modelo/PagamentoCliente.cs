using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Modelo.Enumeradores;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class PagamentoCliente : IEntity
    {
        public int Id { get; private set; }
        public DateTime DiaPagamento { get; private set; }
        public FormasPagamento FormasPagamento { get; private set;}
        public StatusPagamento StatusPagamento { get; private set; }
        public decimal Pagamento { get; private set; }
        public Colaborador Colaborador { get; set; }
        public int ColaboradorId { get; set; }
        public List<PagamentoClienteFormasPagamento> PagamentoClienteFormasPagamento { get; set; }
        public List<PagamentoClienteFechamentoDiario> PagamentoClienteFechamentoDiario { get; set; }
        public List<OrdemServico> OS { get; set; }
        


        public static PagamentoCliente Criar(int id, List<OrdemServico> os, DateTime diaPagamento, 
            FormasPagamento formasPagamento, StatusPagamento statusAgendamento, decimal pagamento)
        {
            PagamentoCliente pagamentoCliente = new PagamentoCliente();
            pagamentoCliente.Id = id;
            pagamentoCliente.OS = os;
            pagamentoCliente.DiaPagamento = diaPagamento;
            pagamentoCliente.FormasPagamento = formasPagamento;
            pagamentoCliente.StatusPagamento = statusAgendamento;
            pagamentoCliente.Pagamento = pagamento;

            return pagamentoCliente; 
        }

        public void CalcValorPagamento()
        {
            foreach (OrdemServico ordemServico in OS)
            {
                Pagamento += ordemServico.PrecoTotal;
            }
        }

        public void AlterarStatusPagamento(StatusPagamento statusPagamento)
        {
            StatusPagamento = statusPagamento;
        }

        public void AlterarFormaPagamento(FormasPagamento formasPagamento)
        {
            FormasPagamento = formasPagamento;
        }

    }
}
