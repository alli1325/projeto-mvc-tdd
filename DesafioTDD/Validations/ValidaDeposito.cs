using System.ComponentModel.DataAnnotations;
using System.Linq;
using DesafioTDD.Data;

namespace DesafioTDD.Validations
{
    public class ValidaDeposito : ValidationAttribute
    {
        public ValidaDeposito() : base("{0}")
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            if (value != null)
            {
                var valueString = value.ToString();
                var valueInt = int.Parse(valueString);
                if(valueInt < 1)
                {
                    var message = "Valor mínimo para depósito é de R$1";
                    var errorMessage = FormatErrorMessage(message);
                    return new ValidationResult(errorMessage);   
                }
            }
                
            return ValidationResult.Success;
        }
    }
}