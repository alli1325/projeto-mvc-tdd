using System.ComponentModel.DataAnnotations;
using DesafioTDD.Validations;

namespace DesafioTDD.DTO
{
    public class SaqueDTO
    {
        public string Numero { get; set; }
        public double Saldo { get; set; }
        [Required(ErrorMessage = "Informar o valor do saque")]
        [ValidaSaque("Saldo")]
        public double Valor { get; set; }
    }
}