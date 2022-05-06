namespace DesafioTDD.Models
{
    public class Extrato
    {
        public int Id { get; set; }
        public Cartao Cartao { get; set; }
        public string Tipo { get; set; }
        public double Valor { get; set; }
        public string Data { get; set; }
    }
}