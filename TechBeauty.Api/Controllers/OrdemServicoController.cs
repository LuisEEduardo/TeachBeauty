using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechBeauty.Dados.Repositorio;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dominio.Modelo.Enumeradores;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechBeauty.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdemServicoController : ControllerBase
    {

        OrdemServicoRepositorio ordemServicoBD;

        public OrdemServicoController()
        {
            ordemServicoBD = new OrdemServicoRepositorio();
        }

        // GET: api/<OrdemServicoController>
        [HttpGet]
        public IEnumerable<OrdemServico> Get()
        {
            return ordemServicoBD.SelecionarTudo();
        }

        // GET api/<OrdemServicoController>/5
        [HttpGet("{id}")]
        public OrdemServico Get(int id)
        {
            return ordemServicoBD.Selecionar(id);
        }

        // POST api/<OrdemServicoController>
        [HttpPost]
        public void Post(decimal precoTotal, int duracaoTotal, int clienteId, StatusOS status)
        {
            ordemServicoBD.Incluir(OrdemServico.Criar(precoTotal, duracaoTotal, clienteId, status));
        }

        // PUT api/<OrdemServicoController>/5
        [HttpPut("{id}")]
        public void Put(int id, StatusOS status, Cliente cliente)
        {
            OrdemServico ordemServico = ordemServicoBD.Selecionar(id); 
            if (ordemServico != null)
            {
                ordemServico.AlterarCliente(cliente);
                ordemServico.AlterarStatus(status);
                ordemServicoBD.Alterar(ordemServico);
            }
        }

        // DELETE api/<OrdemServicoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ordemServicoBD.Excluir(id);
        }
    }
}
