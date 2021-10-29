using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Caixa
    {

        public int Id { get; private set; }
        public List<FechamentoDiario> Fechamentos { get; private set; } = new List<FechamentoDiario>();
        public decimal ValorEmCaixa { get; private set; }
        public List<string> DescricaoAddValor { get; private set; }
        public List<string> DescricaoRetirarValor { get; private set; }

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
            DescricaoRetirarValor.Add($"Motivo: {motivo} | Valor: {valor}");
        }

        public void AddValor(string motivo, decimal valor)
        {
            ValorEmCaixa += valor;
            DescricaoAddValor.Add($"Motivo: {motivo} | Valor: {valor}"); 
        }

        public void buscaFechamento(FechamentoDiario fechamentoDiario)
        {
            // Fechamentos.Find(fechamentoDiario); 
        }

    }
}
