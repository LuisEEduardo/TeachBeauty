using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    class PagamentoClienteRepositorio
    {

        protected readonly Contexto contexto; 

        public PagamentoClienteRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(PagamentoCliente pagamentoCliente)
        {
            contexto.PagamentoCliente.Add(pagamentoCliente);
            contexto.SaveChanges();
        }

        public void Alterar(PagamentoCliente pagamentoCliente)
        {
            contexto.PagamentoCliente.Update(pagamentoCliente);
            contexto.SaveChanges();
        }

        public PagamentoCliente SelecionarPorId(int id)
        {
            return contexto.PagamentoCliente.FirstOrDefault(x => x.Id == id); 
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.PagamentoCliente.Remove(entity);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

    }
}
