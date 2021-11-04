using System;
using System.Collections.Generic;
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
        public int FormasPagamentoID { get; set; }
        public int CaixaID { get; set; }
        public Caixa Caixa { get; set; }
        public List<PagamentoColaboradorPJ> PagamentoColaboradorPJ { get; set; }
        public List<PagamentoColaboradorCLT> PagamentoColaboradorCLT { get; set; }


        protected abstract void CalcPagamento();

        protected void CalcValorComicao(int porcentagem)
        {            
             ValorComissao = Colaborador.Salario * (porcentagem / 100);
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
