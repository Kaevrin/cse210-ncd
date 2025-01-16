using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int numberInput = 1;
        string userInput;
        int sum;
        List<int> numbers = new List<int>();
            while (numberInput != 0)
            {
                Console.WriteLine("Enter a number:");
                userInput = Console.ReadLine();
                numberInput = int.Parse(userInput);
                if (numberInput != 0)
                {
                    numbers.Add(numberInput);
                }
            }
        Console.WriteLine($"Number of items in List: {numbers.Count}");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        sum = numbers.Sum();
        Console.WriteLine($"Total sum:{sum}");
        int average = sum / numbers.Count();
        Console.WriteLine($"The average: {average}");
        int highest = numbers.Max();
        Console.WriteLine($"The highest number: {highest}");
        int lowest = numbers.Min();
        Console.WriteLine($"The lowest number: {lowest}");

    }
}