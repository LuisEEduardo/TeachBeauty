using System;
using TechBeauty.Dominio.Modelo.Enumeradores;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public abstract class PagamentoColaborador : IEntity
    {
        public int Id { get; private set; }
        public Colaborador Colaborador { get; private set; }
        public int ColaboradorId { get; set; }
        public StatusPagamento StatusPagamento { get; private set; }
        public DateTime DataPagamento { get; private set; }
        public decimal Valor { get; set; }
        public Tipo Tipo { get; set; }

        public void CalcValorComicao(decimal valorBase, 
            decimal porcentagemComissao)
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
