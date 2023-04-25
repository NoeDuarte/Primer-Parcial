using Xunit;
using primer_parcial_unit_test_procesador_matematico;

namespace primer_parcial_unit_test_procesador_matematico_test
{
    public class MayorTest
    {
        [Fact]
        public void Mayor_ConValoresValidos_ConResultadoValidos()
        {
            // Arrange
            Mayor mayor = new Mayor();
            int resultadoEsperado = 5;

            //Act
            int resultadoReal = mayor.CalcularMayor(5, 4);

            //Assert
            Assert.Equal(resultadoReal, resultadoEsperado);
                        
        }

        [Fact]
        public void Mayor_ConValorInvalidos_ConResultadoInvalido()
        {
            // Arrange
            Mayor mayor = new Mayor();
            int resultadoEsperado = 9;

            //Act
            int resultadoReal = mayor.CalcularMayor(5, 4);

            //Assert
            Assert.Equal(resultadoReal, resultadoEsperado);

        }

        [Theory]
        [InlineData(1, 7, 7)]
        [InlineData(9, 2, 9)]
        [InlineData(5, 3, 5)]

        public void Mayor_ConMultiplesValoresValidos_DevuelveValido(int a, int b, int resultadoEsperado)
        {
            //Arrange
            Mayor mayor = new Mayor();

            //Act
            int resultadoReal = mayor.CalcularMayor(a, b);

            //Assert
            Assert.Equal(resultadoEsperado, resultadoReal);
        }

    }
}
