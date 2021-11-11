using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class Agendamento : IEntity
    {
        public int Id { get; private set; }
        public Servico Servico { get; private set; }
        public Colaborador Colaborador { get; private set; }
        public string PessoaAtendia { get; private set; }
        public OrdemServico OS { get; private set; }
        public DateTime DataHoraInicio { get; private set; }
        public DateTime DataHoraCriacao { get; private set; }
        public DateTime DataHoraTermino { get; private set; }
        public int ServicoID { get; set; }
        public int ColaboradorID { get; set; }
        public int OrdemServicoID { get; set; }
        public List<LogAgendamento> LogsAgendamento { get; set; }
        public int PagamentoClienteID { get; set; }
        public PagamentoCliente PagamentoCliente { get; set; }

        public static Agendamento Criar(int servicoID, int colaboradorID,
            string pessoaAtendia, DateTime dataHoraInicio, int ordemServicoID, DateTime dataHoraCriacao,
            DateTime dataHoraTermino)
        {
            Agendamento agendamento = new Agendamento();
            agendamento.ServicoID = servicoID;
            agendamento.ColaboradorID = colaboradorID;
            agendamento.PessoaAtendia = pessoaAtendia;
            agendamento.DataHoraInicio = dataHoraInicio;
            agendamento.OrdemServicoID = ordemServicoID;
            agendamento.DataHoraCriacao = dataHoraCriacao;
            agendamento.DataHoraTermino = dataHoraTermino;
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

        public void Remarcar(DateTime dataHoraInicio)
        {
            DataHoraInicio = dataHoraInicio;
        }

    }
}
