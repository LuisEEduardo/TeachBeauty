using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Csl
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------------------------------------------------------");

            GeneroRepositorio repoGenero = new GeneroRepositorio();
            TipoContatoRepositorio repoTipoContato = new TipoContatoRepositorio();
            ContatoRepositorio repoContato = new ContatoRepositorio(repoTipoContato.TabelaTipoContato);
            CargoRepositorio repoCargo = new CargoRepositorio();

            ServicoRepositorio repoServico = new ServicoRepositorio();
            EnderecoRepositorio repoEndereco = new EnderecoRepositorio();
            RegimeContratualRepositorio regimeContratualRepositorio = new RegimeContratualRepositorio();

            var regimeContratual = regimeContratualRepositorio.TabelaRegimeContratual[0];
            var cargos = repoCargo.TabelaCargo;

            ContratoTrabalhoRepositorio repoContratoTrabalhoRepositorio = new ContratoTrabalhoRepositorio(regimeContratual, cargos);

            List<Contato> contatos = new List<Contato>();
            foreach (var c in repoContato.TabelaContato)
            {
                contatos.Add(c);
            }


            ClienteRepositorio repoCliente = new ClienteRepositorio(contatos);

            foreach (var cliente in repoCliente.TabelaCliente)
            {
                Console.WriteLine($"Id: {cliente.Id}, Nome: {cliente.Nome}, Contato: {cliente.Contatos[0].Valor}," +
                    $" Cpf: {cliente.CPF}, Data de Nascimento: {cliente.DataNascimento}");
                Console.WriteLine($"{cliente.ListarContatos()}");
            }


        }

    }
}