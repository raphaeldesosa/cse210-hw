using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("Choose an option from 1-5");
            Console.WriteLine("1. Write a New Entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3.Save the journal to file");
            Console.WriteLine("4.Load the journal from a file");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            if  (choice == "1")
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write("Your Response: ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), prompt, response);
                myJournal.AddEntry(newEntry);
            }
            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }
            else if ( choice == "3")
            {
                Console.Write("Enter a filename to save the journal: ");
                string saveFilename = Console.ReadLine();
                myJournal.SaveToFile(saveFilename);
            }
            else if (choice == "4")
            {
                Console.Write("Enter a filename: ");
                string loadFilename = Console.ReadLine();
                myJournal.LoadFromFile(loadFilename);
            }
            else if (choice == "5")
            {
                exit = true;
                Console.WriteLine("goodbye, hope to see you again");
            }
            else
            {
                Console.WriteLine("Invalid option");
            
            }

            

        }
    }
}