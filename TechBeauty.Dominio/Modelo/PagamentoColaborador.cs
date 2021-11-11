using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Modelo.Enumeradores;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class PagamentoColaborador : IEntity
    {
        public int Id { get; private set; }
        public List<Colaborador> Colaboradores { get; private set; }
        public StatusPagamento StatusPagamento { get; private set; }
        public DateTime DataPagamento { get; private set; }
        public decimal Valor { get; set; }
        public Tipo Tipo { get; set; }
        public int CaixaID { get; set; }
        public Caixa Caixa { get; set; }

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
