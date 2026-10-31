using System;

class Program

{
    static string LeerTexto(string mensaje)
    {
        Console.Write(mensaje);
        return Console.ReadLine()?.Trim() ?? "";
    }

    static string GenerarUsuario(string nombre, string apellido)
    {
        return nombre.Substring(0, 1).ToLower() + apellido.ToLower();
    }

    static bool ValidarClave(string clave)
    {
        return clave.Length >= 8 && !clave.Contains(" ");
    }

    static void Main()
    {
        string nombre = LeerTexto("Nombre: ");
        string apellido = LeerTexto("Apellido: ");
        string clave = LeerTexto("Clave: ");

        if (nombre.Length == 0 || apellido.Length == 0)
        {
            Console.WriteLine("El nombre y el apellido no pueden estar vacíos.");
            return;
        }

        string usuario = GenerarUsuario(nombre, apellido);
        bool claveValida = ValidarClave(clave);

        Console.WriteLine($"Usuario: {usuario}");
        Console.WriteLine($"Clave válida: {claveValida}");


      




    }
}



