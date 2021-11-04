using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    class PagamentoClienteFechamentoDiarioRepositorio
    {

        protected readonly Contexto contexto;

        public PagamentoClienteFechamentoDiarioRepositorio()
        {
            contexto = new Contexto();
        }
        public void Incluir(PagamentoClienteFechamentoDiario pagamentoClienteFechamentoDiario)
        {
            contexto.PagamentoClienteFechamentoDiario.Add(pagamentoClienteFechamentoDiario);
            contexto.SaveChanges();
        }
        public void Alterar(PagamentoClienteFechamentoDiario pagamentoClienteFechamentoDiario)
        {
            contexto.PagamentoClienteFechamentoDiario.Update(pagamentoClienteFechamentoDiario);
            contexto.SaveChanges();
        }
        public PagamentoClienteFechamentoDiario SelecionarPorId(int ClienteId, int fechamentoId)
        {
            return contexto.PagamentoClienteFechamentoDiario.FirstOrDefault(x => x.PagamentoClienteID == ClienteId && x.FechamentoDiarioID == fechamentoId);
        }
        public void Excluir(int ClienteId, int fechamentoId)
        {
            var entity = SelecionarPorId(ClienteId, fechamentoId);
            contexto.PagamentoClienteFechamentoDiario.Remove(entity);
            contexto.SaveChanges();
        }
        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}
