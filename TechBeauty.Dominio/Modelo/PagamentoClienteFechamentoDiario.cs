namespace TechBeauty.Dominio.Modelo
{
    public class PagamentoClienteFechamentoDiario
    {
        public int PagamentoClienteID { get; set; }
        public int FechamentoDiarioID { get; set; }
        public PagamentoCliente PagamentoCliente { get; set; }
        public FechamentoDiario FechamentoDiario { get; set; }
    }
}
