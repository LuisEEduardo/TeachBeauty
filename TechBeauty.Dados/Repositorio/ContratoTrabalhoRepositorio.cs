using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class ContratoTrabalhoRepositorio
    {

        protected readonly Contexto contexto;

        public ContratoTrabalhoRepositorio() 
        {
            contexto = new Contexto(); 
        }

        public void Incluir(ContratoTrabalho contratoTrabalho)
        {
            contexto.ContratoTrabalho.Add(contratoTrabalho);
            contexto.SaveChanges();
        }

        public void Alterar(ContratoTrabalho contratoTrabalho)
        {
            contexto.ContratoTrabalho.Update(contratoTrabalho);
            contexto.SaveChanges(); 
        }

        public ContratoTrabalho SelecionarPorId(int id)
        {
            return contexto.ContratoTrabalho.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.ContratoTrabalho.Remove(entity);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }



    }
}
