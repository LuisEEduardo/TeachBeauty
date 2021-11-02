namespace TechBeauty.Dominio.Modelo
{
    public class PagamentoColaboradorCLT : PagamentoColaborador
    {
        protected override void CalcPagamento()
        {
            Colaborador.ContratoTrabalho.AlterarSalario(Colaborador.ContratoTrabalho.Salario + ValorComissao); 
        }
    }
}
