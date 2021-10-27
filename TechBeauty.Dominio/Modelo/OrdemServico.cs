using TechBeauty.Dominio.Modelo.Enumeradores;

namespace TechBeauty.Dominio.Modelo
{
    public class OrdemServico
    {
        public int Id { get; private set; }
        public decimal PrecoTotal { get; private set; }
        public int DuracaoTotal { get; private set; }
        public Cliente Cliente { get; private set; }
        public StatusOS Status { get; private set; }


        public static OrdemServico Criar(int id, decimal precoTotal, int duracaoTotal, Cliente cliente, StatusOS status)
        {
            OrdemServico ordemServico = new OrdemServico();
            ordemServico.Id = id;
            ordemServico.PrecoTotal = precoTotal;
            ordemServico.DuracaoTotal = duracaoTotal;
            ordemServico.Cliente = cliente;
            ordemServico.Status = status;
            return ordemServico;
        }

        public void Alterar(decimal precoTotal, int duracaoTotal, Cliente cliente, StatusOS status)
        {
            PrecoTotal = precoTotal;
            DuracaoTotal = duracaoTotal;
            Cliente = cliente;
            Status = status; 
        }



    }
}