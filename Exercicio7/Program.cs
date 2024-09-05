using System;

class Program{

static void Main(string[] args){
    Console.WriteLine("Insira um número para ver seu tabuada");
    int num = Convert.ToInt32(Console.ReadLine());

    for(int i = 1; i <= 10; i++){
        int tabuada = num * i;
        Console.WriteLine("" + tabuada);
    }

}


}