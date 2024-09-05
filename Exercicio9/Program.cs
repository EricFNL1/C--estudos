using System;

class Program{

    static void Main(string[] args){

        int totalnotas = 0;
       

        Console.WriteLine("Insira o quantos notas serão inseridas: ");
        int notas = Convert.ToInt32(Console.ReadLine());

        for(int i = 0; i < notas; i++) {
            Console.WriteLine("Insira a nota: ");
            int dadosnota = Convert.ToInt32(Console.ReadLine());
            totalnotas += dadosnota;
        }
         float calcfinal = totalnotas / notas;
        Console.WriteLine("Média final: " +calcfinal);
    }

}