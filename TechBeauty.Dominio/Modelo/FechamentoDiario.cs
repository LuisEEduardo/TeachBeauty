using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class FechamentoDiario
    {
        public int Id { get; private set; }
        public List<PagamentoCliente> Pagamentos { get; private set; } = new List<PagamentoCliente>();
        public DateTime DataFechamento { get; private set; }
        public decimal ValorFechamento { get; private set; }
        public List<Servico> ServicosRealizados { get; set; }

        public void calcFechamentoDia()
        {
            foreach (PagamentoCliente pagamento in Pagamentos)
            {
                foreach (Agendamento agendamento in pagamento.Agendamentos)
                {
                    ValorFechamento += agendamento.OS.PrecoTotal;
                }
            }
        }

        public void PreencheServico()
        {
            foreach (PagamentoCliente pagamento in Pagamentos)
            {
                foreach (Agendamento agendamento in pagamento.Agendamentos)
                {
                    ServicosRealizados.Add(agendamento.Servico);
                }
            }
        }

        public void AddPagamento(PagamentoCliente pagamento)
        {
            Pagamentos.Add(pagamento);
        }

        public void RemovePagamento(PagamentoCliente pagamento)
        {
            Pagamentos.Remove(pagamento);
        }

    }
}
