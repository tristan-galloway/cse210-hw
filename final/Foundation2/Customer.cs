public class Customer
{
    private string _name; 
    private Address _address;
    
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool FromUSA()
    {
        return _address.IsInUSA();
    }

    public string GetAddress()
    {
        return _address.DisplayString();
    }
}