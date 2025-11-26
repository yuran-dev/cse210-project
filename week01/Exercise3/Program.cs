using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain;

        do
        {
            // Random Number between 1 to 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101); // 1 a 100
            int guess = 0;
            int attempts = 0;

            Console.WriteLine("Guess the magic number between 1 and 100!");

            // Loop fo guess
            while (guess != magicNumber)
            {
                Console.Write("Enter your guess: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }

                attempts++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {attempts} attempts! Congratulations!");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");

        Console.WriteLine("Thanks for playing!");
    }
}
