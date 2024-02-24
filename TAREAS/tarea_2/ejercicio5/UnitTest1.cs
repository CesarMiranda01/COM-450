using System;
using Xunit;

namespace ejercicio5.Tests
{
    public class ProgramTests
    {
        // Caso de prueba 1: Cadena vacía. Debe retornar una cadena vacía.
        [Fact]
        public void EliminarEspaciosBlanco_CadenaVacia_DebeRetornarCadenaVacia()
        {
            // Arrange
            string cadena = "";

            // Act
            string resultado = Program.EliminarEspaciosBlanco(cadena);

            // Assert
            Assert.Equal("", resultado);
        }

        // Caso de prueba 2: Cadena sin espacios en blanco. Debe retornar la cadena original.
        [Fact]
        public void EliminarEspaciosBlanco_CadenaSinEspacios_DebeRetornarCadenaOriginal()
        {
            // Arrange
            string cadena = "CadenaSinEspacios";

            // Act
            string resultado = Program.EliminarEspaciosBlanco(cadena);

            // Assert
            Assert.Equal(cadena, resultado);
        }

        // Caso de prueba 3: Cadena con espacios al inicio y al final. Debe eliminar los espacios en blanco.
        [Fact]
        public void EliminarEspaciosBlanco_CadenaConEspaciosAlInicioYFin_DebeEliminarEspacios()
        {
            // Arrange
            string cadena = "   CadenaConEspacios   ";

            // Act
            string resultado = Program.EliminarEspaciosBlanco(cadena);

            // Assert
            Assert.Equal("CadenaConEspacios", resultado);
        }

        // Caso de prueba 4: Cadena con espacios entre palabras. Debe eliminar los espacios entre las palabras.
        [Fact]
        public void EliminarEspaciosBlanco_CadenaConEspaciosEntrePalabras_DebeEliminarEspacios()
        {
            // Arrange
            string cadena = "Cadena   Con   Espacios";

            // Act
            string resultado = Program.EliminarEspaciosBlanco(cadena);

            // Assert
            Assert.Equal("Cadena Con Espacios", resultado);
        }

        // Caso de prueba 5: Cadena con múltiples espacios consecutivos. Debe eliminar los espacios múltiples.
        [Fact]
        public void EliminarEspaciosBlanco_CadenaConMultiplesEspaciosConsecutivos_DebeEliminarEspacios()
        {
            // Arrange
            string cadena = "Cadena   con   múltiples   espacios   consecutivos";

            // Act
            string resultado = Program.EliminarEspaciosBlanco(cadena);

            // Assert
            Assert.Equal("Cadena con múltiples espacios consecutivos", resultado);
        }
    }
}
