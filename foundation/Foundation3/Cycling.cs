public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime activityDate, int minute, double speed) :base(activityDate, minute)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * Minutes) / 60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }
}