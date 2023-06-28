using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Client
{
    private int _id;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    private string _title;

    public string Title
    {
        get { return _title; }
        set { _title = value; }
    }
    private string _icon;

    public string Icon
    {
        get { return _icon; }
        set { _icon = value; }
    }

    public Client()
    {
    }

    public Client(string title, string icon)
    {
        this._title = title;
        this._icon = icon;
    }

    public Client(int id, string title, string icon)
    {
        this._id = id;
        this._title = title;
        this._icon = icon;
    }


}