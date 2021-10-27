using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dominio.Modelo.Enumeradores;
using System.Linq;

namespace TechBeauty.Dominio.Repositorio
{
    public class LogAgendamentoRepositorio
    {

        public List<LogAgendamento> TabelaLogAgendamento { get; private set; } = new List<LogAgendamento>();

        public LogAgendamentoRepositorio(StatusAgendamento status)
        {
            PreencherDados(status);
        }

        public void Incluir(LogAgendamento logAgendamento)
        {
            TabelaLogAgendamento.Add(logAgendamento);
        }

        public void Alterar(int idAgendamento, StatusAgendamento status)
        {
            TabelaLogAgendamento.FirstOrDefault(x => x.IdAgendamento == idAgendamento).AlterarStatus(status);
        }

        public LogAgendamento SelecionarPorId(int idAgendamento)
        {
            return TabelaLogAgendamento.FirstOrDefault(x => x.IdAgendamento == idAgendamento);
        }

        public void Excluir(int idAgendamento)
        {
            TabelaLogAgendamento.Remove(SelecionarPorId(idAgendamento));
        }

        private void PreencherDados(StatusAgendamento status)
        {
            TabelaLogAgendamento.Add(LogAgendamento.Criar(new DateTime(2021, 10, 22), status, 2)); 
            TabelaLogAgendamento.Add(LogAgendamento.Criar(new DateTime(2021, 10, 20), status, 3)); 
            TabelaLogAgendamento.Add(LogAgendamento.Criar(new DateTime(2021, 10, 10), status, 1)); 
        }


    }
}
