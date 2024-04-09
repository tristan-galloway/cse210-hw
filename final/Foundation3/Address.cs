using System.Reflection.Metadata.Ecma335;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public string DisplayString()
    {
        return $"{_streetAddress} {_city}, {_state} {_country}";
    }
}