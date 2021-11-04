using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class ServicoColaboradorRepositorio
    {

        protected readonly Contexto contexto;

        public ServicoColaboradorRepositorio()
        {
            contexto = new Contexto();
        }
        public void Incluir(ServicoColaborador servicoColaborador)
        {
            contexto.ServicoColaborador.Add(servicoColaborador);
            contexto.SaveChanges();
        }
        public void Alterar(ServicoColaborador servicoColaborador)
        {
            contexto.ServicoColaborador.Update(servicoColaborador);
            contexto.SaveChanges();
        }
        public ServicoColaborador SelecionarPorId(int colaboradorId, int servicoId)
        {
            return contexto.ServicoColaborador.FirstOrDefault(x => x.ColaboradorID == colaboradorId && x.ServicoID == servicoId);
        }
        public void Excluir(int colaboradorId, int servicoId)
        {
            var entity = SelecionarPorId(colaboradorId, servicoId);
            contexto.ServicoColaborador.Remove(entity);
            contexto.SaveChanges();
        }
        public void Dispose()
        {
            contexto.Dispose();
        }

    }
}
