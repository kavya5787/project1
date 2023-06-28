using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Seat
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
    private Fleet _fleet;

    public Fleet Fleet
    {
        get { return _fleet; }
        set { _fleet = value; }
    }
    private SeatType _seatType;

    public SeatType SeatType
    {
        get { return _seatType; }
        set { _seatType = value; }
    }

	public Seat()
	{
        _fleet = new Fleet();
        _seatType = new SeatType();
	}

    public Seat(int id)
    {
        _id = id;
        _fleet = new Fleet();
        _seatType = new SeatType();
    }
}