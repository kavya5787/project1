using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class DestinationBLL
{
    public static readonly string TABLE_NAME = "ars_destination";
    private static readonly string EXCEPTION_MESSAGE_RECORD_NOT_FOUND = "Destination does not exist.";

    public static int InsertDestination(Destination destination)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IDestinationDAO destinationDAO = new DestinationDAO(con, TABLE_NAME);

            return destinationDAO.Insert(destination);
        }
        catch
        {
            throw;
        }
    }

    public static int UpdateDestination(Destination destination)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IDestinationDAO destinationDAO = new DestinationDAO(con, TABLE_NAME);

            if (!destinationDAO.IsDestinationAvailableById(destination))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return destinationDAO.Update(destination);
        }
        catch
        {
            throw;
        }
    }

    public static int DeleteDestination(Destination destination)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IDestinationDAO destinationDAO = new DestinationDAO(con, TABLE_NAME);

            if (!destinationDAO.IsDestinationAvailableById(destination))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return destinationDAO.Delete(destination);
        }
        catch
        {
            throw;
        }
    }

    public static Destination GetDestinationById(Destination destination)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IDestinationDAO destinationDAO = new DestinationDAO(con, TABLE_NAME);

            return destinationDAO.FindById(destination.Id);
        }
        catch
        {
            throw;
        }
    }

    public static List<Destination> GetAllDestination()
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IDestinationDAO destinationDAO = new DestinationDAO(con, TABLE_NAME);

            return destinationDAO.FindAll();
        }
        catch
        {
            throw;
        }
    }

}