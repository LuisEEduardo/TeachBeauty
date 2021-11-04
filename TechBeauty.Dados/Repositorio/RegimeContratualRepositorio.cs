using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class RegimeContratualRepositorio
    {

        protected readonly Contexto contexto;

        public RegimeContratualRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(RegimeContratual regimeContratual)
        {
            contexto.RegimeContratual.Add(regimeContratual);
            contexto.SaveChanges();
        }

        public void Alterar(RegimeContratual regimeContratual)
        {
            contexto.RegimeContratual.Update(regimeContratual);
            contexto.SaveChanges();
        }

        public RegimeContratual SelecionarCargoPorId(int id)
        {
            return contexto.RegimeContratual.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarCargoPorId(id);
            contexto.RegimeContratual.Remove(entity);
            contexto.SaveChanges();
        }
        public void Dispose()
        {
            contexto.Dispose();
        }

    }
}
