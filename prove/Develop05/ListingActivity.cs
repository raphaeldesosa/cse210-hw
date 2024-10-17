public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompt;

    public ListingActivity(int count, string name, string description) :base(name, description)
    {
        _count = count;
        _prompt = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Think about the following prompt");
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(3);

        Console.WriteLine("Start listing: ");
        List<string> userItems = GetListFromUser(GetDuration());
        _count = userItems.Count;

        Console.WriteLine($"You listed {_count} items");

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(_prompt.Count);
        return _prompt[index];
    }

    public List<string> GetListFromUser(int duration)
    {
        List<string> userList = new List<string>();
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            
            string userInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(userInput))
            {
                userList.Add(userInput);
            }
            else
            {
                break;
            }
        }
        return userList;
    }
}