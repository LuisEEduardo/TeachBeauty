using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    class CaixaRepositorio
    {
        protected readonly Contexto contexto;

        public CaixaRepositorio()
        {
            contexto = new Contexto();
        }
        public void Incluir(Caixa caixa)
        {
            contexto.Caixa.Add(caixa);
            contexto.SaveChanges();
        }
        public void Alterar(Caixa caixa)
        {
            contexto.Caixa.Update(caixa);
            contexto.SaveChanges();
        }
        public Caixa SelecionarPorId(int id)
        {
            return contexto.Caixa.FirstOrDefault(x => x.Id == id);
        }
        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.Caixa.Remove(entity);
            contexto.SaveChanges();
        }
        public void Dispose()
        {
            contexto.Dispose();
        }

    }
}
