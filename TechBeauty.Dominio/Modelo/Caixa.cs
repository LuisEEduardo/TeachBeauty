using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Caixa
    {

        public int Id { get; private set; }
        public List<FechamentoDiario> Fechamentos { get; private set; } = new List<FechamentoDiario>();
        public decimal ValorEmCaixa { get; private set; }
        //public List<string> DescricaoAdicaoDeValor { get; private set; }
        //public List<string> DescricaoRetiradaDeValor { get; private set; }
        public List<FechamentoDiario> FechamentoDiario { get; set; }
        public List<PagamentoColaborador> PagamentoColaborador { get; set; }

        public void CalcValorTotalFechamento()
        {
            foreach (FechamentoDiario fechamento in Fechamentos)
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
            foreach (FechamentoDiario fechamento in Fechamentos)
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
