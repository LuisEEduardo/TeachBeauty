using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class AgendamentoRepositorio
    {

        protected readonly Contexto contexto; 

        public AgendamentoRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(Agendamento agendamento)
        {
            contexto.Agendamento.Add(agendamento);
            contexto.SaveChanges(); 
        }

        public void Alterar(Agendamento agendamento)
        {
            contexto.Agendamento.Update(agendamento);
            contexto.SaveChanges();
        }

        public Agendamento SelecionarPorId(int id)
        {
            return contexto.Agendamento.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.Agendamento.Remove(entity);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose(); 
        }
        
    }
}
