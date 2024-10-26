public class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    public virtual void RecordEvent()
    {
        Console.WriteLine("Event recorded for Goal:" + _shortName);
    }

    public virtual bool isComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
    {
        return $"Goal: {_shortName} \n Description: {_description} \n Points: {_points}";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points}";
    }

    public int GetPoints()
    {
        return int.TryParse(_points, out int points) ? points : 0;
    }
}
