using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class Colaborador : Pessoa, IEntity
    {
        public Endereco Endereco { get; private set; }
        public Genero Genero { get; private set; }
        public string NomeSocial { get; private set; }
        public List<ContratoTrabalho> ContratoTrabalho { get; private set; }
        public int EnderecoID { get; set; }
        public int GeneroID { get; set; }
        public List<Escala> Escalas { get; set; }
        public int ContratoTrabalhoID { get; set; }
        public List<ServicoColaborador> ServicosColaborador { get; set; }
        public List<Agendamento> Agendamentos { get; set; }
        public Caixa Caixa { get; set; }
        public int CaixaId { get; set; }

        // Propriedades dos Sistema Financeiro ---------------
        public decimal Salario { get; private set; }
        public int PorcentagemComissao { get; set; }
        public int PagamentoColaboradorId { get; set; }
        public PagamentoColaborador PagamentoColaborador { get; set; }
        // ---------------------------------------------------


        public static Colaborador Criar(
            // List<ContratoTrabalho> contratoTrabalho,
            // List<Contato> contatos
            int enderecoId,
            int generoId,
            string nomeSocial,
            string nome,
            string cpf,
            DateTime dataNascimento
            )
        {
            Colaborador colaborador = new Colaborador();
            colaborador.EnderecoID = enderecoId;
            colaborador.GeneroID = generoId;
            colaborador.NomeSocial = nomeSocial;
            // colaborador.ContratoTrabalho = contratoTrabalho;
            colaborador.Nome = nome;
            colaborador.CPF = cpf;
            colaborador.DataNascimento = dataNascimento;
            // colaborador.Contatos = contatos;

            return colaborador;
        }

        public void AddServico(ServicoColaborador servico)
        {
            ServicosColaborador.Add(servico);
        }

        public void RemoveServico(ServicoColaborador servico)
        {
            ServicosColaborador.Remove(servico);
        }

        public void AlterarNomeSocial(string nomeSocial)
        {
            NomeSocial = nomeSocial;
        }
        public void AlterarSalario(decimal salario)
        {
            Salario = salario;
        }

    }
}
