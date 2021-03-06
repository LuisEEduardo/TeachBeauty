using System.Collections.Generic;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class Endereco : IEntity
    {
        public int Id { get; private set; }
        public string Logradouro { get; private set; }
        public string Cidade { get; private set; }
        public string UF { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string CEP { get; private set; }
        public string Bairro { get; private set; }
        public List<Colaborador> Colaboradores { get; set; }

        public static Endereco Criar(string logradouro, string cidade,
            string uf, string numero, string cep, string bairro, string complemento = "")
        {
            Endereco endereco = new Endereco();
            endereco.Logradouro = logradouro;
            endereco.Cidade = cidade;
            endereco.UF = uf;
            endereco.Numero = numero;
            endereco.CEP = cep;
            endereco.Bairro = bairro;
            endereco.Complemento = complemento;
            return endereco;
        }

        public void Alterar(string logradouro, string cidade, string uf,
            string numero, string complemento)
        {
            Logradouro = logradouro;
            Cidade = cidade;
            UF = uf;
            Numero = numero;
            Complemento = complemento;
        }

        public void MudarEndereco(string cep, string logradouro, string numero, string bairro, string complemento = "")
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Bairro = bairro;
            CEP = cep;
        }

        public void MudarCidade(string cidade)
        {
            Cidade = cidade;
        }

        public void MudarUf(string uf)
        {
            UF = uf;
        }

        public void AlterarComplemento(string complemento)
        {
            Complemento = complemento;
        }

        public void AlterarCEP(string cep)
        {
            CEP = cep;
        }

        public void AlterarBairro(string bairro)
        {
            Bairro = bairro;
        }

    }
}
