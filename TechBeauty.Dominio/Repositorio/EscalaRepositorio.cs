using System;
using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class EscalaRepositorio
    {
        public List<Escala> TabelaEscala { get; private set; } = new List<Escala>();

        public EscalaRepositorio(Colaborador colaborador)
        {
            PreencherDados(colaborador);
        }

        public void Incluir(Escala escala)
        {
            TabelaEscala.Add(escala);
        }

        public void Alterar(int id, DateTime dataHoraEntrada, DateTime dataHoraSaida)
        {
            TabelaEscala.FirstOrDefault(x => x.Id == id).Alterar(dataHoraEntrada, dataHoraSaida); 
        }

        public Escala SelecionarPorId(int id)
        {
            return TabelaEscala.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            TabelaEscala.Remove(SelecionarPorId(id));
        }

        private void PreencherDados(Colaborador colaborador)
        {
            TabelaEscala.Add(Escala.Criar(1, new DateTime(2021, 10, 22, 8, 2, 10), new DateTime(2021, 10, 22, 20, 2, 12), colaborador));
            TabelaEscala.Add(Escala.Criar(2, new DateTime(2021, 10, 22, 8, 2, 10), new DateTime(2021, 10, 22, 20, 2, 12), colaborador));
            TabelaEscala.Add(Escala.Criar(3, new DateTime(2021, 10, 22, 8, 2, 10), new DateTime(2021, 10, 22, 20, 2, 12), colaborador));
        }


    }
}
