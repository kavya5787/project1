using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class BookingInfo
{
    private Destination _destinationFrom;

    public Destination DestinationFrom
    {
        get { return _destinationFrom; }
        set { _destinationFrom = value; }
    }
    private Destination _destinationTo;

    public Destination DestinationTo
    {
        get { return _destinationTo; }
        set { _destinationTo = value; }
    }
    private DateTime _departureDate;

    public DateTime DepartureDate
    {
        get { return _departureDate; }
        set { _departureDate = value; }
    }
    
    private SeatType _seatType;

    public SeatType SeatType
    {
        get { return _seatType; }
        set { _seatType = value; }
    }
    private Flight _flight;

    public Flight Flight
    {
        get { return _flight; }
        set { _flight = value; }
    }
    private List<Seat> _seat;

    public List<Seat> Seat
    {
        get { return _seat; }
        set { _seat = value; }
    }

    private int _extraBaggage;

    public int ExtraBaggage
    {
        get { return _extraBaggage; }
        set { _extraBaggage = value; }
    }

   
	public BookingInfo()
	{
        _flight = new Flight();
	}
}