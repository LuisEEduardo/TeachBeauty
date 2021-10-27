using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechBeauty.Dominio.Modelo
{
    public class Genero
    {
        public int Id { get; private set; }
        public string Valor { get; private set; }

        public static Genero Criar(int id, string valor)
        {
            Genero genero = new Genero();
            genero.Id = id;
            genero.Valor = valor;
            return genero;
        }

        public void Alterar(string valor)
        {
            Valor = valor;
        }
    }
}
