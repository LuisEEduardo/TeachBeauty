using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Colaborador : Pessoa 
    {
        public List<Servico> Servicos { get; private set; }
        public Endereco Endereco { get; private set; }
        public Genero Genero { get; private set; }
        public string NomeSocial { get; private set; }
        public ContratoTrabalho Contrato { get; private set; }

        public static Colaborador Criar(
            List<Servico> servicos, 
            Endereco endereco, 
            Genero genero, 
            string nomeSocial, 
            ContratoTrabalho contrato,
            string nome, 
            string cpf,
            DateTime dataNascimento,
            List<Contato> contatos)
        {
            Colaborador colaborador = new Colaborador();
            colaborador.Servicos = servicos;
            colaborador.Endereco = endereco;
            colaborador.Genero = genero;
            colaborador.NomeSocial = nomeSocial;
            colaborador.Contrato = contrato;
            colaborador.Nome = nome;
            colaborador.CPF = cpf;
            colaborador.DataNascimento = dataNascimento;
            colaborador.Contatos = contatos; 
            return colaborador; 
        }

        public void Alterar(List<Servico> servicos, Endereco endereco, Genero genero, string nomeSocial, ContratoTrabalho contrato)
        {
            Servicos = servicos;
            Endereco = endereco;
            Genero = genero;
            NomeSocial = nomeSocial;
            Contrato = contrato;
        }

    }
}
