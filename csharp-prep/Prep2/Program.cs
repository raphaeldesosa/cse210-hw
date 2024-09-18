using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string Grade = Console.ReadLine();
        int number = int.Parse(Grade);

        string Letter = "";

        if (number >= 90)
        {
            Letter = "A";
        }
        else if (number >= 80)
        {
            Letter = "B";
        }
        else if (number >= 70)
        {
            Letter = "C";
        }
        else if (number >= 60)
        {
            Letter = "D";
        }
        else
        {
            Letter = "F";
        }

        Console.WriteLine($"Your grade is {Letter}");

        if (number > 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Try harder next time");
        }


        
    }
}