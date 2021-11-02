namespace TechBeauty.Dominio.Modelo
{
    public class ContatoPessoa
    {
        public int ID { get; set; }
        public Pessoa Pessoa { get; set; }
        public Contato Contato { get; set; }
        public int PessoaID { get; set; }
        public int ContatoID { get; set; }
    }
}
