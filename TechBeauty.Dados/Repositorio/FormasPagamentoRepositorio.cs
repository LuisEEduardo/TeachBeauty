using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class FormasPagamentoRepositorio
    {

        protected readonly Contexto contexto;

        public FormasPagamentoRepositorio()
        {
            contexto = new Contexto();
        }
        public void Incluir(FormasPagamento formasPagamento)
        {
            contexto.FormasPagamento.Add(formasPagamento);
            contexto.SaveChanges();
        }
        public void Alterar(FormasPagamento formasPagamento)
        {
            contexto.FormasPagamento.Update(formasPagamento);
            contexto.SaveChanges();
        }
        public FormasPagamento SelecionarPorId(int id)
        {
            return contexto.FormasPagamento.FirstOrDefault(x => x.Id == id);
        }
        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.FormasPagamento.Remove(entity);
            contexto.SaveChanges();
        }
        public void Dispose()
        {
            contexto.Dispose();
        }

    }
}
