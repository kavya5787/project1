using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class FlightPriceBLL
{
    public static readonly string TABLE_NAME = "ars_flight_price";
    private static readonly string EXCEPTION_MESSAGE_RECORD_NOT_FOUND = "FlightPrice does not exist.";

    public static int InsertFlightPrice(FlightPrice flightPrice)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IFlightPriceDAO flightPriceDAO = new FlightPriceDAO(con, TABLE_NAME);

            return flightPriceDAO.Insert(flightPrice);
        }
        catch
        {
            throw;
        }
    }

    public static int UpdateFlightPrice(FlightPrice flightPrice)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IFlightPriceDAO flightPriceDAO = new FlightPriceDAO(con, TABLE_NAME);

            if (!flightPriceDAO.IsFlightPriceAvailableById(flightPrice))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return flightPriceDAO.Update(flightPrice);
        }
        catch
        {
            throw;
        }
    }

    public static int DeleteFlightPrice(FlightPrice flightPrice)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IFlightPriceDAO flightPriceDAO = new FlightPriceDAO(con, TABLE_NAME);

            if (!flightPriceDAO.IsFlightPriceAvailableById(flightPrice))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return flightPriceDAO.Delete(flightPrice);
        }
        catch
        {
            throw;
        }
    }

    public static FlightPrice GetFlightPriceById(FlightPrice flightPrice)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IFlightPriceDAO flightPriceDAO = new FlightPriceDAO(con, TABLE_NAME);

            return flightPriceDAO.FindById(flightPrice.Id);
        }
        catch
        {
            throw;
        }
    }

    public static List<FlightPrice> GetAllFlightPrice()
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IFlightPriceDAO flightPriceDAO = new FlightPriceDAO(con, TABLE_NAME);

            return flightPriceDAO.FindAll();
        }
        catch
        {
            throw;
        }
    }

    public static FlightPrice GetFlightPriceByFlightIdAndSeatType(int flightId, int seatType) {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IFlightPriceDAO flightPriceDAO = new FlightPriceDAO(con, TABLE_NAME);

            return flightPriceDAO.FindFlightPriceByFlightIDAndSeatType(flightId, seatType);
        }
        catch
        {
            throw;
        }
    }

}