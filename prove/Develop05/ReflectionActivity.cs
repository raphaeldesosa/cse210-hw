public class ReflectionActivity : Activity
{
    private List<string> _prompt;
    private List<string> _questions;

    public ReflectionActivity(string name, string description) :base(name, description)
    {
        _prompt = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Reflect on the following: ");
        DisplayPrompt();
        
        Console.WriteLine("When you have something in mind, press enter");
        Console.ReadLine();

        Console.WriteLine("Now Consider the following questions");
        ShowCountDown(5);
        DisplayQuestions(); ShowSpinner(5);
        
        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompt.Count);
        return _prompt[index];
    }

    public string GetRandomQuestion()
    {
        Random rand = new Random();
        int index = rand.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}