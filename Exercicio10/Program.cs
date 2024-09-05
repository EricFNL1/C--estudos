using System;


class Program{

    static void Main(string[] args){
        Console.WriteLine("Insira a temepartura em C°: ");
        int celsius = Convert.ToInt32(Console.ReadLine());

        double conversao = (celsius * 1.8) + 32;

        Console.WriteLine("" + conversao);
    }

}