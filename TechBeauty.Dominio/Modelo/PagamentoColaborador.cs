using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Modelo.Enumeradores;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class PagamentoColaborador : IEntity
    {
        public int Id { get; private set; }
        public StatusPagamento StatusPagamento { get; set; }
        public DateTime DataPagamento { get; set; }
        public decimal Valor { get; set; }
        public Tipo Tipo { get; set; }
        public int CaixaID { get; set; }
        public Caixa Caixa { get; set; }
        public List<Colaborador> Colaborador { get; set; }


        public static PagamentoColaborador Criar(StatusPagamento statusPagamento, 
            DateTime dataPagamento, decimal valor, Tipo tipo)
        {
            PagamentoColaborador pagamentoColaborador = new PagamentoColaborador();
            pagamentoColaborador.StatusPagamento = statusPagamento;
            pagamentoColaborador.DataPagamento = dataPagamento;
            pagamentoColaborador.Valor = valor;
            pagamentoColaborador.Tipo = tipo;

            return pagamentoColaborador;
        }

        public void CalcValorComicao(decimal valorBase,
            int porcentagemComissao)
        {
            Valor = valorBase * porcentagemComissao / 100;
            Tipo = Tipo.Comissao;
        }

        public void IncluirValorBase(decimal valor)
        {
            Valor = valor;
            Tipo = Tipo.Fixo;
        }

        protected void AlterarStatusPagamento(StatusPagamento statusAgendamento)
        {
            StatusPagamento = statusAgendamento;
        }

    }
}
