using System;
using System.Collections.Generic;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class ContratoTrabalho : IEntity
    {
        public int Id { get; private set; }
        public int RegimeContratualID { get; set; }
        public RegimeContratual RegimeContratual { get; private set; }
        public DateTime DataEntrada { get; private set; }
        public DateTime? DataDesligamento { get; private set; }
        public int ColaboradorID { get; set; }
        public Colaborador Colaborador { get; set; }
        public List<CargoContratoTrabalho> CargosContratosTrabalho { get; set; }
        public string CnpjCTPS { get; private set; }

        
        public static ContratoTrabalho Criar(
            int regimeContratualId,
            DateTime dataEntrada,
            // List<CargoContratoTrabalho> cargosContratosTrabalhos,
            string cnpjCTPS,
            int colaboradorID)
        {
            ContratoTrabalho contratoTrabalho = new ContratoTrabalho();
            contratoTrabalho.RegimeContratualID = regimeContratualId;
            contratoTrabalho.DataEntrada = dataEntrada;
            // contratoTrabalho.CargosContratosTrabalho = cargosContratosTrabalhos;
            contratoTrabalho.CnpjCTPS = cnpjCTPS;
            contratoTrabalho.ColaboradorID = colaboradorID;
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

        public void AlterarRegimeContratual(RegimeContratual regimeContratual)
        {
            RegimeContratual = regimeContratual;
        }

        public void AddCargo(CargoContratoTrabalho cargosContratoTrabalho)
        {
            CargosContratosTrabalho.Add(cargosContratoTrabalho);
        }

        public void RemoverCargo(CargoContratoTrabalho cargosContratoTrabalho)
        {
            CargosContratosTrabalho.Remove(cargosContratoTrabalho);
        }

        public void AddDataDesligamento(DateTime data)
        {
            DataDesligamento = data;
        }

    }
}