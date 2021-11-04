using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class ServicoRepositorio
    {

        protected readonly Contexto contexto;

        public ServicoRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(Servico servico)
        {
            contexto.Servico.Add(servico);
            contexto.SaveChanges();
        }

        public void Alterar(Servico servico)
        {
            contexto.Servico.Update(servico);
            contexto.SaveChanges();
        }

        public Servico SelecionarPorId(int id)
        {
            return contexto.Servico.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.Servico.Remove(entity);
            contexto.SaveChanges();
        }
        public void Dispose()
        {
            contexto.Dispose();
        }

    }
}
