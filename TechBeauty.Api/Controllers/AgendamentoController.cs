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
        public void Post(int servicoId, string pessoaAtendia,
            DateTime dataHoraInicio, int ordemServicoId,
            DateTime dataHoraCriacao, DateTime dataHoraTermino,
            int colaboradorId, int pagamentoClienteID)
        {
            agendamentoBD.Incluir(Agendamento.Criar(servicoId, colaboradorId, pessoaAtendia,
                dataHoraInicio, ordemServicoId, dataHoraCriacao, dataHoraTermino, pagamentoClienteID));
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
