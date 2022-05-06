namespace DesafioTDD.Models
{
    public class Cartao
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public string Senha { get; set; }
        public double Saldo { get; set; }
        public bool Status { get; set; }
    }
}