using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class FlightBLL
{
    public static readonly string TABLE_NAME = "ars_flight";
    private static readonly string EXCEPTION_MESSAGE_RECORD_NOT_FOUND = "Flight does not exist.";

    public static int InsertFlight(Flight flight)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IFlightDAO flightDAO = new FlightDAO(con, TABLE_NAME);

            return flightDAO.Insert(flight);
        }
        catch
        {
            throw;
        }
    }

    public static int UpdateFlight(Flight flight)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IFlightDAO flightDAO = new FlightDAO(con, TABLE_NAME);

            if (!flightDAO.IsFlightAvailableById(flight))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return flightDAO.Update(flight);
        }
        catch
        {
            throw;
        }
    }

    public static int DeleteFlight(Flight flight)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IFlightDAO flightDAO = new FlightDAO(con, TABLE_NAME);

            return flightDAO.Delete(flight);
        }
        catch
        {
            throw;
        }
    }

    public static Flight GetFlightById(Flight flight)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IFlightDAO flightDAO = new FlightDAO(con, TABLE_NAME);

            return flightDAO.FindById(flight.Id);
        }
        catch
        {
            throw;
        }
    }

    public static List<Flight> GetAllFlight()
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IFlightDAO flightDAO = new FlightDAO(con, TABLE_NAME);

            return flightDAO.FindAll();
        }
        catch
        {
            throw;
        }
    }


    //public static List<Flight> SearchRoundTripFlight(BookingInfo bookingInfo)
    //{
    //    try
    //    {
    //        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
    //        IFlightDAO flightDAO = new FlightDAO(con, TABLE_NAME);

    //        return flightDAO.SearchTwoWayFlight(bookingInfo);
    //    }
    //    catch {
    //        throw;
    //    }
    //}

    public static List<Flight> SearchOneWayFlight(BookingInfo bookingInfo)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IFlightDAO flightDAO = new FlightDAO(con, TABLE_NAME);

            return flightDAO.SearchOneWayFlight(bookingInfo);
        }
        catch
        {
            throw;
        }
    }

}