using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira a palavra: ");
        
        // Lê a entrada do usuário e armazena na variável 'palavra'
        string palavra = Console.ReadLine();
        
        // Remove espaços e converte para minúsculas para garantir que a comparação seja correta
        string palavraNormalizada = palavra.Replace(" ", "").ToLower();

        // Inverte a palavra
        char[] arr = palavraNormalizada.ToCharArray();
        Array.Reverse(arr);
        string palavraInvertida = new string(arr);

        // Verifica se a palavra é um palíndromo
        if (palavraNormalizada == palavraInvertida)
        {
            Console.WriteLine("A palavra é um palíndromo.");
        }
        else
        {
            Console.WriteLine("A palavra não é um palíndromo.");
        }
    }
}
