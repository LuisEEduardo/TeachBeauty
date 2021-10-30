﻿using System;

namespace TechBeauty.Dominio.Modelo
{
    public class Escala
    {
        public int Id { get; private set; }
        public DateTime DataHoraEntrada { get; private set; }
        public DateTime DataHoraSaida { get; private set; }
        public Colaborador Colaborador { get; private set; }

        public static Escala Criar(int id, DateTime dataHoraEntrada, DateTime dataHoraSaida, Colaborador colaborador)
        {
            Escala escala = new Escala();
            escala.Id = id;
            escala.DataHoraEntrada = dataHoraEntrada;
            escala.DataHoraSaida = dataHoraSaida;
            escala.Colaborador = colaborador;

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
