using System;

class Program
{
    static int SumaIterativa(int n)
    {
        int suma = 0;
        while (n > 9)
        {
            suma += n % 10;
            n /= 10;
        }
        return suma + n;
    }

    static void Main(string[] args)
    {
        Console.Write("Ingresa un número entero: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            int resultado = SumaIterativa(n);
            Console.WriteLine($"La suma de los dígitos de {n} es: {resultado}");
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debes ingresar un número entero.");
        }
    }
}