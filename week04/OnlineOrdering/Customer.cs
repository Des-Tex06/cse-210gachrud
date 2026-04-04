public class Customer
{
    private string _name;
    Address _address;

    public string GetCustomerName()
    {
        return _name;
    }
    public void SetCustomerName(string name)
    {
        _name = name;
    }
    public Address GetAddress()
    {
        return _address;
    }
    //public Address SetAddress(string address)
    //{
    //    _address = address;
    //}

    Address ReturnUSAResidence()
    {
        return true;
    }
}