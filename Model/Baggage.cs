using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Baggage
{
    private int _id;

    public int Id
    {
        get { return _id; }
        set { _id = value; }
    }
    private int _weightFrom;

    public int WeightFrom
    {
        get { return _weightFrom; }
        set { _weightFrom = value; }
    }
    private int _weightTo;

    public int WeightTo
    {
        get { return _weightTo; }
        set { _weightTo = value; }
    }
    private float _charge;

    public float Charge
    {
        get { return _charge; }
        set { _charge = value; }
    }

	public Baggage()
	{
		
	}
}