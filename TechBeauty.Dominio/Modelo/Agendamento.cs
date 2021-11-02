using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Agendamento
    {

        public int Id { get; private set; }
        public Servico Servico { get; private set; }
        public Colaborador Colaborador { get; private set; }
        public string PessoaAtendia { get; private set; }
        public DateTime DataHoraInicio { get; private set; }
        public OrdemServico OS { get; private set; }
        public DateTime DataHoraCriacao { get; private set; }
        public DateTime DataHoraTermino { get; private set; }
        public int ServicoID { get; set; }
        public int ColaboradorID { get; set; }
        public int OrdemServicoID { get; set; }
        public List<LogAgendamento> LogsAgendamento { get; set; }

        public static Agendamento Criar(int id, Servico servico, Colaborador colaborador,
            string pessoaAtendia, DateTime dataHora, OrdemServico os, DateTime dataHoraCriacao,
            DateTime dataHoraExecucao)
        {
            Agendamento agendamento = new Agendamento();
            agendamento.Id = id;
            agendamento.Servico = servico;
            agendamento.Colaborador = colaborador;
            agendamento.PessoaAtendia = pessoaAtendia;
            agendamento.DataHora = dataHora;
            agendamento.OS = os;
            agendamento.DataHoraCriacao = dataHoraCriacao;
            agendamento.DataHoraExecucao = dataHoraExecucao;
            return agendamento;
        }


        public void CancelarAgendamento()
        {
            OS.AlterarStatus(Enumeradores.StatusOS.Cancelado);
        }

        public void AlterarServico(Servico servico)
        {
            Servico = servico;
        }

        public void AlterarColaborador(Colaborador colaborador)
        {
            Colaborador = colaborador;
        }

        public void AlterarPessoaAtendida(string pessoaAtendida)
        {
            PessoaAtendia = pessoaAtendida;
        }

        public void Remarcar(DateTime dataHoraExecucao)
        {
            DataHoraExecucao = dataHoraExecucao;
        }

    }
}
