using System.Collections.Generic;

namespace DesafioTDD.DTO
{
    public class CartaoDTO
    {
        public string Numero { get; set; }
        public double Saldo { get; set; }
        public List<ExtratoDTO> Extrato;
    }
}