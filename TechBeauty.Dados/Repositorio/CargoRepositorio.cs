using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dados.Repositorio
{
    public class CargoRepositorio
    {

        protected readonly Contexto contexto;  

        public CargoRepositorio()
        {
            contexto = new Contexto();
        }

        public void Incluir(Cargo cargo)
        {
            contexto.Cargo.Add(cargo);
            contexto.SaveChanges();   // Inclui no Bd
        }

        public void Alterar(Cargo cargo)
        {
            contexto.Cargo.Update(cargo);
            contexto.SaveChanges();
        }

        public Cargo SelecionarPorId(int id)
        {
            return contexto.Cargo.FirstOrDefault(x => x.Id == id);
        }
        
        public void Excluir(int id)
        {
            var entity = SelecionarPorId(id); 
            contexto.Cargo.Remove(entity);
            contexto.SaveChanges();
        }

        public void Dispose()   
        {
            contexto.Dispose();
        }
        // Dá controle a funcionalidades ao c#
        // uso interessante para funcionalidades externas para fechar conecção com o bd, por exemplo.        

    }
}