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
    public class AgendamentoController : ControllerBase
    {

        AgendamentoRepositorio agendamentoBD;

        public AgendamentoController()
        {
            agendamentoBD = new AgendamentoRepositorio();
        }

        // GET: api/<AgendamentoController>
        [HttpGet]
        public IEnumerable<Agendamento> Get()
        {
            return agendamentoBD.SelecionarTudo();
        }

        // GET api/<AgendamentoController>/5
        [HttpGet("{id}")]
        public Agendamento Get(int id)
        {
            return agendamentoBD.Selecionar(id);
        }

        // POST api/<AgendamentoController>
        [HttpPost]
        public void Post(Servico servico, string pessoaAtendia, 
            DateTime dataHoraInicio, OrdemServico os, 
            DateTime dataHoraCriacao, DateTime dataHoraTermino, 
            Colaborador colaborador)
        {
            agendamentoBD.Incluir(Agendamento.Criar(servico, colaborador, pessoaAtendia, 
                dataHoraInicio, os, dataHoraCriacao, dataHoraTermino));
        }

        // PUT api/<AgendamentoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AgendamentoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
