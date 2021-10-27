using System;

namespace TechBeauty.Dominio.Modelo
{
    public class Agendamento
    {

        public int Id { get; private set; }
        public Servico Servico { get; private set; }
        public Colaborador Colaborador { get; private set; }
        public Cliente Cliente { get; private set; }   // PessoaAtendia String -> alterei 
        public DateTime DataHora { get; private set; }
        public OrdemServico OS { get; private set; }
        public DateTime DataHoraCriacao { get; private set; }
        public DateTime DataHoraExecucao { get; private set; }

        public static Agendamento Criar(int id, Servico servico, Colaborador colaborador, 
            Cliente cliente, DateTime dataHora, OrdemServico os, DateTime dataHoraCriacao,
            DateTime dataHoraExecucao)
        {
            Agendamento agendamento = new Agendamento();
            agendamento.Id = id;
            agendamento.Servico = servico;
            agendamento.Colaborador = colaborador;
            agendamento.Cliente = cliente;
            agendamento.DataHora = dataHora;
            agendamento.OS = os;
            agendamento.DataHoraCriacao = dataHoraCriacao;
            agendamento.DataHoraExecucao = dataHoraExecucao;
            return agendamento; 
        }

        public void Alterar(Servico servico, Colaborador colaborador,
            Cliente cliente, DateTime dataHora, OrdemServico os, DateTime dataHoraCriacao,
            DateTime dataHoraExecucao)
        {
            Servico = servico;
            Colaborador = colaborador;
            Cliente = cliente;
            DataHora = dataHora;
            OS = os;
            DataHoraCriacao = dataHoraCriacao;
            DataHoraExecucao = dataHoraExecucao;
        }


    }
}
