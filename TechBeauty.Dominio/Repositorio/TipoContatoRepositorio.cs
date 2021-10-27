using System.Collections.Generic;
using System.Linq;
using TechBeauty.Dominio.Modelo;

namespace TechBeauty.Dominio.Repositorio
{
    public class TipoContatoRepositorio
    {
        public List<TipoContato> TabelaTipoContato { get; private set; } = new List<TipoContato>();

        public TipoContatoRepositorio()
        {
            PreencherDados();
        }

        public void Incluir(TipoContato tipoContato)
        {
            TabelaTipoContato.Add(tipoContato);
        }

        public void Alterar(int id, string valor)
        {
            TabelaTipoContato.FirstOrDefault(x => x.Id == id).AlterarValor(valor); 
        }

        public TipoContato SelecionarPorId(int id)
        {
            return TabelaTipoContato.FirstOrDefault(x => x.Id == id);
        }

        public void Excluir(int id)
        {
            TabelaTipoContato.Remove(SelecionarPorId(id));
        }

        private void PreencherDados()
        {
            Incluir(TipoContato.Criar(1, "Telefone"));
            Incluir(TipoContato.Criar(2, "Instagram"));
            Incluir(TipoContato.Criar(3, "Tiktok"));
        }

    }
}
