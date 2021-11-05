using System;
using System.Collections.Generic;
using TechBeauty.Dados.Repositorio;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Csl
{
    class Program
    {
        static void Main(string[] args)
        {

            var DbTipoContato = new TipoContatoRepositorio();

            DbTipoContato.Incluir(TipoContato.Criar("Celular"));
            DbTipoContato.Incluir(TipoContato.Criar("Instagram"));
            DbTipoContato.Incluir(TipoContato.Criar("Facebook"));
            DbTipoContato.Incluir(TipoContato.Criar("Telefone"));

            foreach (var tiposcontato in DbTipoContato.SelecionarTudo())
            {
                Console.WriteLine($"Tipo do Contato : {tiposcontato.Valor}");
            }



        }

    }
}