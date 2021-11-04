using System;
using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    class ColaboradorRepositorio
    {

        protected readonly Contexto contexto; 

        public ColaboradorRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(Colaborador colaborador)
        {
            contexto.Colaborador.Add(colaborador);
            contexto.SaveChanges();
        }

        public void Alterar(Colaborador colaborador)
        {
            contexto.Colaborador.Update(colaborador);
        }

        public Colaborador SelecionarPorId(int id)
        {
            return contexto.Colaborador.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id);
            contexto.Colaborador.Remove(entity);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

    }
}
