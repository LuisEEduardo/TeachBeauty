namespace TechBeauty.Dominio.Modelo
{
    public class RegimeContratual
    {
        public int Id { get; private set; }
        public string Valor { get; private set; }

        public static RegimeContratual Criar(int id, string valor)
        {
            RegimeContratual regimeContratual = new RegimeContratual();
            regimeContratual.Id = id;
            regimeContratual.Valor = valor;
            return regimeContratual;
        }

        public void Alterar(string valor)
        {
            Valor = valor;
        }

    }
}