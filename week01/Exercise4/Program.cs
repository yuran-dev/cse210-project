using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Inout numbers
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);

        // Calculate SUM
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Calcular média
        double average = (numbers.Count > 0) ? (double)sum / numbers.Count : 0;

        // bIGHEST NUMBER
        int max = (numbers.Count > 0) ? numbers[0] : 0;
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        // The results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}
