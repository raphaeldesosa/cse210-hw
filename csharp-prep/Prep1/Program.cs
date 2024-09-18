using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Write your First Name: ");
        string first = Console.ReadLine();

        Console.Write("Write your Last Name: ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first}. ");

    }
}