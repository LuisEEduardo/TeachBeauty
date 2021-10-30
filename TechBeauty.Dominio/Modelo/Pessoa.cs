using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class Pessoa
    {
        public int Id { get; protected set; }
        public string Nome { get; protected set; }
        public string CPF { get; protected set; }
        public DateTime DataNascimento { get; protected set; }
        public List<Contato> Contatos { get; protected set; }

        
        public bool ValidaCPF()
        {
            return true; 
        }

        public int CalcIdade()
        {
            return DateTime.Now.Year - DataNascimento.Year;
        }

        public void AlterarNome(string nome)
        {
            Nome = nome; 
        }


        public void AddContato(Contato contato)
        {
            Contatos.Add(contato);
        }

        public void RemoverContato(Contato contato)
        {
            Contatos.Remove(contato);
        }

    }
}