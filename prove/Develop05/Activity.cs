public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}");
        Console.WriteLine(_description);
        Console.WriteLine("How long, in seconds would you like for your session?");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int duration))
        {
            _duration = duration;
        }
        else
        {
            Console.WriteLine("Invalid input. Setting default duration to 30s.");
            _duration = 30;
        }

        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
        
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Great Job!");
        Console.WriteLine($"You have completed {_name} in {_duration} seconds");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b-");
            Thread.Sleep(205);
            Console.Write("\b\\");
            Thread.Sleep(250);
            Console.Write("\b|");
            Thread.Sleep(250);
            Console.Write("\b");
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for ( int i = seconds; i > 0; i--)
        {
            Console.Write("\r" + i + "");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

}

