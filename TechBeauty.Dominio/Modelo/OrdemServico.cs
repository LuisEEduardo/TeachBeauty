using System.Collections.Generic;
using TechBeauty.Dominio.Modelo.Enumeradores;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class OrdemServico : IEntity
    {
        public int Id { get; private set; }
        public decimal PrecoTotal { get; private set; }
        public int DuracaoTotal { get; private set; }
        public Cliente Cliente { get; private set; }
        public StatusOS Status { get; private set; }
        public int ClienteID { get; set; }
        public List<Agendamento> Agendamentos { get; set; }
        public PagamentoCliente PagamentoCliente { get; set; }
        public int PagamentoClienteId { get; set; }

        public static OrdemServico Criar(decimal precoTotal, int duracaoTotal, int clienteId, StatusOS status)
        {
            OrdemServico ordemServico = new OrdemServico();
            ordemServico.PrecoTotal = precoTotal;
            ordemServico.DuracaoTotal = duracaoTotal;
            ordemServico.ClienteID = clienteId;
            ordemServico.Status = status;
            return ordemServico;
        }

        public void AddValorPrecoTotal(decimal preco)
        {
            PrecoTotal += preco; 
        }

        public void RemoveDeValorPrecoTotal(decimal preco)
        {
            PrecoTotal -= preco;
        }

        public void AddDuracaoTotal(int tempoEmMin)
        {
            DuracaoTotal += tempoEmMin;
        }

        public void RemoverDeDuracaoTotal(int tempoEmMin)
        {
            DuracaoTotal += tempoEmMin;
        }

        public void AlterarCliente(Cliente cliente)
        {
            Cliente = cliente;
        }

        public void AlterarStatus(StatusOS status)
        {
            Status = status; 
        }

    }

}