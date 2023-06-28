using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class BookedSeat
{
    private int _id;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    private int _seatId;

    public int SeatId
    {
        get { return _seatId; }
        set { _seatId = value; }
    }
   
}