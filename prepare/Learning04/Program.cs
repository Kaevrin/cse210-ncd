using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Math math = new Math("John Freeman", "Calculometry", "Chapter 7", "Problems 5-18");
        math.GetHomeworkList();
        Console.WriteLine();
        Writing writing = new Writing("Ava Crowther", "Historic Pickling", "Pickled Watermelon");
        writing.GetWritingInformation();

    }
}