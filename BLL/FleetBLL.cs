using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


public class FleetBLL
{
    public static readonly string TABLE_NAME = "ars_fleet";
    private static readonly string EXCEPTION_MESSAGE_RECORD_NOT_FOUND = "Fleet does not exist.";

    public static int InsertFleet(Fleet fleet)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IFleetDAO fleetDAO = new FleetDAO(con, TABLE_NAME);

            return fleetDAO.Insert(fleet);
        }
        catch
        {
            throw;
        }
    }

    public static int UpdateFleet(Fleet fleet)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IFleetDAO fleetDAO = new FleetDAO(con, TABLE_NAME);

            return fleetDAO.Update(fleet);
        }
        catch
        {
            throw;
        }
    }

    public static int DeleteFleet(Fleet fleet)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IFleetDAO fleetDAO = new FleetDAO(con, TABLE_NAME);

            if (!fleetDAO.IsFleetAvailableById(fleet))
                throw new RecordNotFoundException(EXCEPTION_MESSAGE_RECORD_NOT_FOUND);

            return fleetDAO.Delete(fleet);
        }
        catch
        {
            throw;
        }
    }

    public static Fleet GetFleetById(Fleet fleet)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IFleetDAO fleetDAO = new FleetDAO(con, TABLE_NAME);

            return fleetDAO.FindById(fleet.Id);
        }
        catch
        {
            throw;
        }
    }

    public static List<Fleet> GetAllFleet()
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ToString());
            IFleetDAO fleetDAO = new FleetDAO(con, TABLE_NAME);

            return fleetDAO.FindAll();
        }
        catch
        {
            throw;
        }
    }

}