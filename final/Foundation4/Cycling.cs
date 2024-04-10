public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, double time, double speed) : base(date, time)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override double GetDistance()
    {
        return GetSpeed() * (_time / 60);
    }
}