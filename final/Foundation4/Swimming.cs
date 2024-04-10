using System.Dynamic;
using System.Runtime.CompilerServices;

public class Swimming : Activity
{
    private double _laps;
    // 1 lap = 50 meters;

    public Swimming(DateTime date, double time, double laps) : base(date, time)
    {
        _laps = laps;
    }

    public override double GetSpeed()
    {
        return GetDistance() / _time * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1609.34;
    }


}