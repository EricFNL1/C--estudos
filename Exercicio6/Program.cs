using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira o fatorial: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int fatorial = 1;

        for (int i = 1; i <= num; i++)
        {
            fatorial *= i; 
        }

        Console.WriteLine("O fatorial de " + num + " é: " + fatorial);
    }
}
