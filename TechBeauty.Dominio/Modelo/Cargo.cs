namespace TechBeauty.Dominio.Modelo
{
    public class Cargo
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }

        public static Cargo Criar(int id, string nome, string descricao = "Não definiu")
        {
            Cargo cargo = new Cargo();
            cargo.Id = id;
            cargo.Nome = nome;
            cargo.Descricao = descricao;

            return cargo;
        }

        public void Alterar(string nome, string descricao)
        {
            Nome = nome;
            Descricao = descricao;
        }

        public void MudarNome(string nome)
        {
            Nome = nome; 
        }

        public void MudarDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public override string ToString()
        {
            return $"Id: {Id}, " +
                $"Nome: {Nome}, " +
                $"Descrição: {Descricao}";
        }

    }
}