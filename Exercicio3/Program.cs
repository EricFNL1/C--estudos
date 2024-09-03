using System;


class Program{
    static void Main(string[] args){

        Console.WriteLine("Insira o número: ");
        int num = Convert.ToInt32(Console.ReadLine());

        int primo = num % 2;

        if (primo == 0){
            Console.WriteLine("É primo");
        }
        else{
            Console.WriteLine("Não é Primo");
        }


    }

}