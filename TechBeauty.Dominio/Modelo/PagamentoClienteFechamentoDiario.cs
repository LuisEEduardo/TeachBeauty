using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class PagamentoClienteFechamentoDiario : IEntity
    {
        public int PagamentoClienteID { get; set; }
        public int FechamentoDiarioID { get; set; }
        public PagamentoCliente PagamentoCliente { get; set; }
        public FechamentoDiario FechamentoDiario { get; set; }

        public int Id => throw new System.NotImplementedException();


        public static PagamentoClienteFechamentoDiario Criar(int pagamentoClienteID,
            int fechamentoDiarioID)
        {
            PagamentoClienteFechamentoDiario pagamentoClienteFechamentoDiario = new PagamentoClienteFechamentoDiario();
            pagamentoClienteFechamentoDiario.PagamentoClienteID = pagamentoClienteID;
            pagamentoClienteFechamentoDiario.FechamentoDiarioID = fechamentoDiarioID;

            return pagamentoClienteFechamentoDiario;
        }


    }
}
