using DesafioTDD.Dependencies;
using DesafioTDD.DTO;
using DesafioTDD.Models;
using Xunit;
using Xunit.Abstractions;

namespace ATMTestes
{
    public class HabilitarCartaoControllerTest
    {
        ITestOutputHelper _output;

        public HabilitarCartaoControllerTest(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        [Trait("Categoria", "TipoRetorno")]
        public void TestaValidarCartao()
        {
            //Arrange
            var method = new Metodos();
            //Este metodo já recebe dados do cartão filtrados pelo form do front
            var cartaoTemp = new HabilitarCartaoDTO {Numero = "1895638730565266", Senha = "3432"};
            var numeroEsperado = cartaoTemp.Numero;
            var senhaEsperada = cartaoTemp.Senha;

            //Act
            var resultado = method.AtivarCartao(cartaoTemp);

            //Assert
            //Verifica se retornou a classe certa para salvar no banco de dados
            Assert.IsType<Cartao>(resultado);
            //Checa se os valores se mantiveram corretos na conversão
            Assert.Equal(numeroEsperado, resultado.Numero);
            Assert.Equal(senhaEsperada, resultado.Senha);
        }
        
    }
}