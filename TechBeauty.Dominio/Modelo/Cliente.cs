using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class Cliente : Pessoa, IEntity
    {

        public List<OrdemServico> OrdensServico { get; set; }

        public static Cliente Criar(string nome, string cpf, DateTime dataNascimento) //, List<Contato> contatos
        {
            Cliente cliente = new Cliente();
            cliente.Nome = nome;
            cliente.CPF = cpf;
            cliente.DataNascimento = dataNascimento;
            // cliente.Contatos = contatos;
            return cliente;
        }

        //public static Cliente Criar(int id)
        //{
        //    Cliente cliente = new Cliente();
        //    cliente.Id = id;

        //    return cliente; 
        //}

    }
}