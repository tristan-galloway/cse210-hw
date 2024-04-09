public class Reception : Event
{
    private string _rsvp;

    public Reception(string title, string description, string date, string time, Address address, string rsvp) : base(title, description, date, time, address)
    {
        _rsvp = rsvp;
    }

    public override void GetFullDetails()
    {
        Console.WriteLine($"Type of Event: {GetType().Name}");
        GetStandardDetails();
        Console.WriteLine($"RSVP email: {_rsvp}");
    }
    
}