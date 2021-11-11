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
    public class PagamentoClienteController : ControllerBase
    {
        PagamentoClienteRepositorio pagamentoClienteBD;

        public PagamentoClienteController()
        {
            pagamentoClienteBD = new PagamentoClienteRepositorio();
        }


        // GET: api/<PagamentoClienteController>
        [HttpGet]
        public IEnumerable<PagamentoCliente> Get()
        {
            return pagamentoClienteBD.SelecionarTudo();
        }

        // GET api/<PagamentoClienteController>/5
        [HttpGet("{id}")]
        public PagamentoCliente Get(int id)
        {
            return pagamentoClienteBD.Selecionar(id);
        }

        // POST api/<PagamentoClienteController>
        [HttpPost]
        public void Post(DateTime diaPagamento, int formasPagamentoId,
            StatusPagamento statusAgendamento, decimal pagamento, int colaboradorId)
        {
            pagamentoClienteBD.Incluir(PagamentoCliente.Criar(diaPagamento, formasPagamentoId,
                statusAgendamento, pagamento, colaboradorId));
        }

        // PUT api/<PagamentoClienteController>/5
        [HttpPut("{id}")]
        public void Put(int id, StatusPagamento statusPagamento)
        {
            PagamentoCliente pagamentoCliente = pagamentoClienteBD.Selecionar(id);
            if (pagamentoCliente != null)
            {
                pagamentoCliente.AlterarStatusPagamento(statusPagamento);
                pagamentoClienteBD.Alterar(pagamentoCliente);
            }
        }

        // DELETE api/<PagamentoClienteController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            pagamentoClienteBD.Excluir(id);
        }
    }
}
