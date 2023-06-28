using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Flight
{
    private int _id;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    private Destination _from;

    public Destination From
    {
        get { return _from; }
        set { _from = value; }
    }
    private Destination _to;

    public Destination To
    {
        get { return _to; }
        set { _to = value; }
    }
    private Fleet _fleet;

    public Fleet Fleet
    {
        get { return _fleet; }
        set { _fleet = value; }
    }
    private DateTime _departureDate;

    public DateTime DepartureDate
    {
        get { return _departureDate; }
        set { _departureDate = value; }
    }
    private DateTime _arrivalDate;

    public DateTime ArrivalDate
    {
        get { return _arrivalDate; }
        set { _arrivalDate = value; }
    }
    private FlightPrice _flightPrice;

    public FlightPrice FlightPrice
    {
        get { return _flightPrice; }
        set { _flightPrice = value; }
    }

    public Flight(int id)
    {
        _id = id;
        _from = new Destination();
        _to = new Destination();
        _fleet = new Fleet();
        _departureDate = new DateTime();
        _arrivalDate = new DateTime();
    }

    public Flight()
    {
        _from = new Destination();
        _to = new Destination();
        _fleet = new Fleet();
        _departureDate = new DateTime();
        _arrivalDate = new DateTime();
    }
}