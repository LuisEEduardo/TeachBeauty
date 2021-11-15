using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechBeauty.Dados.Repositorio;
using TechBeauty.Dominio.Modelo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechBeauty.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColaboradorController : ControllerBase
    {

        ColaboradorRepositorio colaboradorBD;

        public ColaboradorController()
        {
            colaboradorBD = new ColaboradorRepositorio();
        }

        // GET: api/<ColaboradorController>
        [HttpGet]
        public IEnumerable<Colaborador> Get()
        {
            return colaboradorBD.SelecionarTudo();
        }

        // GET api/<ColaboradorController>/5
        [HttpGet("{id}")]
        public Colaborador Get(int id)
        {
            return colaboradorBD.Selecionar(id);
        }

        // POST api/<ColaboradorController>
        [HttpPost]
        public void Post(int enderecoId, int generoId, string nomeSocial, string nome, 
            string cpf, DateTime dataNascimento, int pagamentoComissao)
        {
            colaboradorBD.Incluir(Colaborador.Criar(enderecoId, generoId, nomeSocial, 
                nome, cpf, dataNascimento, pagamentoComissao));
        }

        // PUT api/<ColaboradorController>/5
        [HttpPut("{id}")]
        public void Put(int id, string nome, string nomeSocial, decimal salario)
        {
            Colaborador colaborador = colaboradorBD.Selecionar(id);
            if (colaborador != null)
            {
                colaborador.AlterarNome(nome);
                colaborador.AlterarNomeSocial(nomeSocial);
                colaborador.AlterarSalario(salario);
                colaboradorBD.Alterar(colaborador);
            }
        }

        // DELETE api/<ColaboradorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            colaboradorBD.Excluir(id);
        }
    }
}
