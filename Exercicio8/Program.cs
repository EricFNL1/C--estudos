using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe um número para verificar se ele é primo: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num <= 1)
        {
            Console.WriteLine("O número " + num + " não é primo");
        }
        else if (EhPrimo(num))
        {
            Console.WriteLine("O número " + num + " é primo");
        }
        else
        {
            Console.WriteLine("O número " + num + " não é primo");
        }
    }

    static bool EhPrimo(int num)
    {
        if (num <= 1) return false;
        if (num == 2) return true; // 2 é o único número primo par

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false; // Encontrou um divisor, então não é primo
            }
        }
        return true; // Se não encontrou nenhum divisor, é primo
    }
}
