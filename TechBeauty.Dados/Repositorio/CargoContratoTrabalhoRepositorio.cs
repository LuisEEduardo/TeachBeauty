using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class CargoContratoTrabalhoRepositorio : RepositorioBase<CargoContratoTrabalho>
    {
        public override CargoContratoTrabalho Selecionar(int id)
        {
            return contexto.CargoContratoTrabalho.FirstOrDefault(x => x.ID == id);
        }

    }
}
