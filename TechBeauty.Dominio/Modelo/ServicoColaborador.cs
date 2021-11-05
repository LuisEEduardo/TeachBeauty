using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class ServicoColaborador : IEntity
    {
        public int ColaboradorID { get; set; }
        public int ServicoID { get; set; }
        public Servico Servico { get; set; }
        public Colaborador Colaborador { get; set; }

        public int Id => throw new System.NotImplementedException();
    }
}
