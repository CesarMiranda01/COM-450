using System;
using Xunit;

namespace ejercicio2.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CalcularAreaCirculo_RadioPositivo_DebeCalcularCorrectamente()
        {
            // Arrange
            double radio = 5;

            // Act
            double resultado = Program.CalcularAreaCirculo(radio);

            // Assert
            Assert.Equal(Math.PI * Math.Pow(radio, 2), resultado);
        }

        [Fact]
        public void CalcularAreaCirculo_RadioCero_DebeLanzarExcepcion()
        {
            // Arrange
            double radio = 0;

            // Act y Assert
            Assert.Throws<ArgumentException>(() => Program.CalcularAreaCirculo(radio));
        }

        [Fact]
        public void CalcularAreaCirculo_RadioNegativo_DebeLanzarExcepcion()
        {
            // Arrange
            double radio = -3;

            // Act y Assert
            Assert.Throws<ArgumentException>(() => Program.CalcularAreaCirculo(radio));
        }

        [Fact]
        public void CalcularAreaCirculo_RadioGrande_DebeCalcularCorrectamente()
        {
            // Arrange
            double radio = 1000;

            // Act
            double resultado = Program.CalcularAreaCirculo(radio);

            // Assert
            Assert.Equal(Math.PI * Math.Pow(radio, 2), resultado);
        }

        [Fact]
        public void CalcularAreaCirculo_RadioDecimal_DebeCalcularCorrectamente()
        {
            // Arrange
            double radio = 3.5;

            // Act
            double resultado = Program.CalcularAreaCirculo(radio);

            // Assert
            Assert.Equal(Math.PI * Math.Pow(radio, 2), resultado);
        }
    }
}
