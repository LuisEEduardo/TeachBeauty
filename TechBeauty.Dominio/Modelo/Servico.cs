using System.Collections.Generic;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class Servico : IEntity
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public decimal Preco { get; private set; }
        public string Descricao { get; private set; }
        public int DuracaoEmMin { get; private set; }
        public List<ServicoColaborador> ServicosColaborador { get; set; }
        public List<Agendamento> Agendamentos { get; set; }

        public static Servico Criar(string nome, decimal preco, string descricao, int duracaoEmMin)
        {
            Servico servico = new Servico();
            servico.Nome = nome;
            servico.Preco = preco;
            servico.Descricao = descricao;
            servico.DuracaoEmMin = duracaoEmMin;

            return servico;
        }

        public void AlterarNome(string nome)
        {
            Nome = nome;
        }

        public void AlterarPreco(decimal preco)
        {
            Preco = preco;
        }

        public void AlterarDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public void AlterarDuracaoEmMin(int duracaoEmMin)
        {
            DuracaoEmMin = duracaoEmMin;
        }

    }

}