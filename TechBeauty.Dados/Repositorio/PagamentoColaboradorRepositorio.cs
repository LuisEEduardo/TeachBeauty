using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    class PagamentoColaboradorRepositorio
    {

        protected readonly Contexto contexto;

        public PagamentoColaboradorRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(PagamentoColaborador pagamentoColaborador)
        {
            contexto.PagamentoColaborador.Add(pagamentoColaborador);
            contexto.SaveChanges();
        }
        public void Alterar(PagamentoColaborador pagamentoColaborador)
        {
            contexto.PagamentoColaborador.Update(pagamentoColaborador);
            contexto.SaveChanges();
        }
        public PagamentoColaborador SelectionPorId(int id)
        {
            return contexto.PagamentoColaborador.FirstOrDefault(x => x.Id == id);
        }
        public void Excluir(int id)
        {
            var entity = SelectionPorId(id);
            contexto.PagamentoColaborador.Remove(entity);
            contexto.SaveChanges();
        }
        public void Dispose()
        {
            contexto.Dispose();
        }

    }
}
