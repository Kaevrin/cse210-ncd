using System;

class Program
{
    static void Main(string[] args)
    {
        string adjective = GetAdjective();
        string noun = GetNoun();

        int number = Multiply(3,4);

        Console.WriteLine($"I looked out the window and saw {number} {adjective} {noun}");
    }

    static int Multiply(int number1, int number2)
    {
        int product = number1 * number2;
        return product;
    }

    static string GetAdjective()
    {
        string adjective = "yellow";
        return adjective;
    }
    static string GetNoun()
    {
        string noun = "bird";
        return noun;
    }
}  