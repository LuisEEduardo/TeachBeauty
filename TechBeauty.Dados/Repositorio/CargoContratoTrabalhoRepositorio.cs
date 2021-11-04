using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class CargoContratoTrabalhoRepositorio
    {
        protected readonly Contexto contexto;

        public CargoContratoTrabalhoRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(CargoContratoTrabalho cargoContratoTrabalho)
        {
            contexto.CargoContratoTrabalho.Add(cargoContratoTrabalho);
            contexto.SaveChanges();
        }

        public void Alterar(CargoContratoTrabalho cargoContratoTrabalho)
        {
            contexto.CargoContratoTrabalho.Update(cargoContratoTrabalho);
            contexto.SaveChanges();
        }

        public CargoContratoTrabalho SelecionarPorId(int cargoID, int contratoDeTrabalhoID)
        {
            return contexto.CargoContratoTrabalho.FirstOrDefault(x => x.CargoID == cargoID && x.ContratoDeTrabalhoID == contratoDeTrabalhoID);             
        }

        public void Excluir(int cargoID, int contratoDeTrabalhoID)
        {
            var entity = SelecionarPorId(cargoID, contratoDeTrabalhoID);
            contexto.CargoContratoTrabalho.Remove(entity);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

    }
}
