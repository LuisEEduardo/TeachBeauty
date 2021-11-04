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
            
            var cargoDB = new CargoRepositorio();            
            cargoDB.Incluir(Cargo.Criar("Cabelereira", "Efetua cortes de cabelo feminino e masculino"));

            Console.WriteLine("Hello World");

        }

    }
}