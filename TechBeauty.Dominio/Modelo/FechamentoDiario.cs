using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class FechamentoDiario
    {

        public List<PagamentoCliente> Pagamentos { get; private set; } = new List<PagamentoCliente>();
        public DateTime DataFechamento { get; private set; }
        public decimal ValorFechamento { get; private set; }


        public void calcFechamentoDia()
        {
            foreach (PagamentoCliente pagamento in Pagamentos)
            {
                ValorFechamento += pagamento.Agendamento.OS.PrecoTotal;
            }
        }


    }
}
