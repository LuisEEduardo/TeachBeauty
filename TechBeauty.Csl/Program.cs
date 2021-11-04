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
            
            //var cargoDB = new CargoRepositorio();            
            //cargoDB.Incluir(Cargo.Criar("Colorista", "Colore unhas e cabelos em geral"));

            var cargoDB = new RegimeContratualRepositorio();

            cargoDB.Excluir(6);
            cargoDB.Excluir(7);
            cargoDB.Excluir(8);


        }

    }
}