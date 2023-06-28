using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class PopularDestinationBLL
{
    public static readonly string TABLE_NAME = "ars_popular_destination";
    private static readonly string EXCEPTION_MESSAGE_RECORD_NOT_FOUND = "PopularDestination does not exist.";

    public static int InsertPopularDestination(PopularDestination popularDestination)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IPopularDestinationDAO popularDestinationDAO = new PopularDestinationDAO(con, TABLE_NAME);

            if (popularDestinationDAO.IsPopularDestinationAvailableByTitle(popularDestination))
                throw new DuplicateRecordException("PopularDestination already exist.");

            return popularDestinationDAO.Insert(popularDestination);
        }
        catch
        {
            throw;
        }
    }

    public static int UpdatePopularDestination(PopularDestination popularDestination)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IPopularDestinationDAO popularDestinationDAO = new PopularDestinationDAO(con, TABLE_NAME);

            if (!popularDestinationDAO.IsPopularDestinationAvailableById(popularDestination))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return popularDestinationDAO.Update(popularDestination);
        }
        catch
        {
            throw;
        }
    }

    public static int DeletePopularDestination(PopularDestination popularDestination)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IPopularDestinationDAO popularDestinationDAO = new PopularDestinationDAO(con, TABLE_NAME);

            if (!popularDestinationDAO.IsPopularDestinationAvailableById(popularDestination))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return popularDestinationDAO.Delete(popularDestination);
        }
        catch
        {
            throw;
        }
    }

    public static PopularDestination GetPopularDestinationById(PopularDestination popularDestination)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IPopularDestinationDAO popularDestinationDAO = new PopularDestinationDAO(con, TABLE_NAME);

            return popularDestinationDAO.FindById(popularDestination.Id);
        }
        catch
        {
            throw;
        }
    }

    public static List<PopularDestination> GetAllPopularDestination()
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IPopularDestinationDAO popularDestinationDAO = new PopularDestinationDAO(con, TABLE_NAME);

            return popularDestinationDAO.FindAll();
        }
        catch
        {
            throw;
        }
    }

    public static List<PopularDestination> GetTop3PopularDestination(int limit)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IPopularDestinationDAO popularDestinationDAO = new PopularDestinationDAO(con, TABLE_NAME);

            return popularDestinationDAO.GetPopularDestination(limit);
        }
        catch
        {
            throw;
        }
    }

}