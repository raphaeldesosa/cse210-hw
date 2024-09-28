public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {

        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What am I most grateful for today?",
        "What new thing did I learn today?",
        "How did I challenge myself today?",
        "What made me smile today?",
        "What could I have done to make today better?"
    };


    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}