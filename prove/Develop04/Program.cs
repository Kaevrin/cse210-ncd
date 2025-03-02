using System;
using System.Net;
using System.Net.Quic;
using System.Threading.Tasks;

class Program
{

    static async Task Main(string[] args) {
        string timeString;
        string response;
        int time = 0; // I have no idea why, but I have to assign something to time 
                    // or else the Breathing constructor calls it an unsigned variable

        while(true) {

            Console.Clear();
            Console.WriteLine("Welcome to the Mindfullness program, please select an option:\n1.Breathing\n2.Listing\n3.Reflection\n4.Exit");
            response = Console.ReadLine();

            if (response == "1" || response == "2" || response == "3") {
                Console.WriteLine("How long do you want it to go for?(Recommended 60 seconds)");
                timeString = Console.ReadLine();
                while (!int.TryParse(timeString, out time) || time <= 0) {
                Console.WriteLine("Invalid input. Please enter a valid positive number:");
                timeString = Console.ReadLine();
                }
            }
            else if (response == "4") {
                Console.WriteLine("Goodbye!");
                break;
            }

            if (response == "1") {
                Breathing breathing = new Breathing(time);
                await breathing.Run();
            }
            else if (response == "2") {
                Listing listing = new Listing(time);
                await listing.Run();
            }
            else if (response == "3") {
                Reflection reflection = new Reflection(time); 
                await reflection.Run();
            }
        }

    }
}