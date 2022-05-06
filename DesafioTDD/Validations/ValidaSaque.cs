using System.ComponentModel.DataAnnotations;
using System.Linq;
using DesafioTDD.Data;

namespace DesafioTDD.Validations
{
    public class ValidaSaque : ValidationAttribute
    {
        public string OtherProperty { get; }
        public ValidaSaque(string otherProperty) : base("{0}")
        {
            OtherProperty = otherProperty;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                //pega contexto da propriedade Saldo
                var otherProperty = validationContext.ObjectType.GetProperty(OtherProperty);
                var otherPropertyValue = (double)otherProperty.GetValue(validationContext.ObjectInstance, null);

                var valueString = value.ToString();
                var valueDouble = double.Parse(valueString);

                if(valueDouble < 10)
                {
                    var message = "Cédula mínima para saque é de R$10";
                    var errorMessage = FormatErrorMessage(message);
                    return new ValidationResult(errorMessage);   
                }
                if(valueDouble % 10 != 0)
                {
                    var message = "O valor deve ser múltimo de 10";
                    var errorMessage = FormatErrorMessage(message);
                    return new ValidationResult(errorMessage);
                }
                if(valueDouble > 500)
                {
                    var message = "O limite de saque para esse terminal é de R$500";
                    var errorMessage = FormatErrorMessage(message);
                    return new ValidationResult(errorMessage);
                }
                if(valueDouble > otherPropertyValue)
                {
                    var message = "O valor do saque não pode ser maior que o saldo";
                    var errorMessage = FormatErrorMessage(message);
                    return new ValidationResult(errorMessage);
                }

            }
                
            return ValidationResult.Success;
        }
    }
}