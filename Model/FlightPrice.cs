using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class FlightPrice
{
    private int _id;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    private float _amount;

    public float Amount
    {
        get { return _amount; }
        set { _amount = value; }
    }
    private Flight _flight;

    public Flight Flight
    {
        get { return _flight; }
        set { _flight = value; }
    }
    private SeatType _seatType;

    public SeatType SeatType
    {
        get { return _seatType; }
        set { _seatType = value; }
    }

    public FlightPrice() {
        _flight = new Flight();
        _seatType = new SeatType();
    }

}