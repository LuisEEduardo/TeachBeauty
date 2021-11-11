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
    public class FormaPagamentoController : ControllerBase
    {
        FormasPagamentoRepositorio formaPagamentoBD;

        public FormaPagamentoController()
        {
            formaPagamentoBD = new FormasPagamentoRepositorio();
        }

        // GET: api/<FormaPagamentoController>
        [HttpGet]
        public IEnumerable<FormasPagamento> Get()
        {
            return formaPagamentoBD.SelecionarTudo();
        }

        // GET api/<FormaPagamentoController>/5
        [HttpGet("{id}")]
        public FormasPagamento Get(int id)
        {
            return formaPagamentoBD.Selecionar(id);
        }

        // POST api/<FormaPagamentoController>
        [HttpPost]
        public void Post(string nome, string descricao)
        {
            formaPagamentoBD.Incluir(FormasPagamento.CriarPagamento(nome, descricao));
        }

        // PUT api/<FormaPagamentoController>/5
        [HttpPut("{id}")]
        public void Put(int id, string nome, string descricao)
        {
            FormasPagamento formasPagamento = formaPagamentoBD.Selecionar(id);
            if (formasPagamento != null)
            {
                formasPagamento.AlterarNome(nome);
                formasPagamento.AlterarDescricao(descricao);
                formaPagamentoBD.Alterar(formasPagamento);
            }
        }

        // DELETE api/<FormaPagamentoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            formaPagamentoBD.Excluir(id);
        }
    }
}
