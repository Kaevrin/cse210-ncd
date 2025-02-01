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
        //List<Journal> journal = new List<Journal>();
        string prompt = "";
        List<Journal> journal = Journal.Load();
        //Running loop begins here
        do 
        {
            //Troubleshooting line for monitoring the variable
            Console.WriteLine($"Input is \"{input}\"");
            //Display of possible inputs for user navigation
            if (input == "")
            {   
                Console.WriteLine("\nWelcome to the Journal");
                Console.WriteLine("Options:\nWrite\nAdd\nDisplay\nSave\nDelete\nClear\nExit\n");
            }
            input = Console.ReadLine();
            if (input == "Write")
            {
                prompt = Prompt.GetPrompt();
                Console.WriteLine(prompt);
                entry.Input();
                input = "";
            }
            else if (input == "Add")
            {
                journal.Add(new Journal(entry.GetEntry(), prompt));
                input = "";
            }
            else if (input == "Display")
            {
                Console.WriteLine("Journal Entries:");
                for (int i = 0; i < journal.Count; i++)
                {
                    Console.WriteLine($"{i+1}: {journal[i]}");
                }
                input = "";
            }
            else if (input == "Save")
            {
                Journal.Save(journal);
                Console.WriteLine("Journal saved.");
                input = "";
            }
            else if (input == "Delete")
            {
                Console.WriteLine("Journal Entries:");
                for (int i = 0; i < journal.Count; i++)
                {
                    Console.WriteLine($"{i+1}: {journal[i]}");
                }
                input = Console.ReadLine();
                int indexToDelete;
                if (int.TryParse(input, out indexToDelete) && indexToDelete -1 >= 0 && indexToDelete -1 < journal.Count)
                {
                    journal.RemoveAt(indexToDelete - 1);
                    Console.WriteLine("Entry deleted.");

                }
                else
                {
                    Console.WriteLine("Invalid index.");
                }
                input = "";
            }
            else if (input == "Clear")
            {
                Console.WriteLine("Are you sure? Y/N");
                input = Console.ReadLine();
                if (input == "Y")
                {
                    journal.Clear();
                    Console.WriteLine("Journal cleared");
                    input = "";
                }
                else if (input == "N")
                {
                    Console.WriteLine("Canceled");
                    input = "";
                }
                else
                {
                    Console.WriteLine("Invalid input");
                    input = "Clear";
                }
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