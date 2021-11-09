using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TechBeauty.Dados.Repositorio;
using TechBeauty.Dominio.Modelo;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechBeauty.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContratoTrabalhoController : ControllerBase
    {
        ContratoTrabalhoRepositorio contratoTrabalhoBD;

        public ContratoTrabalhoController()
        {
            contratoTrabalhoBD = new ContratoTrabalhoRepositorio();
        }

        // GET: api/<ContratoTrabalhoController>
        [HttpGet]
        public IEnumerable<ContratoTrabalho> Get()
        {
            return contratoTrabalhoBD.SelecionarTudo();
        }

        // GET api/<ContratoTrabalhoController>/5
        [HttpGet("{id}")]
        public ContratoTrabalho Get(int id)
        {
            return contratoTrabalhoBD.Selecionar(id);
        }

        // POST api/<ContratoTrabalhoController>
        [HttpPost]
        public void Post(int regimeContratualId, DateTime dataEntrada, string cnpjCTPS, int colaboradorID)
        {
            contratoTrabalhoBD.Incluir(ContratoTrabalho.Criar(regimeContratualId, dataEntrada, cnpjCTPS, colaboradorID));
        }

        // PUT api/<ContratoTrabalhoController>/5
        [HttpPut("{id}")]
        public void Put(int id, string cnpjCTPS)
        {
            ContratoTrabalho contratoTrabalho = contratoTrabalhoBD.Selecionar(id); 
            if (contratoTrabalho != null)
            {
                contratoTrabalho.AlterarCnpjCTPS(cnpjCTPS);
                contratoTrabalhoBD.Alterar(contratoTrabalho);
            }
        }

        // DELETE api/<ContratoTrabalhoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            contratoTrabalhoBD.Excluir(id);
        }
    }
}
