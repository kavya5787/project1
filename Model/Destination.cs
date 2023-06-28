using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Destination
{
    private int _id;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    private string title;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }

    public Destination(int id)
    {
        _id = id;
    }

    public Destination()
    {
    }
}