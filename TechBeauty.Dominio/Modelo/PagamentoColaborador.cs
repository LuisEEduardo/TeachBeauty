using System;
using TechBeauty.Dominio.Modelo.Enumeradores;

namespace TechBeauty.Dominio.Modelo
{
    public abstract class PagamentoColaborador
    {
        public int Id { get; private set; }
        public Colaborador Colaborador { get; private set; }
        public StatusPagamento StatusPagamento { get; private set; }
        public FormasPagamento FormaPagamento{ get; private set; }
        public DateTime DataPagamento { get; private set; }
        public decimal ValorComissao { get; private set; }

        protected abstract void CalcPagamento();

        protected void CalcValorComicao(int porcentagem)
        {
            ValorComissao = Colaborador.Contrato.Salario * porcentagem;
        }

        protected void AlterarStatusPagamento(StatusPagamento statusAgendamento)
        {
            StatusPagamento = statusAgendamento;
        }

        protected void AlterarFormaPagamento(FormasPagamento formasPagamento)
        {
            FormaPagamento = formasPagamento; 
        }


    }
}
