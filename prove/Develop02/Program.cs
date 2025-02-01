using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Entry entry = new Entry();
        Boolean running = true;
        string input = "";
        List<Journal> journal = new List<Journal>();
        //Running loop begins here
        do 
        {
            //Troubleshooting line for monitoring the variable
            Console.WriteLine($"Input is \"{input}\"");
            //Display of possible inputs for user navigation
            if (input == "")
            {
                Console.WriteLine("\nWelcome to the Journal");
                Console.WriteLine("Options:\nWrite\nDelete\nAdd\nDisplay\nClear\nExit\n");
            }
            input = Console.ReadLine();
            if (input == "Write")
            {
                entry.Input();
                input = "";
            }
            else if (input == "Delete")
            {
                entry.Delete();
                input = "";
            }
            else if (input == "Add")
            {
                journal.Add(new Journal(entry.GetEntry()));
                input = "";
            }
            else if (input == "Display")
            {
                Console.WriteLine("Journal Entries:");
                foreach (var line in journal)
                {
                    Console.WriteLine(line);
                }
                input = "";
            }
            else if (input == "Exit")
            {
                Console.WriteLine("Goodbye");
                running = false;
                break;
            }
            else
            {
                Console.WriteLine("Invalid input");
                input = "";
            }
        } while(running == true);
    }        
}