using System;
using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class ClienteRepositorio
    {

        public List<Cliente> TabelaCliente { get; private set; } = new List<Cliente>();

        public ClienteRepositorio(List<Contato> contatos)
        {
            PreencherDados(contatos);
        }

        public void Incluir(Cliente cliente)
        {
            TabelaCliente.Add(cliente);
        }

        public void Alterar(int id, string nome, string cpf, DateTime dataNascimento, List<Contato> contatos)
        {
            TabelaCliente.FirstOrDefault(x => x.Id == id).Alterar(nome, cpf, dataNascimento, contatos); 
        }

        public Cliente SelecionarPorId(int id)
        {
            return TabelaCliente.FirstOrDefault(x => x.Id == id); 
        }

        public void Excluir(int id)
        {
            TabelaCliente.Remove(SelecionarPorId(id));
        }

        private void PreencherDados(List<Contato> contatos)
        {
            var con1 = contatos.Where(x => x.Id == 1).FirstOrDefault();
            var con2 = contatos.Where(x => x.Id == 2).FirstOrDefault();
            var con3 = contatos.Where(x => x.Id == 3).FirstOrDefault();

            List<Contato> contatos1 = new List<Contato>() { con1, con2 };
            List<Contato> contatos2 = new List<Contato>() { con2, con3 };
            List<Contato> contatos3 = new List<Contato>() { con1, con3 };

            TabelaCliente.Add(Cliente.Criar(1, "Luis Lemos", "123456789", new DateTime(2001, 9, 9), contatos1));
            TabelaCliente.Add(Cliente.Criar(1, "Lu", "123456229", new DateTime(2009, 9, 10), contatos2));
            TabelaCliente.Add(Cliente.Criar(1, "Yudi", "123336789", new DateTime(1991, 3, 3), contatos3));
        }


    }

}
