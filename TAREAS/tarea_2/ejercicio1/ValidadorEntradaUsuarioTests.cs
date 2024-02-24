using Xunit;
using System.Linq; // Agrega esta línea para utilizar el método Any

public class ValidadorEntradaUsuarioTests
{
    [Fact]
    public void ValidarNombre_NombreValido_RetornaTrue()
    {
        // Arrange
        var validador = new ValidadorEntradaUsuario();

        // Act
        var resultado = validador.ValidarNombre("JohnDoe");

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void ValidarNombre_NombreInvalido_RetornaFalse()
    {
        // Arrange
        var validador = new ValidadorEntradaUsuario();

        // Act
        var resultado = validador.ValidarNombre("Jo");

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void ValidarCorreoElectronico_CorreoElectronicoValido_RetornaTrue()
    {
        // Arrange
        var validador = new ValidadorEntradaUsuario();

        // Act
        var resultado = validador.ValidarCorreoElectronico("test@example.com");

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void ValidarCorreoElectronico_CorreoElectronicoInvalido_RetornaFalse()
    {
        // Arrange
        var validador = new ValidadorEntradaUsuario();

        // Act
        var resultado = validador.ValidarCorreoElectronico("invalid-email");

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void ValidarContrasena_ContrasenaValida_RetornaTrue()
    {
        // Arrange
        var validador = new ValidadorEntradaUsuario();

        // Act
        var resultado = validador.ValidarContrasena("P@ssword");

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void ValidarContrasena_ContrasenaInvalida_RetornaFalse()
    {
        // Arrange
        var validador = new ValidadorEntradaUsuario();

        // Act
        var resultado = validador.ValidarContrasena("weak");

        // Assert
        Assert.False(resultado);
    }
}
