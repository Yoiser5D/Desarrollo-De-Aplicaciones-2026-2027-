using System;

class Cuenta
{
  
    static string GenerarUsuario(string nombre, string apellido)
    {
        return (nombre.Substring(0, 1) + apellido).ToLower();
    }


    static bool ClaveValida(string clave, string usuario)
    {
        string apellido = usuario.Substring(1);
        return clave.Length >= 8 && clave.ToLower().Contains(apellido);
    }

    static void MostrarCuenta(string usuario, string clave, bool valida)
    {
        Console.WriteLine("Usuario: " + usuario);
        Console.WriteLine("Clave: " + clave);
        Console.WriteLine("Clave válida: " + (valida ? "Sí" : "No"));
    }

    static void Main()
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Apellido: ");
        string apellido = Console.ReadLine();

        Console.Write("Clave: ");
        string clave = Console.ReadLine();

        string usuario = GenerarUsuario(nombre, apellido);
        bool valida = ClaveValida(clave, usuario);

        Console.WriteLine();
        MostrarCuenta(usuario, clave, valida);
    }
}
