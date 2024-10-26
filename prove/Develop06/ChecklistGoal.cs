using System.Data.SqlTypes;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) :base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;

    }

    public override void RecordEvent()
    {
        _amountCompleted++;

        if (_amountCompleted >= _target)
        {
            Console.WriteLine($"Bonus achieved! + {_bonus} points");
        }
    }

    public override bool isComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} (Completed {_amountCompleted}/{_target}, Bonus: {_bonus})";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoals:{base.GetStringRepresentation()}|{_amountCompleted}|{_target}|{_bonus}";
    }
}