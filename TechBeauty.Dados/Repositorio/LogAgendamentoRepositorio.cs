using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dominio.Modelo.Enumeradores;
using System.Linq;

namespace TechBeauty.Dados.Repositorio
{
    public class LogAgendamentoRepositorio
    {

        protected readonly Contexto contexto;

        public LogAgendamentoRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(LogAgendamento logAgendamento)
        {
            contexto.LogAgendamentos.Add(logAgendamento);
            contexto.SaveChanges();
        }

        public void Alterar(LogAgendamento logAgendamento)
        {
            contexto.LogAgendamentos.Update(logAgendamento);
            contexto.SaveChanges();
        }

        public LogAgendamento SelecionarPorId(int id)
        {
            return contexto.LogAgendamentos.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = (SelecionarPorId(id);
            contexto.LogAgendamentos.Remove(entity);
            contexto.SaveChanges();

        }
        public void Dispose()
        {
            contexto.Dispose();
        }

    }
}
