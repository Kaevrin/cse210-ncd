using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your score?");
        string input = Console.ReadLine();
        int score = int.Parse(input);
        string gradeResult = "";
        if (score >= 90)
        {
            gradeResult = "A";
        }
        else if (score >= 80)
        {
            gradeResult = "B";;
        }
        else if (score >= 70)
        {
            gradeResult = "C";;
        }
        else if (score >= 60)
        {
            gradeResult = "D";;
        }
        else
        {
            gradeResult = "F";
        }
            Console.WriteLine($"Your grade is {gradeResult}");
        if (score >= 70)
        {
            Console.Write("You are on track!");
        }
        
        else
        {
            Console.Write("Keep up the hard work to bring it up!");
        }
    }
}