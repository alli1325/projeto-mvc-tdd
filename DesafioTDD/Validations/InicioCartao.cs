using System;
using System.ComponentModel.DataAnnotations;
using DesafioTDD.DTO;

namespace DesafioTDD.Validations
{
    public class InicioCartao : ValidationAttribute
    {  
        public InicioCartao() : base("Número do cartao deve iniciar com 1895 ou 3567.")
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext context)
        {
            if (value != null)
            {
                var valueString = value.ToString();
                if(valueString.Length >= 4)
                {
                    var substring = value.ToString().Substring(0, 4);
                    if (substring != "1895" && substring != "3567") 
                    {
                        var errorMessage = FormatErrorMessage(substring);
                        return new ValidationResult(errorMessage);
                    }
                }

            }
                
            return ValidationResult.Success;
        }
    }
}