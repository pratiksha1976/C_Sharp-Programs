using System;

public class Contact
{
    private string _name;
    private long _mobile;
    private long _altMobile;
    private string _address;
    private string _email;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public long Mobile
    {
        get { return _mobile; }
        set { _mobile = value; }
    }

    public long AltMobile
    {
        get { return _altMobile; }
        set { _altMobile = value; }
    }

    public string Address
    {
        get { return _address; }
        set { _address = value; }
    }

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }

    public Contact(string name, long mobile, long altMobile, string address, string email)
    {
        _name = name;
        _mobile = mobile;
        _altMobile = altMobile;
        _address = address;
        _email = email;
    }
}
