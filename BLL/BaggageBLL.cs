using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class BaggageBLL
{
    public static readonly string TABLE_NAME = "ars_baggage";
    private static readonly string EXCEPTION_MESSAGE_RECORD_NOT_FOUND = "Baggage does not exist.";

    public static int InsertBaggage(Baggage baggage)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IBaggageDAO baggageDAO = new BaggageDAO(con, TABLE_NAME);

            if (baggageDAO.IsBaggageAvailableByTitle(baggage))
                throw new DuplicateRecordException("Baggage already exist.");

            return baggageDAO.Insert(baggage);
        }
        catch
        {
            throw;
        }
    }

    public static int UpdateBaggage(Baggage baggage)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IBaggageDAO baggageDAO = new BaggageDAO(con, TABLE_NAME);

            if (!baggageDAO.IsBaggageAvailableById(baggage))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return baggageDAO.Update(baggage);
        }
        catch
        {
            throw;
        }
    }

    public static int DeleteBaggage(Baggage baggage)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IBaggageDAO baggageDAO = new BaggageDAO(con, TABLE_NAME);

            if (!baggageDAO.IsBaggageAvailableById(baggage))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return baggageDAO.Delete(baggage);
        }
        catch
        {
            throw;
        }
    }

    public static Baggage GetBaggageById(Baggage baggage)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IBaggageDAO baggageDAO = new BaggageDAO(con, TABLE_NAME);

            return baggageDAO.FindById(baggage.Id);
        }
        catch
        {
            throw;
        }
    }

    public static List<Baggage> GetAllBaggage()
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IBaggageDAO baggageDAO = new BaggageDAO(con, TABLE_NAME);

            return baggageDAO.FindAll();
        }
        catch
        {
            throw;
        }
    }

}