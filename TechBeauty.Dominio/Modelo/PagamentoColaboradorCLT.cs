namespace TechBeauty.Dominio.Modelo
{
    public class PagamentoColaboradorCLT : PagamentoColaborador
    {
        protected override void CalcPagamento()
        {
            Colaborador.Contrato.AlterarSalario(Colaborador.Contrato.Salario + ValorComissao); 
        }
    }
}
