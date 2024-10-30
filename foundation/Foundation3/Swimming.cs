public class Swimming : Activity
{
    private int _laps;
    private const double LapDistanceKM = 50.0 / 1000;

    public Swimming(DateTime activityDate, int minutes, int laps) :base(activityDate, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * LapDistanceKM;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Minutes) * 60;
    }

    public override double GetPace()
    {
        return Minutes / GetDistance();
    }
}
