using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class PagamentoClienteFormasPagamento : IEntity
    {
        public int PagamentoClienteID { get; set; }
        public int FormasPagamentoID { get; set; }
        public FormasPagamento FormasPagamento { get; set; }
        public PagamentoCliente PagamentoCliente { get; set; }

        public int Id => throw new System.NotImplementedException();


        public static PagamentoClienteFormasPagamento Criar(int pagamentoClienteID,
            int formasPagamentoID)
        {
            PagamentoClienteFormasPagamento pagamentoClienteFormasPagamento = new PagamentoClienteFormasPagamento();
            pagamentoClienteFormasPagamento.PagamentoClienteID = pagamentoClienteID;
            pagamentoClienteFormasPagamento.FormasPagamentoID = formasPagamentoID;

            return pagamentoClienteFormasPagamento;
        }

    }
}
