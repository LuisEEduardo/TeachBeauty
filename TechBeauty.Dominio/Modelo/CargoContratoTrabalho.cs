using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class CargoContratoTrabalho : IEntity
    {
        public int ID { get; set; }

        public int Id => throw new System.NotImplementedException();

        public int CargoID { get; set; }
        public Cargo Cargo { get; set; }
        public int ContratoDeTrabalhoID { get; set; }
        public ContratoTrabalho ContratoTrabalho { get; set; }
    }
}
