using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        string replay;
        do
        {
            Random randomGenerator = new Random();
            int secret = randomGenerator.Next(1, 11);
            int answer;
            int guesses = 0;
            do
            {
                Console.WriteLine("What is your guess?");
                string answerString = Console.ReadLine();
                answer = int.Parse(answerString);   
                guesses++;  
            } while (answer != secret);
            Console.WriteLine($"The answer is {secret}");
            Console.WriteLine($"Guesses taken: {guesses}");
            Console.WriteLine("Do you want to play again?");
            replay = Console.ReadLine();
        }   while (replay == "yes");

        Console.WriteLine("Goodbye!");


    }
}