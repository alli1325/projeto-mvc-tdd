using System.ComponentModel.DataAnnotations;
using DesafioTDD.Validations;

namespace DesafioTDD.DTO
{
    public class DepositoDTO
    {
        public string Numero { get; set; }
        public double Saldo { get; set; }
        [Required(ErrorMessage = "Informar o valor do saque")]
        [ValidaDeposito]
        public double Valor { get; set; }
    }
}