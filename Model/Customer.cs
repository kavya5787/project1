using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Customer
{
    private int _id;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    private string _fullName;

    public string FullName
    {
        get { return _fullName; }
        set { _fullName = value; }
    }
    private string _email;

    public string Email
    {
        get { return _email; }
        set { _email = value; }
    }
    private string _username;

    public string Username
    {
        get { return _username; }
        set { _username = value; }
    }

    private string _password;

    public string Password
    {
        get { return _password; }
        set { _password = value; }
    }
    private string _contact;

    public string Contact
    {
        get { return _contact; }
        set { _contact = value; }
    }
    private string _address;

    public string Address
    {
        get { return _address; }
        set { _address = value; }
    }
    private string _image;

    public string Image
    {
        get { return _image; }
        set { _image = value; }
    }

    public Customer(int id)
    {
        _id = id;
    }

    public Customer()
    {
    }

}