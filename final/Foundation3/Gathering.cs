public class Gathering : Event
{
    private string _weather;

    public Gathering(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override void GetFullDetails()
    {
        Console.WriteLine($"Type of Event: {GetType().Name}");
        GetStandardDetails();
        Console.WriteLine($"Weather forcast: {_weather}");
    }
}