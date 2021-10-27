using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class EnderecoRepositorio
    {

        public List<Endereco> TabelaEndereco { get; private set; } = new List<Endereco>();

        public EnderecoRepositorio()
        {
            PreencherDados();
        }

        public void Incluir(Endereco endereco)
        {
            TabelaEndereco.Add(endereco); 
        }

        public void Alterar(int id, string logradouro, string cidade, string uf, string numero, string complemento)
        {
            TabelaEndereco.FirstOrDefault(x => x.Id == id).Alterar(logradouro, cidade, uf, numero, complemento);
        }

        public Endereco SelecionarPorId(int id)
        {
              return TabelaEndereco.FirstOrDefault(x => x.Id == id); 
        }

        public void Excluir(int id)
        {
            TabelaEndereco.Remove(SelecionarPorId(id)); 
        }

        private void PreencherDados()
        {
            TabelaEndereco.Add(Endereco.Criar(1, "n sei", "Bsb", "DF", "12", "A"));
            TabelaEndereco.Add(Endereco.Criar(2, "n sei", "Bsb", "DF", "13", "B"));
            TabelaEndereco.Add(Endereco.Criar(3, "n sei", "Bsb", "DF", "14", "C"));
            TabelaEndereco.Add(Endereco.Criar(4, "n sei", "Bsb", "DF", "15", "D"));
        }

    }
}
