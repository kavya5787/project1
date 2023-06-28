using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class User
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

    public User() { }

}