using System.Collections.Generic;

namespace TechBeauty.Dominio.Modelo
{
    public class FormasPagamento
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public List<PagamentoColaborador> PagamentosColaborador { get; set; }
        public List<PagamentoClienteFormasPagamento> pagamentoClienteFormasPagamentos { get; set; }

        public static FormasPagamento CriarPagamento(int id, string nome, string descricao)
        {
            FormasPagamento formasPagamento = new FormasPagamento();
            formasPagamento.Id = id;
            formasPagamento.Nome = nome;
            formasPagamento.Descricao = descricao;

            return formasPagamento;
        }

        public void AlterarNome(string nome)
        {
            Nome = nome;
        }

        public void AlterarDescricao(string descricao)
        {
            Descricao = descricao; 
        }

    }
}
