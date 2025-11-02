using System;

class Program
{
    static void Main(string[] args)
    {
        // Grade percentage
        Console.Write("Please, Enter your grade percentage: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        // Variables
        string letter = "";
        string sign = "";

        // The equivalent letter
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter != "A" && letter != "F")
        {
            int lastDigit = grade % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // The result
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep trying! You can improve next time.");
        }
    }
}
