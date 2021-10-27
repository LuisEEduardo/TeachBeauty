using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dominio.Modelo.Enumeradores;

namespace TechBeauty.Dominio.Repositorio
{
    public class OrdemServicoRepositorio
    {

        public List<OrdemServico> TabelaOrdemServico { get; private set; } = new List<OrdemServico>();

        public OrdemServicoRepositorio(Cliente cliente)
        {
            PreencherDados(cliente);
        }

        public void Incluir(OrdemServico ordemServico)
        {
            TabelaOrdemServico.Add(ordemServico);
        }

        public void Alterar(int id, decimal precoTotal, int duracaoTotal, Cliente cliente, StatusOS status)
        {
            TabelaOrdemServico.FirstOrDefault(x => x.Id == id).Alterar(precoTotal, duracaoTotal, cliente, status);
        }
        
        public OrdemServico SelecionarPorId(int id)
        {
            return TabelaOrdemServico.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            TabelaOrdemServico.Remove(SelecionarPorId(id));
        }

        private void PreencherDados(Cliente cliente)
        {
            TabelaOrdemServico.Add(OrdemServico.Criar(1, 100.00m, 30, cliente, StatusOS.Pendente));
            TabelaOrdemServico.Add(OrdemServico.Criar(2, 140.00m, 30, cliente, StatusOS.Concluido));
            TabelaOrdemServico.Add(OrdemServico.Criar(3, 30.00m, 30, cliente, StatusOS.ParcialmenteConcluido));
            TabelaOrdemServico.Add(OrdemServico.Criar(4, 50.50m, 30, cliente, StatusOS.Cancelado));
        }


    }
}
