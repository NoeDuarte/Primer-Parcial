using Xunit;
using primer_parcial_unit_test_procesador_matematico;

namespace primer_parcial_unit_test_procesador_matematico_test
{
    public class ProcesadorMatematicoTest
    {
        [Fact]
        public void Sumar_DosNumerosPositivos_RetornaSumas()
        {
            // Arrange
            ProcesadorMatematico sumar = new ProcesadorMatematico();
            int primerNumero = 6;
            int segundoNumero = 4;
            int resultadoEsperado = 10;

            // Act
            int resultadoObtenido = sumar.Sumar(primerNumero, segundoNumero);

            // Assert
            Assert.Equal(resultadoEsperado, resultadoObtenido);
        }

        [Fact]
        public void Sumar_DosNumerosNegativos_RetornaCero()
        {
            // Arrange
            ProcesadorMatematico sumar = new ProcesadorMatematico();
            int primerNumero = -6;
            int segundoNumero = -2;
            int resultadoEsperado = 0;

            // Act
            int resultadoObtenido = sumar.Sumar(primerNumero, segundoNumero);

            // Assert
            Assert.Equal(resultadoEsperado, resultadoObtenido);
        }

        [Fact]
        public void Dividir_DividendoPositivoYDivisorNegativo_RetornaCero()
        {
            // Arrange
            var procesador = new ProcesadorMatematico();
            int dividendo = 9;
            int divisor = -5;
            int resultadoEsperado = 0;

            // Act
            int resultadoObtenido = procesador.Dividir(dividendo, divisor);

            // Assert
            Assert.Equal(resultadoEsperado, resultadoObtenido);
        }

      

        [Fact]
        public void Dividir_DividendoNegativoYDivisorNegativo_RetornaCero()
        {
            //Arrange
            var procesador = new ProcesadorMatematico();
            var dividendo = -8;
            int divisor = -4;
            int resultadoEsperado = 0;

            // Act
            int resultadoObtenido = procesador.Dividir(dividendo, divisor);

            // Assert
            Assert.Equal(resultadoEsperado, resultadoObtenido);
        }
    }
}

