using System;
using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class ContratoTrabalhoRepositorio
    {

        public List<ContratoTrabalho> TabelaContratoTrabalho { get; private set; } = new List<ContratoTrabalho>();

        public ContratoTrabalhoRepositorio(RegimeContratual regimeContratual, List<Cargo> cargos)
        {
            PreencherDados(regimeContratual, cargos);
        }

        public void Incluir(ContratoTrabalho contratoTrabalho)
        {
            TabelaContratoTrabalho.Add(contratoTrabalho);
        }

        public void Alterar(int id,
            RegimeContratual regimeContratual,
            DateTime dataEntrada,
            DateTime? dataDesligamento,
            List<Cargo> cargos,
            string cnpjCTPS)
        {
            TabelaContratoTrabalho.FirstOrDefault(x => x.Id == id).Alterar(regimeContratual, dataEntrada, dataDesligamento, cargos, cnpjCTPS);
        }

        public ContratoTrabalho SelecionarPorId(int id)
        {
            return TabelaContratoTrabalho.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            TabelaContratoTrabalho.Remove(SelecionarPorId(id));
        }

        private void PreencherDados(RegimeContratual regimeContratual, List<Cargo> cargos)
        {

            var cabelereira = cargos.Where(x => x.Id == 1).FirstOrDefault();
            var manicure = cargos.Where(x => x.Id == 2).FirstOrDefault();
            var depiladora = cargos.Where(x => x.Id == 3).FirstOrDefault();
            var colorista = cargos.Where(x => x.Id == 4).FirstOrDefault();

            List<Cargo> cargo1 = new List<Cargo>() { cabelereira, depiladora };
            List<Cargo> cargo2 = new List<Cargo>() { manicure, colorista };

            TabelaContratoTrabalho.Add(ContratoTrabalho.Criar(1, regimeContratual, DateTime.Now, null, cargo1, "1234"));
            TabelaContratoTrabalho.Add(ContratoTrabalho.Criar(2, regimeContratual, DateTime.Now, null, cargo2, "12389"));

        }



    }
}
