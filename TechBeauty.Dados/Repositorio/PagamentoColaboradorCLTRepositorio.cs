using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    class PagamentoColaboradorCLTRepositorio
    {

        protected readonly Contexto contexto;

        public PagamentoColaboradorCLTRepositorio()
        {
            contexto = new Contexto();
        }
        public void Incluir(PagamentoColaboradorCLT pagamentoColaboradorCLT)
        {
            contexto.PagamentoColaboradorCLT.Add(pagamentoColaboradorCLT);
            contexto.SaveChanges();
        }
        public void Alterar(PagamentoColaboradorCLT pagamentoColaboradorCLT)
        {
            contexto.PagamentoColaboradorCLT.Update(pagamentoColaboradorCLT);
            contexto.SaveChanges();
        }
        public PagamentoColaboradorCLT SelecionarPorId(int id)
        {
            return contexto.PagamentoColaboradorCLT.FirstOrDefault(x => x.Id == id);
        }
        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.PagamentoColaboradorCLT.Remove(entity);
            contexto.SaveChanges();
        }
        public void Dispose()
        {
            contexto.Dispose();
        }

    }
}
