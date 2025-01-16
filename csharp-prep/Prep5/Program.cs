using System;
using System.Formats.Asn1;
using System.Globalization;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your username:");
        string username = Console.ReadLine();
        return username;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your number:");
        int number = int.Parse(Console.ReadLine());
        return number;  
    }
    static int SquareNumber(int userInput)
    {
        int numberSquared = userInput * userInput;
        return numberSquared;
    }
    static void DisplayResult(string inputName, int inputNumber)
    {
        Console.WriteLine($"{inputName}, the square of your number is {inputNumber}.");
    }
}