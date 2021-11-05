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

        // Propriedades dos Sistema Financeiro ---------------
        public decimal Salario { get; private set; }
        // ---------------------------------------------------


        public static Colaborador Criar(
            Endereco endereco, 
            Genero genero, 
            string nomeSocial, 
            List<ContratoTrabalho> contratoTrabalho,
            int id, 
            string nome, 
            string cpf,
            DateTime dataNascimento,
            List<Contato> contatos)
        {
            Colaborador colaborador = new Colaborador();
            colaborador.Id = id;
            colaborador.Endereco = endereco;
            colaborador.Genero = genero;
            colaborador.NomeSocial = nomeSocial;
            colaborador.ContratoTrabalho = contratoTrabalho; 
            colaborador.Nome = nome;
            colaborador.CPF = cpf;
            colaborador.DataNascimento = dataNascimento;
            colaborador.Contatos = contatos; 

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
