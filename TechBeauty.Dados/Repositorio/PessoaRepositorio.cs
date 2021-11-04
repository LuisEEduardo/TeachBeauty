using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class PessoaRepositorio
    {

        protected readonly Contexto contexto;

        public PessoaRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(Pessoa pessoa)
        {
            contexto.Pessoa.Add(pessoa);
            contexto.SaveChanges();
        }

        public void Alterar(Pessoa pessoa)
        {
            contexto.Pessoa.Update(pessoa);
            contexto.SaveChanges();
        }

        public Pessoa SelecionarPorId(int id)
        {
            return contexto.Pessoa.FirstOrDefault(x => x.Id == id); 
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.Pessoa.Remove(entity);
            contexto.SaveChanges(); 
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

    }
}
