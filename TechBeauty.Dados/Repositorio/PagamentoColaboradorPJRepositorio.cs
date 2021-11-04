using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    class PagamentoColaboradorPJRepositorio
    {

        protected readonly Contexto contexto;

        public PagamentoColaboradorPJRepositorio()
        {
            contexto = new Contexto(); 
        }

        public void Incluir(PagamentoColaboradorPJ pagamentoColaboradorPJ)
        {
            contexto.PagamentoColaboradorPJ.Add(pagamentoColaboradorPJ);
            contexto.SaveChanges();
        }

        public void Alterar(PagamentoColaboradorPJ pagamentoColaboradorPJ)
        {
            contexto.PagamentoColaboradorPJ.Update(pagamentoColaboradorPJ);
            contexto.SaveChanges(); 
        }

        public PagamentoColaboradorPJ SelecionarPorId(int id)
        {
            return contexto.PagamentoColaboradorPJ.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.PagamentoColaboradorPJ.Remove(entity);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

    }
}
