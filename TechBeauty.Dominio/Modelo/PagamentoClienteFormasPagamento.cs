namespace TechBeauty.Dominio.Modelo
{
    public class PagamentoClienteFormasPagamento
    {
        public int PagamentoClienteID { get; set; }
        public int FormasPagamentoID { get; set; }
        public FormasPagamento FormasPagamento { get; set; }
        public PagamentoCliente PagamentoCliente { get; set; }


    }
}
