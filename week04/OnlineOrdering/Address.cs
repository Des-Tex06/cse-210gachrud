public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public string GetStreetAddress()
    {
        return _streetAddress;
    }
    public void SetStreetAddress(string streetAddress)
    {
        _streetAddress = streetAddress;
    }
    public string GetCity()
    {
        return _city;
    }
    public void SetCity(string city)
    {
        _city = city;
    }
    public string GetStateProvince()
    {
        return _stateProvince;
    }
    public void SetStateProvince(string stateProvince)
    {
        _stateProvince = stateProvince;
    }
    public string GetCountry()
    {
        return _country;
    }
    public void SetCountry(string country)
    {
        _country = country;
    }
    public string DisplayAddress()
    {
        return $"{_streetAddress}, {_city}, {_stateProvince}, {_country}";
    }
    public bool ReturnUSAResidence()
    {
        return true;
    }
}