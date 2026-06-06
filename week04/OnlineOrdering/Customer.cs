public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
        // It's posible that I will make some changes to this _address 
        // variable later
    }

    // If this method DoLiveUSA didn't work I probably
    // would have to change the name of the method,
    // but also is very possible that works well

    public string GetName()
    {
        return _name;
    }

    public string GetFullAddress()
    {
        return _address.GetFullAddress();
    }
    public bool DoLiveUSA()
    {
        return _address.DoLiveUSA();
    }
}