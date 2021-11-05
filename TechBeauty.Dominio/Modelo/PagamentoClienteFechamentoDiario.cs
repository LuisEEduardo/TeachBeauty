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
    }
}
