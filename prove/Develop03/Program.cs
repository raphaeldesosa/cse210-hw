using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Doctrine and Covenants", 1, 37, 38);
        string scriptureText = "Search these commandments, for they are true and faithful, and the prophecies and promises which are in them shall all be fulfilled. What I the Lord have spoken, I have spoken, and I excuse not myself; and though the heavens and the earth pass away, my word shall not pass away, but shall all be fulfilled, whether by mine own voice or by the voice of my servants, it is the same.";
        Scripture scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.isCompletelyHidden())
            {
                Console.WriteLine("All words completely hidden. Program will now close");
                break;
            }

            Console.WriteLine("Press 'Enter' to hide more words or type 'quit' to exit");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(4);
        }
    }
}