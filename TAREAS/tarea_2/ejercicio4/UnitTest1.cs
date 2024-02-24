using Xunit;

namespace ejercicio4.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ContarOcurrenciasSubcadena_CadenaVacia_DebeRetornarCero()
        {
            // Arrange
            string cadena = "";
            string subcadena = "abc";

            // Act
            int resultado = Program.ContarOcurrenciasSubcadena(cadena, subcadena);

            // Assert
            Assert.Equal(0, resultado);
        }

        [Fact]
        public void ContarOcurrenciasSubcadena_SinOcurrencias_DebeRetornarCero()
        {
            // Arrange
            string cadena = "abcdefgh";
            string subcadena = "xyz";

            // Act
            int resultado = Program.ContarOcurrenciasSubcadena(cadena, subcadena);

            // Assert
            Assert.Equal(0, resultado);
        }

        [Fact]
        public void ContarOcurrenciasSubcadena_UnaOcurrencia_DebeRetornarUno()
        {
            // Arrange
            string cadena = "abcdefgh";
            string subcadena = "bcd";

            // Act
            int resultado = Program.ContarOcurrenciasSubcadena(cadena, subcadena);

            // Assert
            Assert.Equal(1, resultado);
        }

        [Fact]
        public void ContarOcurrenciasSubcadena_MultiplesOcurrencias_DebeRetornarCorrectamente()
        {
            // Arrange
            string cadena = "abababab";
            string subcadena = "ab";

            // Act
            int resultado = Program.ContarOcurrenciasSubcadena(cadena, subcadena);

            // Assert
            Assert.Equal(4, resultado);
        }

        [Fact]
        public void ContarOcurrenciasSubcadena_SubcadenaEnOtraPalabra_DebeRetornarCorrectamente()
        {
            // Arrange
            string cadena = "abcd abcde abc";
            string subcadena = "abc";

            // Act
            int resultado = Program.ContarOcurrenciasSubcadena(cadena, subcadena);

            // Assert
            Assert.Equal(3, resultado);
        }
    }
}
