using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TechBeauty.Dados.Repositorio;
using TechBeauty.Dominio.Modelo;
using TechBeauty.Dominio.Modelo.Enumeradores;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechBeauty.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogAgendamentoController : ControllerBase
    {

        LogAgendamentoRepositorio logAgendamentoBD;

        public LogAgendamentoController()
        {
            logAgendamentoBD = new LogAgendamentoRepositorio();
        }


        // GET: api/<LogAgendamentoController>
        [HttpGet]
        public IEnumerable<LogAgendamento> Get()
        {
            return logAgendamentoBD.SelecionarTudo();
        }

        // GET api/<LogAgendamentoController>/5
        [HttpGet("{id}")]
        public LogAgendamento Get(int id)
        {
            return logAgendamentoBD.Selecionar(id);
        }

        // POST api/<LogAgendamentoController>
        [HttpPost]
        public void Post(DateTime dataCriacao, StatusAgendamento status)
        {
            logAgendamentoBD.Incluir(LogAgendamento.Criar(dataCriacao, status));
        }

        // PUT api/<LogAgendamentoController>/5
        [HttpPut("{id}")]
        public void Put(int id, StatusAgendamento status)
        {
            LogAgendamento logAgendamento = logAgendamentoBD.Selecionar(id);
            if (logAgendamento != null)
            {
                logAgendamento.AlterarStatus(status);
                logAgendamentoBD.Alterar(logAgendamento);
            }
        }

        // DELETE api/<LogAgendamentoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            logAgendamentoBD.Excluir(id);
        }

    }
}
