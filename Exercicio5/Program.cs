using System;

class program{

    static void Main(string[] args){
        Console.WriteLine("Insira o primeiro valor: ");
        float valor1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insira o segundo valor: ");
        float valor2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insira a operação que deseja realizar, 1 para somar, 2 para subtrair, 3 para multiplicar, 4 para dividir \n");
        int operação = Convert.ToInt32(Console.ReadLine());

        if (operação == 1){
            float soma = valor1 + valor2;
            Console.WriteLine("Valor: " + soma);
        }
        if (operação == 2){
            float subtrair = valor1 - valor2;
            Console.WriteLine("Valor: " + subtrair);
        }
        if (operação == 3){
            float multiplicar = valor1 * valor2;
            Console.WriteLine("Valor: " + multiplicar);
        }
        if (operação == 4){
            float divisão = valor1 / valor2;
            Console.WriteLine("Valor: " + divisão);
        }
    }
}