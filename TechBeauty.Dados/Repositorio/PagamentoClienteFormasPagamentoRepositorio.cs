using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    class PagamentoClienteFormasPagamentoRepositorio
    {
        protected readonly Contexto contexto;

        public PagamentoClienteFormasPagamentoRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(PagamentoClienteFormasPagamento pagamentoClienteFormasPagamento)
        {
            contexto.PagamentoClienteFormasPagamento.Add(pagamentoClienteFormasPagamento);
            contexto.SaveChanges();
        }

        public void Alterar(PagamentoClienteFormasPagamento pagamentoClienteFormasPagamento)
        {
            contexto.PagamentoClienteFormasPagamento.Update(pagamentoClienteFormasPagamento);
            contexto.SaveChanges(); 
        }

        public PagamentoClienteFormasPagamento SelecionarPorId(int clienteId, int pagamentoId)
        {
            return contexto.PagamentoClienteFormasPagamento.FirstOrDefault(x => x.PagamentoClienteID == clienteId && x.FormasPagamentoID == pagamentoId); 
        }

        public void Excluir(int clienteId, int pagamentoId)
        {
            var entity = SelecionarPorId(clienteId, pagamentoId);
            contexto.PagamentoClienteFormasPagamento.Remove(entity);
            contexto.SaveChanges(); 
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
