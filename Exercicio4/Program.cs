using System;

class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        int maior = 0;

        while (i != 3)
        {
            Console.WriteLine("Insira o Número:");
            int num = Convert.ToInt32(Console.ReadLine());
            i++;

            if (num > maior)
            {
                maior = num; 
            }

            Console.WriteLine("O maior número até agora é: " + maior);
        }

        Console.WriteLine("O maior número inserido foi: " + maior);
    }
}
