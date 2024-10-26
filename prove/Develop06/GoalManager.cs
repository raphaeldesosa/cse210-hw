using System.Diagnostics.CodeAnalysis;

public class GoalManager
{
    private List<Goal> _goal;
    private int _score;

    public GoalManager(int score)
    {
        _goal = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        Console.WriteLine("Welcome to Eternal Quest! Track your goals and earn rewards.");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player score: {_score}");
    }

    public void ListGoalNames()
    {
        foreach (var goal in _goal)
        {
            string status = goal.isComplete() ? "[X]" : "[]";
            Console.WriteLine($"{status} {goal.GetDetailsString()}");
        }
    }

    public void ListGoalDetails()
    {
        foreach (var goal in _goal)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select a goal type: 1. SimpleGoal \n 2. EternalGoal \n 3. ChecklistGoal");
        string choice = Console.ReadLine();

        Console.Write("Enter a goal name:");
        string shortName = Console.ReadLine();

        Console.Write("Enter a description:");
        string description = Console.ReadLine();

        Console.Write("Enter goal points:");
        string points = Console.ReadLine();

        if (choice == "1")
        {
            _goal.Add(new SimpleGoal(shortName, description, points));
        }
        else if ( choice == "2")
        {
            _goal.Add(new EternalGoal(shortName, description, points));
        }
        else if (choice == "3")
        {
            Console.Write("Enter target number of completions: ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Enter a bonus point: ");
            int bonus = int.Parse(Console.ReadLine());
            
            _goal.Add(new ChecklistGoal(shortName, description, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid choice. Goal creation cancelled");
        }
        
    }

    public void RecordEvent()
    {
        Console.WriteLine("Select a goal to record an event");
        for (int i = 0; i <_goal.Count; i++)
        {
            Console.WriteLine($"{i+1}. {_goal[i].GetDetailsString()}");
        }
        
        if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= _goal.Count)
        {
            Goal selectedGoal = _goal[choice - 1];
            selectedGoal.RecordEvent();
            _score += selectedGoal.GetPoints();
            Console.WriteLine($"Event recorded! Total score: {_score}");
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goal)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals and scores, saved!");
    }

    public void LoadGoals()
    {
        if (!File.Exists("goals.txt"))
        {
            Console.WriteLine("No save data found.");
            return;
        }

        _goal.Clear();
        using (StreamReader reader = new StreamReader("goals.txt"))
        {
            if (int.TryParse(reader.ReadLine(), out int savedScore))
            {
                _score = savedScore;
            }

            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                string[] parts = line.Split(',');
                if (parts.Length < 4)
                {
                    Console.WriteLine($"Invalid line format: {line}");
                    continue;
                }
                string type = parts[0];
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];

                if (int.TryParse(points, out int parsedPoints))
                {

                    if (type == "SimpleGoal")
                    {
                        _goal.Add(new SimpleGoal(name, description, parsedPoints.ToString()));
                    }
                    else if (type == "EternalGoal")
                    {
                        _goal.Add(new EternalGoal(name, description, parsedPoints.ToString()));
                    }
                    else if (type == "ChecklistGoal")
                    {
                        if(parts.Length < 6)
                        {
                            Console.WriteLine($"Invalid ChecklistGoal format {line}");
                            continue;
                        }
                        int target = int.Parse(parts[4]);
                        int bonus = int.Parse(parts[5]);

                        _goal.Add(new ChecklistGoal(name, description, parsedPoints.ToString(), target, bonus));
                    }
                }    
            }
        }
        Console.WriteLine("Goals and score loaded");
    }
}