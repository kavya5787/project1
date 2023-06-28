using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Fleet
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
    private int _seatSize;

    public int SeatSize
    {
        get { return _seatSize; }
        set { _seatSize = value; }
    }

    public Fleet(int id)
    {
        _id = id;

    }

	public Fleet()
	{
		
	}
}