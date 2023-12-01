public class Address
{
    private string _street, _city, _state, _country;
    public Address(street, city, state, country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country.ToLower();
    }

    public string Address()
    {
        return _street + ", " + _city + ", " + _state + ", " _country
    }
    public float USAorNot()
    {
        if (_country != "usa") or (_country != "united states")
        {
            return 35.00;
        }else{
            return 5.00;
        }
    }
}