using System.Collections.Generic;
using TechBeauty.Dominio.Modelo;
using System;
using System.Linq;

namespace TechBeauty.Dados.Repositorio
{
    public class PagamentoColaboradorRepositorio : RepositorioBase<PagamentoColaborador>
    {

        /*
         1. Criar no repositório o incluir pagamento
            a. Dentro do incluir pagamento fazer uma consulta para saber quais os serviços que o profissional fez no dia.
            b. Descobrir qual o valor de cada serviço feito
            c. Somar o valor de todos os serviços 
            d. Descobrir qual a porcentagem de comissão que está no contrato
            e. Chamar o método CalcValorComicao e passar o valor da soma e porcentagem
            f. Salvar no banco
         */

        public void IncluirPagamento(int ColaboradorId)
        {
            AgendamentoRepositorio agendamentoBD = new AgendamentoRepositorio();

            List<Agendamento> agendamentosDoDia = new List<Agendamento>();
            foreach (var agendamento in agendamentoBD.SelecionarTudo())
            {
                if (agendamento.DataHoraInicio == DateTime.Now && agendamento.ColaboradorID == ColaboradorId)
                {
                    agendamentosDoDia.Add(agendamento);
                }
            }

            decimal valorDoServicoDia = 0;

            foreach (var agendamento in agendamentosDoDia)
            {
                valorDoServicoDia += agendamento.Servico.Preco;
            }
            ColaboradorRepositorio colaboradorBD = new ColaboradorRepositorio();
            int percentual = colaboradorBD.Selecionar(ColaboradorId).PorcentagemComissao;
            PagamentoColaborador pagamentoColaborador = (PagamentoColaborador)contexto.PagamentoColaborador.Where(x => x.Colaboradores[0].Id == ColaboradorId).Select(x => x);
            pagamentoColaborador.CalcValorComicao(valorDoServicoDia, percentual);
            contexto.SaveChanges();
            
        }

    }
}
