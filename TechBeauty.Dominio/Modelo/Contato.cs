using TechBeauty.Dominio.Repositorio;

namespace TechBeauty.Dominio.Modelo
{
    public class Contato : IEntity
    {

        public int Id { get; private set; }
        public TipoContato Tipo { get; private set; }
        public string Valor { get; private set; }
        public int TipoContatoID { get; set; }
        public int PessoaID { get; set; }
        public Pessoa Pessoa { get; set; }

        public static Contato Criar(int tipoContatoId, string valor, int pessoaId)
        {
            Contato contato = new Contato();
            contato.TipoContatoID = tipoContatoId; 
            contato.Valor = valor;
            contato.PessoaID = pessoaId; 
            return contato; 
        }

        public void AlterarContato(TipoContato tipo, string valor)
        {
            Tipo = tipo;
            Valor = valor;
        }

        public void AlterarTipoContato(TipoContato tipo)
        {
            Tipo = tipo; 
        }

        public void AlterarValorContato(string valor)
        {
            Valor = valor;
        }

    }
}