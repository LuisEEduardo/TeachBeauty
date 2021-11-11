using System.Collections.Generic;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class Caixa : IEntity
    {
        public int Id{ get; private set; }
        public decimal ValorEmCaixa { get; private set; }
        public string Descricao { get; set; }
        public decimal ValorMovimentado { get; set; }
        public List<Colaborador> Colaborador { get; set; }
        public List<FechamentoDiario> FechamentosDiario { get; private set; }
        public List<PagamentoColaborador> PagamentoColaborador { get; set; }

        public void CalcValorTotalFechamento()
        {
            foreach (FechamentoDiario fechamento in FechamentosDiario)
            {
                ValorEmCaixa += fechamento.ValorFechamento;
            }
        }

        public void RetirarValor(decimal valor)
        {
            ValorEmCaixa -= valor;
        }

        public void AddValor(decimal valor)
        {
            ValorEmCaixa += valor;
        }

        public FechamentoDiario buscaFechamento(FechamentoDiario fechamentoDiario)
        {
            foreach (FechamentoDiario fechamento in FechamentosDiario)
            {
                if (fechamento == fechamentoDiario)
                {
                    return fechamento; 
                }
            }
            return null; 
        }

    }
}
