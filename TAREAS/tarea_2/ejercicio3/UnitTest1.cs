// UnitTest1.cs
using System;
using Xunit;

namespace ejercicio3.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void EsNumeroPrimo_NumeroPrimo_DebeRetornarTrue()
        {
            // Arrange
            int numero = 7;

            // Act
            bool resultado = Program.EsNumeroPrimo(numero);

            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void EsNumeroPrimo_NumeroNoPrimo_DebeRetornarFalse()
        {
            // Arrange
            int numero = 6;

            // Act
            bool resultado = Program.EsNumeroPrimo(numero);

            // Assert
            Assert.False(resultado);
        }

        [Fact]
        public void EsNumeroPrimo_NumeroNegativo_DebeLanzarExcepcion()
        {
            // Arrange
            int numero = -3;

            // Act y Assert
            Assert.Throws<ArgumentException>(() => Program.EsNumeroPrimo(numero));
        }

        [Fact]
        public void EsNumeroPrimo_NumeroGrande_DebeRetornarTrue()
        {
            // Arrange
            int numero = 997;

            // Act
            bool resultado = Program.EsNumeroPrimo(numero);

            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void EsNumeroPrimo_NumeroCero_DebeRetornarFalse()
        {
            // Arrange
            int numero = 0;

            // Act
            bool resultado = Program.EsNumeroPrimo(numero);

            // Assert
            Assert.False(resultado);
        }
    }
}
