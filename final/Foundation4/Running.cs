public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, double time, double distance) : base(date, time)
    {
        _distance = distance;
    }

    public override double GetSpeed()
    {
        return _distance / _time * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override double GetDistance()
    {
        return _distance;
    }
}