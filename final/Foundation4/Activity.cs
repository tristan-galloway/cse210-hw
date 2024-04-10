public abstract class Activity
{
    protected DateTime _date;
    protected double _time;

    public Activity(DateTime date, double time)
    {
        _date = date;
        _time = time;
    }

    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public void GetSummary()
    {
        // Example String
        // 03 Nov 2022 Running (30 min)- Distance 3.0 miles, Speed 6.0 mph, Pace: 10.0 min per mile
        Console.WriteLine($"{_date.ToString("dd MMM yyyy")} {GetType().Name} ({_time} min) - Distance {Math.Round(GetDistance(), 1)} miles, Speed {Math.Round(GetSpeed(), 1)} mph, Pace: {Math.Round(GetPace(), 1)} min per mile");
    }
}