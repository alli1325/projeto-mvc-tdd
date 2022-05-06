using System.ComponentModel.DataAnnotations;
using DesafioTDD.Validations;

namespace DesafioTDD.DTO
{
    public class HabilitarCartaoDTO
    {
        [Required(ErrorMessage = "Informe o número do cartão")]
        [StringLength(16, ErrorMessage = "Cartão deve conter somente 16 digitos")]
        [MinLength(16, ErrorMessage = "Cartão deve conter 16 digitos")]
        [InicioCartao]
        public string Numero { get; set; }
        [Required(ErrorMessage = "Informe a senha do cartão")]
        [StringLength(4, ErrorMessage = "Senha deve conter somente 4 digitos")]
        [MinLength(4, ErrorMessage = "Senha deve conter 4 digitos")]
        [RegularExpression(@"[0-9]{4,4}", ErrorMessage = "Senha contém somente dígitos 0-9")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Informe a senha do cartão")]
        [StringLength(4, ErrorMessage = "Senha deve conter somente 4 digitos")]
        [MinLength(4, ErrorMessage = "Senha deve conter 4 digitos")]
        [RegularExpression(@"[0-9]{4,4}", ErrorMessage = "Senha contém somente dígitos 0-9")]
        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage = "As senhas devem ser iguais")]
        public string ConfirmaSenha { get; set; }
    }
}