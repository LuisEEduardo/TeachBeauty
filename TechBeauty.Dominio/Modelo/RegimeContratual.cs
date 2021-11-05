using System.Collections.Generic;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class RegimeContratual : IEntity
    {
        public int Id { get; private set; }
        public string Valor { get; private set; }
        public List<ContratoTrabalho> ContratosDeTrabalho { get; set; } 

        public static RegimeContratual Criar(string valor)
        {
            RegimeContratual regimeContratual = new RegimeContratual();
            regimeContratual.Valor = valor;
            return regimeContratual;
        }

        public void AlterarValor(string valor)
        {
            Valor = valor;
        }

    }
}