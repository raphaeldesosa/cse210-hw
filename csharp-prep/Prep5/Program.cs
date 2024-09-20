using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int SquaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, SquaredNumber);
    }    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string username = Console.ReadLine();
        return username;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;

    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;

    }

    static void DisplayResult(string username, int square )
    {
        Console.WriteLine($"{username}, the square of your number is {square}");
    }



    
}