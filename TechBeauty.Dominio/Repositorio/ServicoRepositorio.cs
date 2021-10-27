using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class ServicoRepositorio
    {

        public List<Servico> TabelaServico { get; private set; } = new List<Servico>();

        public ServicoRepositorio()
        {
            PreencherDados();
        }

        public void Incluir(Servico servico)
        {
            TabelaServico.Add(servico);
        }

        public void Alterar(int id, string nome, decimal preco, string descricao, int duracaoEmMin)
        {
            TabelaServico.FirstOrDefault(x => x.Id == id).Alterar(nome, preco, descricao, duracaoEmMin);
        }

        public Servico SelecionarPorId(int id)
        {
            return TabelaServico.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            TabelaServico.Remove(SelecionarPorId(id));
        }

        private void PreencherDados()
        {
            TabelaServico.Add(Servico.Criar(1, "Corte", 10, "Corte de cabelo", 30));
            TabelaServico.Add(Servico.Criar(2, "Barba", 8, "Fazer barba", 10));
            TabelaServico.Add(Servico.Criar(3, "Unha", 30, "Fazer unha", 45));
        }

    }
}
