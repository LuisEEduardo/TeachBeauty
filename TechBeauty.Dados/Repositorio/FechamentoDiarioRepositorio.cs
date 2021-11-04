using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class FechamentoDiarioRepositorio
    {
        protected readonly Contexto contexto;

        public FechamentoDiarioRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(FechamentoDiario fechamentoDiario)
        {
            contexto.FechamentoDiario.Add(fechamentoDiario);
            contexto.SaveChanges();
        }

        public void Alterar(FechamentoDiario fechamentoDiario)
        {
            contexto.FechamentoDiario.Update(fechamentoDiario);
            contexto.SaveChanges(); 
        }

        public FechamentoDiario SelecionarPorId(int id)
        {
            return contexto.FechamentoDiario.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.FechamentoDiario.Remove(entity);
            contexto.SaveChanges(); 
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
