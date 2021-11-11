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
        public int FormasPagamentoId { get; set; }
        public StatusPagamento StatusPagamento { get; private set; }
        public decimal Pagamento { get; private set; }
        public Colaborador Colaborador { get; set; }
        public int ColaboradorId { get; set; }
        public List<PagamentoClienteFormasPagamento> PagamentoClienteFormasPagamento { get; set; }
        public List<PagamentoClienteFechamentoDiario> PagamentoClienteFechamentoDiario { get; set; }
        public List<OrdemServico> OS { get; set; }
        


        public static PagamentoCliente Criar(DateTime diaPagamento, int formasPagamentoId,
            StatusPagamento statusAgendamento, decimal pagamento, int colaboradorId)
        {
            PagamentoCliente pagamentoCliente = new PagamentoCliente();
            pagamentoCliente.DiaPagamento = diaPagamento;
            pagamentoCliente.FormasPagamentoId = formasPagamentoId;
            pagamentoCliente.ColaboradorId = colaboradorId;
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
