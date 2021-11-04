using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class GeneroRepositorio
    {

        protected readonly Contexto contexto;

        public GeneroRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(Genero genero)
        {
            contexto.Genero.Add(genero);
            contexto.SaveChanges();
        }

        public void Alterar(Genero genero)
        {
            contexto.Genero.Update(genero);
            contexto.SaveChanges();
        }

        public Genero SelecionarPorId(int id)
        {
            return contexto.Genero.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.Genero.Remove(entity);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

    }
}
