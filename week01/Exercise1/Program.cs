using System;

class Program
{
    static void Main(string[] args)
    {
        // First name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // The result
        Console.WriteLine();
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}
