using System;
using DesafioTDD.Data;
using Xunit;
using DesafioTDD.Dependencies;
using System.Collections.Generic;
using DesafioTDD.Models;
using DesafioTDD.DTO;
using Xunit.Abstractions;

namespace ATMTestes
{
    public class AdminControllerTest
    {
        ITestOutputHelper _output;

        public AdminControllerTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        [Trait("Categoria", "SetNotas")]
        public void TestaSetNotas()
        {
            //Acessa o tabela caixa e deve retornar objecto not null
            //Arrange
            var method = new Metodos();

            Caixa caixa = new Caixa{Ced100 = 100, Ced50 = 100, Ced20 = 100, Ced10 = 100, Total = 0};
            caixa.Total = (caixa.Ced100 * 100) + (caixa.Ced50 * 50) + (caixa.Ced20 * 20) + (caixa.Ced10 * 10);
            CaixaDTO caixaTemp = new CaixaDTO{Ced100 = 50, Ced50 = 50, Ced20 = 50, Ced10 = 50, Total = 0};
            caixaTemp.Total = (caixaTemp.Ced100 * 100) + (caixaTemp.Ced50 * 50) + (caixaTemp.Ced20 * 20) + (caixaTemp.Ced10 * 10);
            
            var expectativa = caixaTemp.Total;
            //Act
            method.SetNotas(caixa, caixaTemp);
            var resultado = caixa.Total;
            //Assert
            _output.WriteLine($"Expectativa: {expectativa}, Resultado: {resultado}");
            Assert.Equal(expectativa, resultado);
        }
    }
}