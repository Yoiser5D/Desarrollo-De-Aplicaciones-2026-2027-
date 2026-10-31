
using System;

class Program
{
    static double CalcularTotal(double subtotal, bool esFrecuente)
    {
        if (esFrecuente)
        {
            subtotal = subtotal - (subtotal * 0.10);
        }

        double itbis = subtotal * 0.18;
        double total = subtotal + itbis;

        return total;
    }

    static void MostrarFactura(string cliente, double total)
    {
        Console.WriteLine("Cliente: " + cliente);
        Console.WriteLine("Total a pagar: " + total);
    }

    static void Main()
    {
        Console.Write("Nombre del cliente: ");
        string cliente = Console.ReadLine();

        Console.Write("Subtotal de la venta: ");
        double subtotal = Convert.ToDouble(Console.ReadLine());

        Console.Write("es frecuente si/no: ");
        string respuesta = Console.ReadLine().ToLower();

        bool esFrecuente = respuesta == "si";

        double total = CalcularTotal(subtotal, esFrecuente);

        MostrarFactura(cliente, total);
    }
}
