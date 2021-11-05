using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class PagamentoColaboradorCLT : PagamentoColaborador, IEntity
    {
        public PagamentoColaborador PagamentoColaborador { get; set; }
        public int PagamentoColaboradorID { get; set; }
        protected override void CalcPagamento()
        {
            Colaborador.AlterarSalario(Colaborador.Salario + ValorComissao);
            PagamentoColaborador.Caixa.RetirarValor(Colaborador.Salario);
        }
    }
}
