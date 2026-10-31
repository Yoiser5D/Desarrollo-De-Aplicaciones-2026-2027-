
using System;

class Program
{
    static decimal CalcularTotal(decimal subtotal, bool frecuente)
    {
        if (frecuente)
            subtotal -= subtotal * 0.10m;

        return subtotal * 1.18m;
    }

    static void Main()
    {
        Console.Write("Cliente: ");
        string cliente = Console.ReadLine();

        Console.Write("Subtotal: ");
        decimal subtotal = decimal.Parse(Console.ReadLine());

        Console.Write("¿Cliente frecuente? (s/n): ");
        bool frecuente = Console.ReadLine().ToLower() == "si";

        Console.WriteLine($"Cliente: {cliente}");
        Console.WriteLine($"Total a pagar: {CalcularTotal(subtotal, frecuente):0.##}");
    }
}
