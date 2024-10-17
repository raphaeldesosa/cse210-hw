public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) :base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        for (int i = 0; i < GetDuration(); i += 5)
        {
            Console.WriteLine("Breathe in..");
            ShowCountDown(3);
            Console.WriteLine("Now breathe out...");
            ShowCountDown(3);
        }

        DisplayEndingMessage();
    }    
}