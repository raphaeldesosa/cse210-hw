using System;

class Program
{
    static void Main(string[] args)
    {
        Random random_generator = new Random();
        int magic_number = random_generator.Next(1, 100);

        int guess = -1;

        while (guess != magic_number)
        {
            Console.Write("What's the magic number? ");
            guess = int.Parse(Console.ReadLine());

            if (magic_number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magic_number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        }    
    }
}