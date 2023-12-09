public class Customer
{
    private string _name;
    private Address _address;

    public Customer (string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsInUSA()
    {
        bool check = _address.USA();
        return check;
    }

    public string Name()
    {
        return _name;
    }
    public string Address()
    {
        return _address.AddressString();
    }
}