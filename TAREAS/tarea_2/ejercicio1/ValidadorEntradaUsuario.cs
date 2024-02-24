using System;
using System.Text.RegularExpressions;

public class ValidadorEntradaUsuario
{
    public bool ValidarNombre(string nombre)
    {
        return !string.IsNullOrEmpty(nombre) && nombre.Length > 3 && nombre.Length < 30;
    }

    public bool ValidarCorreoElectronico(string correoElectronico)
    {
        // Utilizamos una expresión regular simple para verificar el formato del correo electrónico.
        string patronCorreoElectronico = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";
        return !string.IsNullOrEmpty(correoElectronico) && Regex.IsMatch(correoElectronico, patronCorreoElectronico);
    }

    public bool ValidarContrasena(string contrasena)
    {
        // Validación de longitud mínima y presencia de caracteres especiales.
        return !string.IsNullOrEmpty(contrasena) && contrasena.Length >= 5 && ContieneCaracterEspecial(contrasena);
    }

    private bool ContieneCaracterEspecial(string entrada)
    {
        // Verifica si la entrada contiene al menos un carácter especial.
        return !string.IsNullOrEmpty(entrada) && entrada.Any(c => !char.IsLetterOrDigit(c));
    }
}
