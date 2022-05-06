using DesafioTDD.Dependencies;
using DesafioTDD.DTO;
using Xunit;
using Xunit.Abstractions;

namespace ATMTestes
{
    public class MeuCartaoControllerTest
    {
        ITestOutputHelper _output;

        public MeuCartaoControllerTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Theory(DisplayName = "Contagem de notas")]
        [Trait("Categoria", "Contagem")]
        //O front faz a validação via form para aceitar a entrada máxima de 500
        //e valores múltiplos de 10
        [InlineData(500)]
        [InlineData(380)]
        [InlineData(160)]
        [InlineData(40)]
        [InlineData(10)]
        public void TestaContagemNotas(double valor)
        {
            //Assert
            var method = new Metodos();
            var esperado = new CaixaDTO{Ced100 = 0, Ced50 = 0, Ced20 = 0, Ced10 = 0};
            
            if(valor == 500)
            {
                esperado.Ced100 = 5;
            }
            if(valor == 380)
            {
                esperado.Ced100 = 3;
                esperado.Ced50 = 1;
                esperado.Ced20 = 1;
                esperado.Ced10 = 1;
            }
            if(valor == 160)
            {
                esperado.Ced100 = 1;
                esperado.Ced50 = 1;
                esperado.Ced10 = 1;
            }
            if(valor == 40)
            {
                esperado.Ced20 = 2;
            }
            if(valor == 10)
            {
                esperado.Ced10 = 1;
            }
            //Act 
            var resultado = method.ContaNotas(valor);
            //Assert
            Assert.Equal(esperado.Ced100, resultado.Ced100);
            Assert.Equal(esperado.Ced50, resultado.Ced50);
            Assert.Equal(esperado.Ced20, resultado.Ced20);
            Assert.Equal(esperado.Ced10, resultado.Ced10);
        }
    }
}