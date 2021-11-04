using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class OrdemServicoRepositorio
    {

        public readonly Contexto contexto;

        public OrdemServicoRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(OrdemServico ordemServico)
        {
            contexto.OrdemServico.Add(ordemServico);
            contexto.SaveChanges();
        }

        public void Alterar(OrdemServico ordemServico)
        {

            contexto.OrdemServico.Update(ordemServico);
            contexto.SaveChanges();
        }

        public OrdemServico SelecionarPorId(int id)
        {
            return contexto.OrdemServico.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.OrdemServico.Remove(entity);
            contexto.SaveChanges();
        }
        public void Dispose()
        {
            contexto.Dispose();
        }
        
    }
}
