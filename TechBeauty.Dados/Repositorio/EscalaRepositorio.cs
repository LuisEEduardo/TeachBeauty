using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class EscalaRepositorio
    {
        protected readonly Contexto contexto;

        public EscalaRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(Escala escala)
        {
            contexto.Escala.Add(escala);
            contexto.SaveChanges();
        }

        public void Alterar(Escala escala)
        {
            contexto.Escala.Update(escala);
            contexto.SaveChanges();

        }

        public Escala SelecionarPorId(int id)
        {
            return contexto.Escala.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.Escala.Remove(entity);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

    }
}
