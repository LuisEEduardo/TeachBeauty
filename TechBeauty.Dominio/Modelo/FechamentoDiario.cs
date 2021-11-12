using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class FechamentoDiario : IEntity
    {
        public int Id { get; private set; }
        public List<PagamentoCliente> Pagamentos { get; private set; } = new List<PagamentoCliente>();
        public DateTime DataFechamento { get; private set; }
        public decimal ValorFechamento { get; private set; }
        public List<PagamentoClienteFechamentoDiario> PagamentoClienteFechamentoDiario { get; set; }
        public int CaixaID { get; set; }
        public Caixa Caixa { get; set; }

        public static FechamentoDiario Criar(DateTime dataFechamento, decimal valorFechamento)
        {
            FechamentoDiario fechamentoDiario = new FechamentoDiario();
            fechamentoDiario.DataFechamento = dataFechamento;
            fechamentoDiario.ValorFechamento = valorFechamento;

            return fechamentoDiario;
        }

        public void calcFechamentoDia()
        {
            foreach (PagamentoCliente pagamento in Pagamentos)
            {
                foreach (var os in pagamento.OS)
                {
                    ValorFechamento += os.PrecoTotal;
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

        public void MudarValorFechamento(decimal valorFechamento)
        {
            ValorFechamento = valorFechamento;
        }

    }
}
