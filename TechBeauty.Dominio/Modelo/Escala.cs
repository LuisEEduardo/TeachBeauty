using System;
using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class Escala : IEntity
    {
        public int Id { get; private set; }
        public DateTime DataHoraEntrada { get; private set; }
        public DateTime DataHoraSaida { get; private set; }
        public Colaborador Colaborador { get; private set; }
        public int ColaboradorID { get; set; }

        public static Escala Criar(DateTime dataHoraEntrada, DateTime dataHoraSaida, int colaboradorId)
        {
            Escala escala = new Escala();
            escala.DataHoraEntrada = dataHoraEntrada;
            escala.DataHoraSaida = dataHoraSaida;
            escala.ColaboradorID = colaboradorId;

            return escala; 
        }

        public void AlterarDataHoraEntrada(DateTime dataHoraEntrada)
        {
            DataHoraEntrada = dataHoraEntrada;
        }

        public void AlterarDataHoraSaida(DateTime dataHoraSaida)
        {
            DataHoraSaida = dataHoraSaida;
        }
    }
}
