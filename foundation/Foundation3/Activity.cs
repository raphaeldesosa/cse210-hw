public abstract class Activity
{
    private DateTime _activityDate;
    private int _minutes;

    public Activity(DateTime activityDate, int minutes)
    {
        _activityDate = activityDate;
        _minutes = minutes;
    }

    public DateTime ActivityDate => _activityDate;
    public int Minutes => _minutes;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{_activityDate:dd MMM yyyy} {GetType().Name} ({_minutes}min): Distance: {GetDistance():0.0} km " + $"Speed: {GetSpeed():0.0} kph, Pace: {GetPace():0.0} min/km";
    }
}