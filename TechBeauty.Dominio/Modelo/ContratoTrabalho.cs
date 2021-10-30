using System;
using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class ContratoTrabalho
    {
        public int Id { get; private set; }
        public RegimeContratual RegimeContratual { get; private set; }
        public DateTime DataEntrada { get; private set; }
        public DateTime? DataDesligamento { get; private set; }
        public List<Cargo> Cargos { get; private set; }
        public string CnpjCTPS { get; private set; }

        // Propriedades dos Sistema Financeiro ---------------
        public decimal Salario { get; private set; }
        // ---------------------------------------------------

        public static ContratoTrabalho Criar(int Id,
            RegimeContratual regimeContratual,
            DateTime dataEntrada,
            List<Cargo> cargos,
            string cnpjCTPS)
        {
            ContratoTrabalho contratoTrabalho = new ContratoTrabalho();
            contratoTrabalho.Id = Id;
            contratoTrabalho.RegimeContratual = regimeContratual;
            contratoTrabalho.DataEntrada = dataEntrada;
            contratoTrabalho.Cargos = cargos;
            contratoTrabalho.CnpjCTPS = cnpjCTPS;
            return contratoTrabalho;
        }

        public void RenovarContrato(DateTime dataEntrada, DateTime? dataDesligamento = null)
        {
            DataEntrada = dataEntrada;
            DataDesligamento = dataDesligamento;
        }

        public void AlterarCnpjCTPS(string cnpjCTPS)
        {
            CnpjCTPS = cnpjCTPS; 
        }

        public void AlterarSalario(decimal salario)
        {
            Salario = salario;
        }

        public void AlterarRegimeContratual(RegimeContratual regimeContratual)
        {
            RegimeContratual = regimeContratual;
        }

        public void AddCargo(Cargo cargo)
        {
            Cargos.Add(cargo);
        }

        public void RemoverCargo(Cargo cargo)
        {
            Cargos.Remove(cargo);
        }

        public void AddDataDesligamento(DateTime data)
        {
            DataDesligamento = data;
        }

    }
}