using System;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running(new DateTime(2024, 10, 30), 30, 5),
            new Cycling(new DateTime(2024, 10, 30), 60, 10 ),
            new Swimming(new DateTime(2024, 10, 30), 20, 5)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}