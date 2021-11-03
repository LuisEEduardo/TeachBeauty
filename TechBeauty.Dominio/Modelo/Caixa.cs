using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Caixa
    {
        //public List<string> DescricaoAdicaoDeValor { get; private set; }
        //public List<string> DescricaoRetiradaDeValor { get; private set; }

        public int Id{ get; private set; }
        public List<FechamentoDiario> FechamentosDiario { get; private set; }
        public decimal ValorEmCaixa { get; private set; }
        public List<PagamentoColaborador> PagamentoColaborador { get; set; }

        public void CalcValorTotalFechamento()
        {
            foreach (FechamentoDiario fechamento in FechamentosDiario)
            {
                ValorEmCaixa += fechamento.ValorFechamento;
            }
        }

        public void RetirarValor(string motivo, decimal valor)
        {
            ValorEmCaixa -= valor;
            //DescricaoRetiradaDeValor.Add($"Motivo: {motivo} | Valor: {valor}");
        }

        public void AddValor(string motivo, decimal valor)
        {
            ValorEmCaixa += valor;
            //DescricaoAdicaoDeValor.Add($"Motivo: {motivo} | Valor: {valor}"); 
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
