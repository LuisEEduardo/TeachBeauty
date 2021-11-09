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
    public class EscalaController : ControllerBase
    {
        EscalaRepositorio escalaBD;

        public EscalaController()
        {
            escalaBD = new EscalaRepositorio(); 
        }

        // GET: api/<EscalaController>
        [HttpGet]
        public IEnumerable<Escala> Get()
        {
            return escalaBD.SelecionarTudo();
        }

        // GET api/<EscalaController>/5
        [HttpGet("{id}")]
        public Escala Get(int id)
        {
            return escalaBD.Selecionar(id);
        }

        // POST api/<EscalaController>
        [HttpPost]
        public void Post(DateTime dataHoraEntrada, DateTime dataHoraSaida, int colaboradorId)
        {
            escalaBD.Incluir(Escala.Criar(dataHoraEntrada, dataHoraSaida, colaboradorId));
        }

        // PUT api/<EscalaController>/5
        [HttpPut("{id}")]
        public void Put(int id, DateTime dataHoraEntrada, DateTime dataHoraSaida)
        {
            Escala escala = escalaBD.Selecionar(id); 
            if (escala != null)
            {
                escala.AlterarDataHoraEntrada(dataHoraEntrada);
                escala.AlterarDataHoraSaida(dataHoraSaida);
                escalaBD.Alterar(escala);
            }
        }

        // DELETE api/<EscalaController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            escalaBD.Excluir(id);
        }
    }
}
