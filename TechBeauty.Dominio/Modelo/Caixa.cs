using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Caixa
    {

        public List<FechamentoDiario> Fechamentos { get; private set; } = new List<FechamentoDiario>();
        public decimal ValorEmCaixa { get; private set; }

        public void valorTotalEmCaixa()
        {
            foreach (FechamentoDiario fechamento in Fechamentos)
            {
                ValorEmCaixa += fechamento.ValorFechamento;
            }
        }

    }
}
