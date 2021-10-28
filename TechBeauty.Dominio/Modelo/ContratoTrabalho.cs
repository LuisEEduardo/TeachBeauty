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
        public int Bonificacao { get; private set; }
        public decimal Salario { get; private set; }
        // ---------------------------------------------------

        public static ContratoTrabalho Criar(int Id,
            RegimeContratual regimeContratual,
            DateTime dataEntrada,
            DateTime? dataDesligamento,
            List<Cargo> cargos,
            string cnpjCTPS)
        {
            ContratoTrabalho contratoTrabalho = new ContratoTrabalho();
            contratoTrabalho.Id = Id;
            contratoTrabalho.RegimeContratual = regimeContratual;
            contratoTrabalho.DataEntrada = dataEntrada;
            contratoTrabalho.DataDesligamento = dataDesligamento;
            contratoTrabalho.Cargos = cargos;
            contratoTrabalho.CnpjCTPS = cnpjCTPS;
            return contratoTrabalho;
        }

        public void Alterar(RegimeContratual regimeContratual,
            DateTime dataEntrada,
            DateTime? dataDesligamento,
            List<Cargo> cargos,
            string cnpjCTPS)
        {
            RegimeContratual = regimeContratual;
            DataEntrada = dataEntrada;
            DataDesligamento = dataDesligamento;
            Cargos = cargos;
            CnpjCTPS = cnpjCTPS;
        }

        public void ListarAtividades()
        {
            Console.WriteLine("Atividades:");
            foreach (Cargo cargo in Cargos)
            {
                Console.WriteLine($"{cargo.Id}, {cargo.Nome}, {cargo.Descricao}");
            }
        }

        public String CalcTempoNaEmpresa()
        {         
            DateTime dtAtual = DateTime.Now;
            String tempoDeEmpresa = $"Você tem {Math.Abs(dtAtual.Year - DataEntrada.Year)} anos, " +
                $"{Math.Abs(dtAtual.Month - DataEntrada.Month)} meses, {Math.Abs(dtAtual.Day - DataEntrada.Day)} dias";
            return tempoDeEmpresa;
        }

        public void TrocarRegimeContratual(RegimeContratual novoRegimeContratual)
        {
            RegimeContratual = novoRegimeContratual;
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