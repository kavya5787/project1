using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class SeatType
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

	public SeatType(int id)
	{
        _id = id;
	}

    public SeatType() { }
}