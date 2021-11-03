namespace TechBeauty.Dominio.Modelo
{
    public class CargoContratoTrabalho
    {
        public int ID { get; set; }
        public int CargoID { get; set; }
        public Cargo Cargo { get; set; }
        public int ContratoDeTrabalhoID { get; set; }
        public ContratoTrabalho ContratoTrabalho { get; set; }
    }
}
