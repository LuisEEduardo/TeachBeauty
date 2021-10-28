using System;
using TechBeauty.Dominio.Modelo.Enumeradores;

namespace TechBeauty.Dominio.Modelo
{
    public abstract class PagamentoColaborador
    {
        public Colaborador Colaborador { get; private set; }
        public StatusPagamento StatusPagamento { get; private set; }
        public FormasPagamentoSalao FormaPagamentoSalao { get; private set; }
        public DateTime DataPagamento { get; private set; }
        public decimal ValorBonificacao { get; private set; }

        protected abstract void PagarSalario();

        protected void CalcValorBonificacao(decimal Salario)
        {
            ValorBonificacao = 100 / Colaborador.Contrato.Bonificacao * Salario; 
        }


    }
}
