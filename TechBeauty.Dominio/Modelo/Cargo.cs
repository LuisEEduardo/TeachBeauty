﻿using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Cargo
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public List<CargoContratoTrabalho> CargoContratoTrabalhos { get; set; }
        public static Cargo Criar(string nome, string descricao = "Não definiu")
        {
            Cargo cargo = new Cargo();
            cargo.Nome = nome;
            cargo.Descricao = descricao;

            return cargo;
        }

        public void MudarNome(string nome)
        {
            Nome = nome; 
        }

        public void MudarDescricao(string descricao)
        {
            Descricao = descricao;
        }

    }
}