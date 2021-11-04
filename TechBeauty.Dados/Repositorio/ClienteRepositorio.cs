using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class ClienteRepositorio
    {

        protected readonly Contexto contexto; 

        public ClienteRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(Cliente cliente)
        {
            contexto.Cliente.Add(cliente);
            contexto.SaveChanges();
        }

        public void Alterar(Cliente cliente)
        {
            contexto.Cliente.Update(cliente);
            contexto.SaveChanges();
        }

        public Cliente SelecionarPorId(int id)
        {
            return contexto.Cliente.FirstOrDefault(x => x.Id == id); 
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.Cliente.Remove(entity);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

    }

}
