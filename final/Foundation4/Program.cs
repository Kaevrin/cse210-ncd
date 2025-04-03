using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        Tempcode tempcode = new Tempcode(new DateTime(2025, 03, 09), 50, 30);
        Console.WriteLine(tempcode.GetSummary());
    }
}