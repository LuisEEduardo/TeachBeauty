using System;
using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    class ColaboradorRepositorio
    {

        public List<Colaborador> TabelaColaborador { get; private set; } = new List<Colaborador>();

        public ColaboradorRepositorio(List<Contato> contatos,
            List<Servico> servicos,
            Endereco endereco,
            Genero genero,
            ContratoTrabalho contratoTrabalho)
        {
            PreencherDados(contatos, servicos, endereco, genero, contratoTrabalho);
        }

        public void Incluir(Colaborador colaborador)
        {
            TabelaColaborador.Add(colaborador);
        }

        public void Alterar(int id, List<Servico> servicos, Endereco endereco, Genero genero, string nomeSocial, ContratoTrabalho contrato)
        {
            TabelaColaborador.FirstOrDefault(x => x.Id == id).Alterar(servicos, endereco, genero, nomeSocial, contrato);
        }

        public Colaborador SelecionarPorId(int id)
        {
            return TabelaColaborador.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            TabelaColaborador.Remove(SelecionarPorId(id));
        }

        private void PreencherDados(List<Contato> contatos,
            List<Servico> servicos,
            Endereco endereco,
            Genero genero,
            ContratoTrabalho contratoTrabalho)
        {
            Contato c1 = contatos.Where(x => x.Id == 1).FirstOrDefault();
            Contato c2 = contatos.Where(x => x.Id == 2).FirstOrDefault();
            Contato c3 = contatos.Where(x => x.Id == 3).FirstOrDefault();

            List<Contato> contatos1 = new List<Contato>() { c1, c2 };
            List<Contato> contatos2 = new List<Contato>() { c3, c2 };

            Servico s1 = servicos.Where(x => x.Id == 1).FirstOrDefault();
            Servico s2 = servicos.Where(x => x.Id == 2).FirstOrDefault();
            Servico s3 = servicos.Where(x => x.Id == 3).FirstOrDefault();

            List<Servico> servicos1 = new List<Servico>() { s2, s1 };
            List<Servico> servicos2 = new List<Servico>() { s3 };

            TabelaColaborador.Add(Colaborador.Criar(servicos1, endereco, genero,
                null, contratoTrabalho, "Maria", "12345678", new DateTime(2000, 10, 1), contatos1));
            TabelaColaborador.Add(Colaborador.Criar(servicos2, endereco, genero, "",
                contratoTrabalho, "Taison", "1232323232", new DateTime(1999, 1, 1), contatos2));
        }

    }
}
