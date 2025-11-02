using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(favoriteNumber);

        DisplayResult(userName, squaredNumber);
    }

    // Função que exibe a mensagem de boas-vindas
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Função que pede e retorna o nome do usuário
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    // Função que pede e retorna o número favorito do usuário
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Função que retorna o quadrado do número
    static int SquareNumber(int number)
    {
        return number * number;
    }

    // Função que exibe o resultado final
    static void DisplayResult(string name, int squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}");
    }
}
