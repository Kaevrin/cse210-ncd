using System;

class Program
{
    static void Main(string[] args) {
        Reference reference = new Reference("Mosiah",23,21);
        Scripture scripture = new Scripture(reference, "Nevertheless the Lord seeth fit to chasten his people; yea, he trieth their patience and their faith.");
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayContent());
        Console.WriteLine("Press Enter to hide some words.");
        do {
            Console.ReadLine(); 
            scripture.HideWords(3);
            Console.WriteLine(scripture.GetDisplayContent()); 
        } while (scripture.AllHidden() == false);
        Console.WriteLine("The next input will reveal the whole scripture.");
        Console.ReadLine();
        scripture.ShowAll();
        Console.WriteLine(scripture.GetDisplayContent());
    }
}