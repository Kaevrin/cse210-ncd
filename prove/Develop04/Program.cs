using System;
using System.Net;
using System.Threading.Tasks;

class Program
{

    static async Task Main(string[] args)
    {
        string response;
        Console.WriteLine("Welcome to the Mindfullness program, please select an option:\n1.Breathing\n2.Listing\n3.Reflection");
        response = Console.ReadLine();
        if (response == "1") {
            Breathing breathing = new Breathing("Test", 8);
            await breathing.Run();
        }
        else if (response == "2") {

        }
        else if (response == "3") {

        }
        else {
            Console.WriteLine("Error, invalid choice.");
        }

    }
}