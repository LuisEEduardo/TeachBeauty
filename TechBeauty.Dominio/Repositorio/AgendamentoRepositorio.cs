using System;
using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class AgendamentoRepositorio
    {

        public List<Agendamento> TabelaAgendamento { get; private set; } = new List<Agendamento>();

        public AgendamentoRepositorio(Servico servico, Colaborador colaborador, Cliente cliente, OrdemServico os)
        {
            PreencherDados(servico, colaborador, cliente, os);
        }

        public void Incluir(Agendamento agendamento)
        {
            TabelaAgendamento.Add(agendamento);
        }

        public void Alterar(int id, Servico servico, Colaborador colaborador,
            Cliente cliente, DateTime dataHora, OrdemServico os, DateTime dataHoraCriacao,
            DateTime dataHoraExecucao)
        {
            TabelaAgendamento.FirstOrDefault(x => x.Id == id).Alterar(servico, colaborador, cliente, dataHora, os, dataHoraCriacao, dataHoraExecucao);
        }

        public Agendamento SelecionarPorId(int id)
        {
            return TabelaAgendamento.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            TabelaAgendamento.Remove(SelecionarPorId(id));
        }

        private void PreencherDados(Servico servico, Colaborador colaborador, Cliente cliente, OrdemServico os)
        {
            TabelaAgendamento.Add(Agendamento.Criar(1, servico, colaborador, cliente, new DateTime(2021, 10, 17, 20, 10, 2), os, new DateTime(2021, 10, 17, 10, 2, 1), new DateTime(2021, 10, 17, 20, 12, 3)));
            TabelaAgendamento.Add(Agendamento.Criar(2, servico, colaborador, cliente, new DateTime(2021, 10, 13, 13, 10, 2), os, new DateTime(2021, 10, 17, 10, 2, 1), new DateTime(2021, 10, 17, 20, 12, 3)));
            TabelaAgendamento.Add(Agendamento.Criar(3, servico, colaborador, cliente, new DateTime(2021, 10, 17, 20, 10, 2), os, new DateTime(2021, 10, 17, 10, 2, 1), new DateTime(2021, 10, 17, 20, 12, 3)));
        }


    }
}
