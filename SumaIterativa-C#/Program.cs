using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa el primer número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        int suma = 0;

        for (int i = 0; i < num2; i++)
        {
            suma += num1;
        }

        Console.WriteLine($"La suma de {num1} y {num2} es: {suma}");
    }
}