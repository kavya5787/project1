using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Booking
{
    private int _id;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    private Customer _customer;

    public Customer Customer
    {
        get { return _customer; }
        set { _customer = value; }
    }
    private Flight _flight;

    public Flight Flight
    {
        get { return _flight; }
        set { _flight = value; }
    }

    private Seat _seat;

    public Seat Seat
    {
        get { return _seat; }
        set { _seat = value; }
    }
    private int _totalPassenger;

    public int TotalPassenger
    {
        get { return _totalPassenger; }
        set { _totalPassenger = value; }
    }
    private string _action;

    public string Action
    {
        get { return _action; }
        set { _action = value; }
    }

    public Booking() {
        _customer = new Customer();
        _flight = new Flight();
        _seat = new Seat();
    }
    
}