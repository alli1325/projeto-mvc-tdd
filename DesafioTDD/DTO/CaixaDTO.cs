using System.ComponentModel.DataAnnotations;

namespace DesafioTDD.DTO
{
    public class CaixaDTO
    {
        [Required(ErrorMessage = "Campo deve ser preenchido.")]
        [RegularExpression(@"[0-9]{1,3}", ErrorMessage = "Utilizar somente números inteiros, valor máximo 999")]
        public int Ced100 { get; set; }
        [Required(ErrorMessage = "Campo deve ser preenchido.")]
        [RegularExpression(@"[0-9]{1,3}", ErrorMessage = "Utilizar somente números inteiros, valor máximo 999")]
        public int Ced50 { get; set; }
        [Required(ErrorMessage = "Campo deve ser preenchido.")]
        [RegularExpression(@"[0-9]{1,3}", ErrorMessage = "Utilizar somente números inteiros, valor máximo 999")]
        public int Ced20 { get; set; }
        [Required(ErrorMessage = "Campo deve ser preenchido.")]
        [RegularExpression(@"[0-9]{1,3}", ErrorMessage = "Utilizar somente números inteiros, valor máximo 999")]
        public int Ced10 { get; set; }
        public double Total { get; set; }
        public string TotalString { get; set; }
    }
}